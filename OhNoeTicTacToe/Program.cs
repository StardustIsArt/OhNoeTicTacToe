using OhNoeTicTacToe;

public static class Program
{
    static void Main(string[] args)
    {
        const int BOARD_SIZE = 3;
        char[,] board = new char[BOARD_SIZE, BOARD_SIZE];

        for (int row = 0; row < BOARD_SIZE; row++)
        {
            for (int col = 0; col < BOARD_SIZE; col++)
            {
                board[row, col] = ' ';
            }
        }
        UIMethods.DisplayTicTacToeBoard(board);
    }
}



