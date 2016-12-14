using NUnit.Framework;

namespace Saucar.Chess.Tests.Board
{
    [Example(0, 8)]
    [Example(1, 9)]
    [Example(8, 0)]
    public class Invalid_starting_position : contexts.boardContext
    {
        public Invalid_starting_position(int row, int column)
        {
            Given_a_board(8, 8);

            When_placing_the_piece(row, column);
        }

        [Test]
        public void Piece_is_not_added_to_the_board()
        {
            Assert.That(_board.Pieces.Count, Is.EqualTo(0));
        }
    }
}