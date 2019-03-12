using System;
using System.Collections.Generic;

namespace Planets_SpaceShips
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            //`Add()` Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            //Create another `List` that contains that last two planet of our solar system.
            List<string> lastPlanets = new List<string>() { "Uranus", "Neptune" };

            //Combine the two lists by using `AddRange()`.
            planetList.AddRange(lastPlanets);

            //Use `Insert()` to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            //Use `Add()` again to add Pluto to the end of the list.
            planetList.Add("Pluto");

            //Now that all the planets are in the list, slice the list using `GetRange()` in order to extract the rocky planets into a new list called `rockyPlanets`.
            List<string> rockyPlanets = planetList.GetRange(0, 4);

            //Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the `Remove()` method to eliminate it from the end of `planetList`.
            planetList.Remove("Pluto");

           
            var solarSystemProbes = new Dictionary<string, List<string>>();
          
            solarSystemProbes.Add("Mars", new List<string> { "Viking", "Opportunity", "Curiosity" });
            solarSystemProbes.Add("Mercury", new List<string> { "Messanger", "Mariner" });
            solarSystemProbes.Add("Venus", new List<string> { "Mariner","Vanera" });
            solarSystemProbes.Add("Earth", new List<string> { "Pioneer", "Mariner" });
            solarSystemProbes.Add("Jupiter", new List<string> { "Pioneer", "Voyager" });
            solarSystemProbes.Add("Saturn", new List<string> { "Pioneer", "Voyager" });
            solarSystemProbes.Add("Uranus", new List<string> { "Voyager" });
            solarSystemProbes.Add("Neptune", new List<string> { "Voyager" });

            foreach (var planet in planetList)
            {
                string solarSystemProbesList = "";
                foreach (var (planets, probes) in solarSystemProbes)
                {
                    if (planet == planets)
                    {
                        foreach (var probe in probes)
                        {
                            solarSystemProbesList += $" {probe}" + ",";
                        }
                    }
                }
                
                Console.WriteLine($"{planet}: {solarSystemProbesList.TrimEnd(',')}");
            }
            Console.ReadLine();
        }
    }
}
