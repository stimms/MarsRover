using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    public class StandardMoveSupplier:IMoveSupplier
    {
        IMoveParser moveParser;
        public StandardMoveSupplier(IMoveParser moveParser)
        {
            this.moveParser = moveParser;
        }

        Queue<IMove> moves = new Queue<IMove>();
        public void Init(string movesString)
        {
            foreach (IMove move in moveParser.GetMoves(movesString))
                moves.Enqueue(move);
        }
        public IMove NextMove()
        {
            return moves.Dequeue();
        }
        public bool HasNextMove()
        {
            return moves.Count > 0;
        }
    }
}
