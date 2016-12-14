using NUnit.Framework;
using Saucar.Chess.Tests.contexts;

namespace Saucar.Chess.Tests.Pieces
{
    [Example(1, 1, 2)]
    [Example(1, 2, 3)]
    [Example(1, 3, 4)]
    [Example(1, 4, 4)]
    [Example(1, 5, 4)]
    [Example(1, 6, 4)]
    [Example(1, 7, 3)]
    [Example(1, 8, 2)]
    [Example(2, 1, 3)]
    [Example(2, 2, 4)]
    [Example(2, 3, 6)]
    [Example(2, 4, 6)]
    [Example(2, 5, 6)]
    [Example(2, 6, 6)]
    [Example(2, 7, 4)]
    [Example(2, 8, 3)]
    [Example(3, 1, 4)]
    [Example(3, 2, 6)]
    [Example(3, 3, 8)]
    [Example(3, 4, 8)]
    [Example(3, 5, 8)]
    [Example(3, 6, 8)]
    [Example(3, 7, 6)]
    [Example(3, 8, 4)]
    [Example(4, 1, 4)]
    [Example(4, 2, 6)]
    [Example(4, 3, 8)]
    [Example(4, 4, 8)]
    [Example(4, 5, 8)]
    [Example(4, 6, 8)]
    [Example(4, 7, 6)]
    [Example(4, 8, 4)]
    [Example(5, 1, 4)]
    [Example(5, 2, 6)]
    [Example(5, 3, 8)]
    [Example(5, 4, 8)]
    [Example(5, 5, 8)]
    [Example(5, 6, 8)]
    [Example(5, 7, 6)]
    [Example(5, 8, 4)]
    [Example(6, 1, 4)]
    [Example(6, 2, 6)]
    [Example(6, 3, 8)]
    [Example(6, 4, 8)]
    [Example(6, 5, 8)]
    [Example(6, 6, 8)]
    [Example(6, 7, 6)]
    [Example(6, 8, 4)]
    [Example(7, 1, 3)]
    [Example(7, 2, 4)]
    [Example(7, 3, 6)]
    [Example(7, 4, 6)]
    [Example(7, 5, 6)]
    [Example(7, 6, 6)]
    [Example(7, 7, 4)]
    [Example(7, 8, 3)]
    [Example(8, 1, 2)]
    [Example(8, 2, 3)]
    [Example(8, 3, 4)]
    [Example(8, 4, 4)]
    [Example(8, 5, 4)]
    [Example(8, 6, 4)]
    [Example(8, 7, 3)]
    [Example(8, 8, 2)]
    public class Available_moves : boardContext
    {
        private readonly int _numberOfPossibleMoves;

        public Available_moves(int row, int col, int numberOfPossibleMoves)
        {
            _numberOfPossibleMoves = numberOfPossibleMoves;
            Given_a_board(8, 8);

            When_placing_the_piece(row, col);
        }

        [Test]
        public void Number_of_available_positions_is_calculated()
        {
            Assert.That(Knight.PossibleMoves().Count, Is.EqualTo(_numberOfPossibleMoves));
        }
    }
}