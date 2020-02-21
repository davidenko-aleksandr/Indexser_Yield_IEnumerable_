using System;
using System.Collections.Generic;

namespace Indexser_Yield_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car {Name = "Skoda", Number = "TSK 11767"},
                new Car {Name = "Mitsubisi", Number = "AE 2759"}
            };
            var parking = new Parking();
            foreach (var car in cars)
            {
                parking.Add(car);
            }
            foreach (var car in parking)
            {
                Console.WriteLine(car);
            }
            foreach(var name in parking.GetName())
            {
                Console.WriteLine($"Get Name {name}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(parking["TSK 11767"].Name);
            Console.WriteLine( "Введите номер Автомобиля");
            var num = Console.ReadLine();

            parking[1] = new Car { Name = "BMW", Number = num };

            Console.WriteLine(parking[1]);
        }
    }
}
