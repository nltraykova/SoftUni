using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Catalogue catalog = new Catalogue();
            
            while (input != "end")
            {
                string[] tokens = input.Split('/').ToArray();

                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int horsePowerOrWeight = int.Parse(tokens[3]);

                switch (type)
                {
                    case"Car":
                        Car car = new Car
                        {
                            Brand = brand,
                            Model = model,
                            HorsePower = horsePowerOrWeight
                        };

                        catalog.Cars.Add(car);

                        break;
                    case "Truck":
                        Truck truck = new Truck
                        {
                            Brand = brand,
                            Model = model,
                            Weight = horsePowerOrWeight
                        };

                        catalog.Trucks.Add(truck);

                        break;
                }

                input = Console.ReadLine();
            }

            if (catalog.Cars.Count > 0)
            {
                List<Car> orderedCars = catalog.Cars.OrderBy(car => car.Brand).ToList();

                Console.WriteLine("Cars:");

                foreach (var car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                List<Truck> orderedTrucks = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();

                Console.WriteLine("Trucks:");

                foreach (var truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}

class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}

class Catalogue
{
    public Catalogue()
    {
        this.Trucks = new List<Truck>();
        this.Cars = new List<Car>();
    }
    public List<Truck> Trucks { get; set; }
    public List<Car> Cars { get; set; }
}