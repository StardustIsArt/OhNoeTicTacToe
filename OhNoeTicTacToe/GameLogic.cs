using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhNoeTicTacToe;
public static class GameLogic
{
    private static readonly Random random = new Random();
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
    
    public static void UpdateBoardWithAIMove(char[,] board, char AIsymbol)
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
        for (int r = GameConstants.TOP_LINE; r < size; r++)
        {
            if (board[r, GameConstants.TOP_LINE] == mark && board[r, GameConstants.MID_LINE] == mark && board[r, GameConstants.BOT_LINE] == mark)
            {
                return true;
            }
        }
        for (int c = 0; c < size; c++)
        {
            if (board[GameConstants.LEFT_LINE, c] == mark && board[GameConstants.MID_LINE, c] == mark && board[GameConstants.RIGHT_LINE, c] == mark)
            {
                return true;
            }
        }
        if (board[GameConstants.LEFT_LINE, GameConstants.TOP_LINE] == mark && board[GameConstants.MID_LINE, GameConstants.MID_LINE] == mark && board[GameConstants.RIGHT_LINE, GameConstants.BOT_LINE] == mark)
        {
            return true;
        }

        if (board[GameConstants.LEFT_LINE, GameConstants.BOT_LINE] == mark && board[GameConstants.MID_LINE, GameConstants.MID_LINE] == mark && board[GameConstants.RIGHT_LINE, GameConstants.TOP_LINE] == mark)
        {
            return true;
        }
        return false;
    }

    public static bool IsBoardFull(char[,] board)
    {
        foreach (char c in board)
            if (c != ' ')
                return false;
        return true;
        }
    }

