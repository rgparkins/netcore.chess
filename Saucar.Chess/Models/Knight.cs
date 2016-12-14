using System;
using System.Collections.Generic;
using System.Linq;

namespace Saucar.Chess.Models
{
    public class Knight : Piece
    {
        public Knight(Chessboard board) : base(board)
        {
        }

        public List<Position> PossibleMoves()
        {
            return Board.GetMoves(this);
        }

        public override List<Tuple<int, int>> Moves => new List<Tuple<int, int>>
        {
            Tuple.Create(1, 2),
            Tuple.Create(1, -2),
            Tuple.Create(-1, 2),
            Tuple.Create(-1, -2),
            Tuple.Create(2, 1),
            Tuple.Create(2, -1),
            Tuple.Create(-2, 1),
            Tuple.Create(-2, -1)
        };

        public void Move()
        {
            var moves = Board.GetMoves(this);

            Position = moves.First();
        }
    }
}