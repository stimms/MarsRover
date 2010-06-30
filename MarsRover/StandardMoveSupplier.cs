using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    class StandardMoveSupplier:IMoveSupplier
    {
        public StandardMoveSupplier(IMoveParser moveParser)
        {

        }

        Queue<IMove> moves = new Queue<IMove>();
        public void Init(string moves)
        {
            
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
