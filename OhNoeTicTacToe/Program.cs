using OhNoeTicTacToe;
public static class Program
{
    static void Main(string[] args)
    {
        char[,] board = new char[GameConstants.BOARD_SIZE, GameConstants.BOARD_SIZE];
        GameLogic.InitializeBoard(board);
        UIMethods.UserBoardMark();
        bool gameOver = false;
        while (!gameOver)
        {
            if (GameConstants.UserSymbol == 'X')
            {
                
            }
        }
        UIMethods.DisplayTicTacToeBoard(board);
    }
}



