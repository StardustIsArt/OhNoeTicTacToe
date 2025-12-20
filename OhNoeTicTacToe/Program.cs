using System.Data;
using OhNoeTicTacToe;
public static class Program
{
    static void Main(string[] args)
    {
        char[,] board = new char[GameConstants.BOARD_SIZE, GameConstants.BOARD_SIZE];
        GameLogic.InitializeBoard(board);
        UIMethods.DisplayGamePlay();
      
        UIMethods.GetPlayerMove();
        
        bool gameOver = false;
        while (!gameOver)
        {
            UIMethods.DisplayTicTacToeBoard(board);
            if (GameConstants.UserSymbol == 'X')
            {
                
            }
        }
        UIMethods.DisplayTicTacToeBoard(board);
    }
}



