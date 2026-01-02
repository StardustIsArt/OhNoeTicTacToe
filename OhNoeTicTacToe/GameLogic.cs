using System;
using System.Collections.Generic;
using System.Data;
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
    public static bool PlaceMark(char[,] board, int row, int col, char mark)
    {
        if (board[row, col] != ' ')
        {
            return false;
        }
        board[row, col] = mark;
        return true;
    }

    public static void AIMove(char[,] board, char AIsymbol)
    {
        Random random = new Random();
        int row, col;
        do
        {
            row = random.Next(0, GameConstants.BOARD_SIZE);
            col = random.Next(0, GameConstants.BOARD_SIZE);
        } while (board[row, col] != ' ');

        board[row, col] = AIsymbol;
    }

    public static bool CheckWinner(char[,] board, char mark)
    {
        int size = board.GetLength(0);
        for (int r = 0; r < size; r++)
        {
            if (board[r, 0] == mark && board[r, 1] == mark && board[r, 2] == mark)
            {
                return true;
            }
        }
        for (int c = 0; c < size; c++)
        {
            if (board[0, c] == mark && board[1, c] == mark && board[2, c] == mark)
            {
                return true;
            }
        }
        if (board[0, 0] == mark && board[1, 1] == mark && board[2, 2] == mark)
        {
            return true;
        }

        if (board[0, 2] == mark && board[1, 1] == mark && board[2, 0] == mark)
        {
            return true;
        }
        return false;
    }
}
