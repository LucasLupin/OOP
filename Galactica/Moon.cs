using System;
namespace Galactica
{
    // Inherit from Parent Class Planet.
    // Moon class is sealed so that no class can inherit from it.
    internal sealed class Moon : Planet
    {
    // Add properties Orbiting (From the type Planet).
        public Planet? Orbiting { get; set; }

    // Calculate distance.
        public double? Distance(Planet planet)
        {
            if (Pos != null && planet.Pos != null)
                return Math.Sqrt((Pos.X - planet.Pos.X) ^ 2 + (Pos.Y - planet.Pos.Y) ^ 2);
            else return null;
        }
    // Distance to orbiting planet.
        
    }
}
