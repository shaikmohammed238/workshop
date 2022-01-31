using System;
using System.Collections.Generic;
using System.Text;

namespace workshop
{
    class TicTacToegame
    {
        
        char[] Display = new char[9];
        public void GameBoard()
        {
            for (int i = 1; i < 9; i++)
            {
                Display[i] = ' ';
            }
        }
    }
}
