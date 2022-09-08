using System;
namespace Galactica
{
    // Create enum with planettypes.
    enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }

    // Inherit from Parent Class SpaceObjects.
    internal class Planet : SpaceObjects
    {
    // Add properties: planettype, diameter (m), rotation period (h), revolution period (d).
        public PlanetType Type { get; set; }
        public int Diameter { get; set; }
        public int RevolutionPeriod { get; set; }
        public int RotationPeriod { get; set; }

        // Create a list and add moons.
        public List<Moon>? MoonList { get; set; }

    // Calculate distance.
        public double? Distance()
        {
            if (Pos != null)
                return Math.Sqrt((Math.Abs(Pos.X) ^ 2) + (Math.Abs(Pos.Y) ^ 2));
            else return null;
        }
    }
}