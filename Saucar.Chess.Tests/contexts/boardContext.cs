using Saucar.Chess.Models;

namespace Saucar.Chess.Tests.contexts
{
    public class boardContext
    {
        protected int _column;
        protected int _row;
        protected Chessboard _board;
        public Models.Knight Knight;

        protected void Given_a_board(int row, int column)
        {
            _board = new Chessboard(8, 8);
        }

        protected void When_placing_the_piece(int row, int column)
        {
            _row = row;
            _column = column;

            Knight = new Models.Knight(_board);
            Knight.Init(row, column);
        }

        protected void When_moving_the_piece()
        {
            Knight.Move();
        }
    }
}