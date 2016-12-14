using NUnit.Framework;
using Saucar.Chess.Models;
using Saucar.Chess.Tests.contexts;

namespace Saucar.Chess.Tests.Pieces
{
    public class Moving_a_piece_with_second_piece_in_the_way : boardContext
    {
        public Moving_a_piece_with_second_piece_in_the_way()
        {
            Given_a_board(8, 8);

            When_placing_the_piece(2,3);

            When_placing_the_piece(1,1);

            When_moving_the_piece();
        }

        [Test]
        public void There_are_two_pieces_on_the_board()
        {
            Assert.That(_board.Pieces.Count, Is.EqualTo(2));
        }

        [Test]
        public void The_second_piece_has_moved_to_the_only_remaining_position()
        {
            Assert.That(Knight.Position, Is.EqualTo(Position.From(3, 2)));
        }
    }
}