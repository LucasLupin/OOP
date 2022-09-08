using System;
namespace Galactica
{
    internal abstract class SpaceObjects
    {
    // Add properties.
        public int? Id { get; set; }
        public string? Name { get; set; }

        public virtual Position? Pos { get; set; }

    // Make an nested class Position consisting of two coordinates: X, Y.
        public class Position
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    // position overrides tostring and returns values in (X, Y).
        public override string ToString()
        {
            if (Pos != null)
                return $"({Pos.X},{Pos.Y})";
            else return string.Empty;
        }
    }
}