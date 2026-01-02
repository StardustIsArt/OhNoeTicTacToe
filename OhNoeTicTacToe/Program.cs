using System.Data;
using OhNoeTicTacToe;
public static class Program
{
    static void Main(string[] args)
    {
        char[,] board = new char[GameConstants.BOARD_SIZE, GameConstants.BOARD_SIZE];
        GameLogic.InitializeBoard(board);
        UIMethods.DisplayGamePlay();
        char player = GameConstants.USER_SYMBOL;
        bool gameOver = false;
        while (!gameOver)
        {
            UIMethods.DisplayTicTacToeBoard(board);
            if (GameConstants.USER_SYMBOL == player)
            {
                var (row, col) = UIMethods.GetPlayerMove();
                if (!GameLogic.PlaceMark(board, row, col, player))
                {
                    UIMethods.DisplayAlreadyTaken();
                    System.Threading.Thread.Sleep(300);
                    UIMethods.DisplayTicTacToeBoard(board);
                    continue;
                }
                Console.Clear();
                System.Threading.Thread.Sleep(225);
            }
            else
            {
                UIMethods.DisplayAITurn();
                System.Threading.Thread.Sleep(600);
                GameLogic.AIMove(board, GameConstants.AI_SYMBOL);
            }

            if (GameLogic.CheckWinner(board, player))
            {
                UIMethods.DisplayWinner(board, player);
                break;
            }
        }
    }
}



