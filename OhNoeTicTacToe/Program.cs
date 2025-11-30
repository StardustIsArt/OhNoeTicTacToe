using OhNoeTicTacToe;

UIMethods.DisplayTicTacToe();

int size = 0;
board = new char[size, size];

for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        board[row, col] = ' ';
    }
}
