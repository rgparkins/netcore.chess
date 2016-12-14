using System;

namespace Saucar.Chess.Models
{
    public class Position : IEquatable<Position>
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public static Position Null
        {
            get { return new Position(0, 0); }
        }

        public bool Equals(Position other)
        {
            return other.Row == Row && other.Column == Column;
        }

        public static object From(int row, int col)
        {
            return new Position(row, col);
        }

        public Position FromOffset(Tuple<int, int> move)
        {
            return new Position(Row + move.Item1, Column + move.Item2);
        }
    }
}