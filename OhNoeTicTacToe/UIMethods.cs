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

    public static void UserBoardMark(string boardMarked)
    {
       Console.WriteLine("Which place on the board you would like next: ");
       Console.WriteLine("Make your input by selecting the row 1st and column 2nd. Example: [0, 2]\n " +
                         "input 0 = 1st row/col\n" +
                         "input 1 = 2nd row/col\n" +
                         "input 2 = 3rd row/col\n");
       boardMarked =  // input needs to be passed within an array to choose the spot. [row, col]
      
    }
 
    public static void UserSymbol(char symbol)
    {
        
    }
}