using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitCollectionString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program splits a collection of strings into groups.");

            List<string> cities = new List<string>() { "Warsaw", "Rome", "Paris", "Lisbon", "New York", "London", "Berlin", "Moscow", "Oslo", "Madrid", "Barcelona", "Hong Kong" };

            var groupedCities = from city in Enumerable.Range(0, cities.Count)
                                group cities[city] by city / 4;

            foreach (var city in groupedCities)
            {
                Console.WriteLine(string.Join(";  ", city.ToArray()));
            }
            Console.ReadKey();
        }
    }
}
