using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhNoeTicTacToe;
public static class GameLogic
{
    public static void InitializeBoard(char[,] board)
    {
        for (int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                board[row, col] = ' ';
            }
        }
    }
    
    
    
}
