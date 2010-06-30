using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Reflection;
using System.IO;


using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using Castle.Core.Resource;
using System.Drawing;

namespace MarsRover
{
    class Program
    {
        static IWindsorContainer container;
        static int Main(string[] args)
        {
            CheckArguments(args);

            ConstructContainer();


            IGrid grid = (IGrid)container[typeof(IGrid)];
            
            String[] lines = File.ReadAllLines(args[0]);
            grid.InitiGrid(Int32.Parse(lines[0].Split(' ').First()), Int32.Parse(lines[0].Split(' ').Skip(1).First()));

            for (int i = 0; i < lines.Skip(1).Count(); i+=2)
            {
                string locationLine = lines.Skip(1).Skip(i).First();
                string movesLine = lines.Skip(1).Skip(i).Skip(1).First();
                MoveRover(grid, locationLine, movesLine);
            }
            container.Release(grid);
            
            return 0;

        }

        private static void ConstructContainer()
        {
            container = new WindsorContainer(new XmlInterpreter(new ConfigResource("castle")));
        }
        private static void CheckArguments(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Write(MarsRover.UsageMessage);
                Environment.Exit(-1);
            }

            if (!File.Exists(args[0]))
            {
                Console.Write(String.Format(MarsRover.MissingFile, args[0]));
                Environment.Exit(-1);
            }
        }
        private static void MoveRover(IGrid grid, string locationLine, string movesLine)
        {
            IDirectionParser directionParser = (IDirectionParser)container[typeof(IDirectionParser)];
            ILocationParser locationParser = (ILocationParser)container[typeof(ILocationParser)];

            Direction direction = directionParser.GetDirection(locationLine);
            Point location = locationParser.GetLocation(locationLine);
            IMoveSupplier supplier = (IMoveSupplier)container[typeof(IMoveSupplier)];

            supplier.Init(movesLine);
            Rover rover = new Rover(direction, location, grid, supplier);
            try
            {
                rover.ExecuteMoves();
            }
            catch (InvalidLocationException ex)
            {
                Console.WriteLine(MarsRover.IllegalLocation);
            }
            Console.WriteLine(String.Format("{0} {1} {2}", rover.Location.X, rover.Location.Y, rover.Direction));

            container.Release(supplier);
            container.Release(directionParser);
            container.Release(locationParser);
        }


    }
}
