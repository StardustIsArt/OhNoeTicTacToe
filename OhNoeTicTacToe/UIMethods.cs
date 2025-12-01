using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhNoeTicTacToe;
public static class UIMethods
{ 
    public static void DisplayTicTacToeBoard(char [,] board)
    {
        int BOARD_SIZE = board.GetLength(0);
        for (int row = 0; row < BOARD_SIZE; row++)
        {
            for (int col = 0; col < BOARD_SIZE; col++)
            {
                Console.Write($"{board[row, col]}");
                if (col < BOARD_SIZE - 1) Console.Write(" | ");
            }
            Console.WriteLine();
            if (row < BOARD_SIZE - 1)
            {
                for (int i = 0; i < BOARD_SIZE; i++)
                {
                    Console.Write("---");
                    if (i < BOARD_SIZE - 1) Console.Write("+");
                }
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }
}