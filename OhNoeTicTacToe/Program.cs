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
            var (row, col) = UIMethods.GetPlayerMove();
            UIMethods.DisplayTicTacToeBoard(board);
            if (GameConstants.USER_SYMBOL == player)
            {
                UIMethods.GetPlayerMove();
                if (!GameLogic.PlaceMark(board, row, col, player))
                {
                    UIMethods.DisplayAlreadyTaken();
                    continue;
                }
            }
            else
            {
                UIMethods.DisplayAITurn();
            }
        }
        UIMethods.DisplayTicTacToeBoard(board);
    }
}



