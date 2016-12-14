using System;
using System.Collections.Generic;

namespace Saucar.Chess.Models
{
    public interface IProvideMoves
    {
        List<Tuple<int, int>> Moves { get; }
    }

    public abstract class Piece : IEquatable<Piece>, IProvideMoves
    {
        public readonly Chessboard Board;
        public Position Position = Position.Null;
        public readonly string Id;

        protected Piece(Chessboard board)
        {
            Board = board;
            Id = Guid.NewGuid().ToString();
        }

        public void Init(int row, int col)
        {
            var position = new Position(row, col);

            if (Board.IsValidPosition(position))
            {
                Position = position;
                Board.AddPiece(this);
            }
        }

        public bool Equals(Piece other)
        {
            return Id == other.Id;
        }

        public abstract List<Tuple<int, int>> Moves { get; }
    }
}