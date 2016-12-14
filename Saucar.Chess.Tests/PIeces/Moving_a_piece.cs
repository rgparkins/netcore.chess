using System.Collections.Immutable;
using System.Linq;
using NUnit.Framework;
using Saucar.Chess.Models;
using Saucar.Chess.Tests.contexts;

namespace Saucar.Chess.Tests.Pieces
{
    public class Moving_a_piece : boardContext
    {
        public Moving_a_piece()
        {
            Given_a_board(8, 8);

            When_placing_the_piece(1,1);

            When_moving_the_piece();
        }

        [Test]
        public void Piece_has_moved()
        {
            Assert.That(_board.Pieces.First().Position, Is.Not.EqualTo(Position.From(1, 1)));
        }
    }
}