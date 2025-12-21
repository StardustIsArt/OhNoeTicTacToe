using System.Data;
using OhNoeTicTacToe;
public static class Program
{
    static void Main(string[] args)
    {
        char[,] board = new char[GameConstants.BOARD_SIZE, GameConstants.BOARD_SIZE];
        GameLogic.InitializeBoard(board);
        UIMethods.DisplayGamePlay();
        
        bool gameOver = false;
        while (!gameOver)
        {
            UIMethods.DisplayTicTacToeBoard(board);
            if (GameConstants.USER_SYMBOL == 'X')
            {
                UIMethods.GetPlayerMove();
                if (!GameLogic.PlaceMark())
                {
                    UIMethods.DisplayAlreadyTaken();
                }
            }
        }
        UIMethods.DisplayTicTacToeBoard(board);
    }
}



