using OhNoeTicTacToe;

UIMethods.DisplayTicTacToeBoard();

const int BOARD_SIZE = 3;
char[,] board;
board = new char[BOARD_SIZE, BOARD_SIZE];

for (int row = 0; row < BOARD_SIZE; row++)
{
    for (int col = 0; col < BOARD_SIZE; col++)
    {
        board[row, col] = ' ';
    }
}

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
    }
    Console.WriteLine();
}
