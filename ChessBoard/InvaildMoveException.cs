using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class InvaildMoveException : ApplicationException
    {
        public InvaildMoveException()
        { }

        public InvaildMoveException(string message)
            : base(message)
        { }

        public InvaildMoveException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
