using System;
namespace Galactica
{
    // Create enum with startypes.
    enum StarType { YellowDwarf, White, BlueNeutron, RedGiant }

    // Inherit from Parent Class SpaceObjects.
    internal class Star : SpaceObjects
    {
    // Add properties.
        public StarType Type { get; set; }
        public int Temperature { get; set; }

    // Create a list of planets.
        public List<Planet>? PlanetList { get; set; }

    // Coordinates of the Sun must always be 0,0.

        public override Position? Pos { get; set; } = new Position() { X = 0, Y = 0 };
    }
}


