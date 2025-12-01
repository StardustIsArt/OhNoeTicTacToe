using OhNoeTicTacToe;
public static class Program
{
    static void Main(string[] args)
    {
        const int BOARD_SIZE = 3;
        char[,] board = new char[BOARD_SIZE, BOARD_SIZE];
        GameLogic.InitializeBoard(board);
        
        UIMethods.DisplayTicTacToeBoard(board);
    }
}



