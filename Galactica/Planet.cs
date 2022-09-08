using System;
namespace Galactica
{
    // It Make a Enum With Planttypes
    enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }

    // This is Inherit from Parent Class SpaceObjects.
    internal class Planet : SpaceObjects
    {
    // Add properties: planettype, diameter, rotation period, revolution period.
        public PlanetType Type { get; set; }
        public int Diameter { get; set; }
        public int RevolutionPeriod { get; set; }
        public int RotationPeriod { get; set; }

        // Make a list and add moons.
        public List<Moon>? MoonList { get; set; }

    // This Calculate distance.
        public double? Distance()
        {
            if (Pos != null)
                return Math.Sqrt((Math.Abs(Pos.X) ^ 2) + (Math.Abs(Pos.Y) ^ 2));
            else return null;
        }
    }
}