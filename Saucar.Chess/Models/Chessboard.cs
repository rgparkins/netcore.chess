using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Saucar.Chess.Models
{
    public class Chessboard
    {
        List<Piece> _pieces = new List<Piece>();

        public Chessboard(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        public int Rows { get; set; }
        public int Columns { get; set; }

        public IList<Piece> Pieces
        {
            get
            {
                return new ReadOnlyCollection<Piece>(_pieces);
            }
        }

        public void AddPiece(Piece piece)
        {
            _pieces.Add(piece);
        }

        public bool IsValidPosition(Position position)
        {
            if (position == Position.Null)
                return false;

            if (position.Row <= 0 || position.Column <= 0)
                return false;

            if (position.Row > Rows || position.Column > Columns)
                return false;

            return true;
        }

        public List<Position> GetMoves(Piece piece)
        {
            var list = new List<Position>();

            foreach (var move in piece.Moves)
            {
                var fromOffset = piece.Position.FromOffset(move);

                if (IsValidPosition(fromOffset) && !AnotherPieceIsOccupying(fromOffset))
                {
                    list.Add(fromOffset);
                }
            }

            return list;
        }

        private bool AnotherPieceIsOccupying(Position fromOffset)
        {
            return _pieces.Any(p => p.Position.Equals(fromOffset));
        }
    }
}