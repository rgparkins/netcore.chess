using NUnit.Framework;
using Saucar.Chess.Models;

namespace Saucar.Chess.Tests.Board
{
    [Example(1, 1)]
    [Example(8, 1)]
    [Example(8, 8)]
    public class Valid_starting_position : contexts.boardContext
    {
        public Valid_starting_position(int row, int column)
        {
            Given_a_board(8, 8);

            When_placing_the_piece(row, column);
        }

        [Test]
        public void The_piece_is_placed_on_the_board_at_the_correct_position()
        {
            Assert.That(Knight.Position, Is.EqualTo(Position.From(_row, _column)));
        }
    }
}