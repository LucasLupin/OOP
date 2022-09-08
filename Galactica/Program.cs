using Galactica;


Data data = new();

if (data.Sun.PlanetList == null) return;
// Here Write it Planets: . 
// (\n = Next Line).
Console.WriteLine("Planets:");

// Here do it an Foreach on all planets and moons, and write them out (Name),(Type),(Distance to Sun).
foreach (Planet p in data.Sun.PlanetList)
{
    Console.WriteLine($"\n{p.Name} Type:  {p.Type}    Distance To Sun: {p.Distance()} {p.ToString()}");
    if (p.MoonList != null)
// If Moonlist not is equal to Null will it print the moons name out.
    {
        Console.WriteLine("Moons: ");
        foreach (Moon m in p.MoonList)
        {
            Console.WriteLine($"\t{m.Name}");
        }
    }
}