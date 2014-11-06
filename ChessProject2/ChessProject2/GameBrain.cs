using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    class GameBrain
    {
        
        public void TryingHard()
        {
            string[,] board = new string[8,8];
            int y = 0;
            for (int x = 0; x <=7; x++)
            {
                board[x, y] = "[ ]";
                for ( y = 0; y <=7; y++)
                {
                    board[x, y] = "y";    
                }
            }
        }
    }
}
