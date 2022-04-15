using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Vehicle> listOfVehicles = new List<Vehicle>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cars = input
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
                char[] typeArr = cars[0].ToCharArray();
                typeArr[0] = char.ToUpper(typeArr[0]);
                string type = new string(typeArr);
                string model = cars[1];
                string color = cars[2];
                int horsePower = int.Parse(cars[3]);
                Vehicle currVehicle = new Vehicle(type, model, color, horsePower);
                listOfVehicles.Add(currVehicle);
            }
            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (var car in listOfVehicles)
                {
                    if (car.Model == input)
                    {
                        Console.WriteLine($"Type: {car.Type}");
                        Console.WriteLine($"Model: { car.Model}");
                        Console.WriteLine($"Color: { car.Color}");
                        Console.WriteLine($"Horsepower: { car.Horsepower}");
                    }
                }
            }
            List<Vehicle> carTypes = listOfVehicles.Where(x => x.Type == "Car").ToList();
            List<Vehicle> truckTypes = listOfVehicles.Where(x => x.Type == "Truck").ToList();
            if (carTypes.Count >= 1)
            {
                PrintAveragHPcars(carTypes);

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            if (truckTypes.Count >= 1)
            {
                PrintAveragHPtrucs(truckTypes);
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }

        }
        static void PrintAveragHPcars(List<Vehicle> carTypes)
        {
            decimal carAvrHP = 0;

            foreach (var car in carTypes)
            {
                carAvrHP += car.Horsepower;

            }
            carAvrHP = carAvrHP / carTypes.Count;
            Console.WriteLine($"Cars have average horsepower of: {carAvrHP:f2}.");

        }
        static void PrintAveragHPtrucs(List<Vehicle> truckTypes)
        {
            decimal truckAvrHP = 0;

            foreach (var car in truckTypes)
            {
                truckAvrHP += car.Horsepower;

            }
            truckAvrHP = truckAvrHP / truckTypes.Count;
            Console.WriteLine($"Trucks have average horsepower of: {truckAvrHP:f2}.");
        }
    }
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }
}
