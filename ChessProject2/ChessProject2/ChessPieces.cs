using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    internal class ChessPieces
    {
        public string Color { get; set; }

        public int PositionX { get; set; }

        public int PositionY { get; set; }


    }

    internal class Pawn : ChessPieces
    {
        public Pawn(string colour, int x, int y)
        {
            Color = colour;
            PositionX = x;
            PositionY = y;
        }
    }

}
