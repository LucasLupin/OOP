namespace Galactica
{
    internal class Data
    {
        public Star Sun = new Star();

        private List<Planet> planets;

        public Data()
        {
            planets = new List<Planet>();

            AddPlanets();

            Sun.PlanetList = planets;
        }

    // Here Will the mehod AddPlanets run, This Do what the name says(It add Planets to the List)
        void AddPlanets()
        {

            Planet earth = new Planet()
            {
                Name = "Earth  ",
                Diameter = 12756,
                RevolutionPeriod = 365,
                RotationPeriod = 24,
                Id = 2,
                Type = PlanetType.Terrestial,
                Pos = new SpaceObjects.Position { X = 6, Y = -8 }
            };
            // Add Earth moons to an Earth moon list.
            earth.MoonList = new() { new Moon { Name = "Luna", Orbiting = earth, Pos = new SpaceObjects.Position() { X = 1, Y = 0 } } };

            Planet venus = new Planet()
            {
                Name = "Venus  ",
                Diameter = 12104,
                RevolutionPeriod = 224,
                RotationPeriod = -5832,
                Id = 1,
                Type = PlanetType.Terrestial,
                Pos = new SpaceObjects.Position { X = 3, Y = 4 }
            };

            Planet mercury = new Planet()
            {
                Name = "Mercury",
                Diameter = 4879,
                RevolutionPeriod = 88,
                RotationPeriod = 1407,
                Id = 0,
                Type = PlanetType.Terrestial,
                Pos = new SpaceObjects.Position { X = 0, Y = 1 }
            };

            Planet mars = new Planet()
            {
                Name = "Mars   ",
                Diameter = 6792,
                RevolutionPeriod = 687,
                RotationPeriod = 24,
                Id = 3,
                Type = PlanetType.Terrestial,
                Pos = new SpaceObjects.Position { X = -8, Y = -12 }
            };
            // Add Mars moons to an Mars moon list.
            mars.MoonList = new()
            {
                new Moon { Name = "Phobos", Orbiting = mars, Pos = new SpaceObjects.Position() { X = 1, Y = 2 } },
                new Moon { Name = "Deimos", Orbiting = mars, Pos = new SpaceObjects.Position() { X = -2, Y = 3 } }
            };

            Planet jupiter = new Planet()
            {
                Name = "Jupiter",
                Diameter = 142984,
                RevolutionPeriod = 4331,
                RotationPeriod = 10,
                Id = 4,
                Type = PlanetType.Gas_Giant,
                Pos = new SpaceObjects.Position { X = 4, Y = -20 }
            };

        // Add Jupiter moons to an Jupiter moon list.
            jupiter.MoonList = new()
             {
                new Moon { Name = "Ganymede", Orbiting = jupiter, Pos = new SpaceObjects.Position() { X = 1, Y = 2 } },
                new Moon { Name = "Europe", Orbiting = jupiter, Pos = new SpaceObjects.Position() { X = -2, Y = 3 } },
                new Moon { Name = "Lo", Orbiting = jupiter, Pos = new SpaceObjects.Position() { X = 1, Y = 4 } }
             };

            Planet saturn = new Planet()
            {
                Name = "Saturn ",
                Diameter = 120536,
                RevolutionPeriod = 10747,
                RotationPeriod = 10,
                Id = 5,
                Type = PlanetType.Gas_Giant,
                Pos = new SpaceObjects.Position { X = 32, Y = -10 }
            };
        // Add Saturn moons to an Saturn moon list.
            saturn.MoonList = new()
            {
            new Moon { Name = "Titan", Orbiting = saturn, Pos = new SpaceObjects.Position() { X = -3, Y = 2 } },
            new Moon { Name = "Mimas", Orbiting = saturn, Pos = new SpaceObjects.Position() { X = 1, Y = 2 } }
            };

            Planet uranus = new Planet()
            {
                Name = "Uranus ",
                Diameter = 51118,
                RevolutionPeriod = 30589,
                RotationPeriod = -17,
                Id = 6,
                Type = PlanetType.Gas_Giant,
                Pos = new SpaceObjects.Position { X = 38, Y = 58 }
            };

            Planet neptune = new Planet()
            {
                Name = "Neptune",
                Diameter = 49528,
                RevolutionPeriod = 59800,
                RotationPeriod = 16,
                Id = 7,
                Type = PlanetType.Gas_Giant,
                Pos = new SpaceObjects.Position { X = -75, Y = -82 }
            };

            Planet pluto = new Planet()
            {
                Name = "Pluto  ",
                Diameter = 2376,
                RevolutionPeriod = 90560,
                RotationPeriod = 153,
                Id = 8,
                Type = PlanetType.Dwarf,
                Pos = new SpaceObjects.Position { X = 150, Y = 99 }
            };

            // Here add you every planet to the list.
            planets.Add(earth);
            planets.Add(venus);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptune);
            planets.Add(pluto);
        }
    }

}
