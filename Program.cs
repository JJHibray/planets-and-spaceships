using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {

        List<string> planetList = new List<string>()
        {"Mercury", "Mars"};

        planetList.Add("Jupiter");
        planetList.Add("Saturn");

        List<string> lastPlanets = new List<string>()
        {"Uranus", "Neptune"};

        planetList.AddRange(lastPlanets);

        // inserts items in spots targeted with index numbers
        planetList.Insert(1, "Venus");
        planetList.Insert(2, "Earth");

        planetList.Add("Pluto");

        planetList.ForEach(planets => Console.WriteLine(planets));

        Console.WriteLine("\noutput = planetList.GetRange(2, 3).ToArray()");


        // grabs items in list from starting index of zero and over 4 spots, in this case Mercury is 0 ends at Earth
        string[] output = planetList.GetRange(0, 4).ToArray();

        Console.WriteLine();
        foreach ( string planet in output )
            {
                 Console.WriteLine(planet);
            }
        // removes pluto from list
        planetList.Remove("Pluto");

         planetList.ForEach(planets => Console.WriteLine(planets));

        }
    }
}
