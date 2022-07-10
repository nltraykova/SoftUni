using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Vehicle> listOfVehicles = new List<Vehicle>();
            
            while (input != "End")
            {
                string[] vehicleProperties = input.Split().ToArray();

                TypeOfVehicle type;

                bool isTypeOfVehicleParseSuccessful = Enum.TryParse(vehicleProperties[0], true, out type);

                if (isTypeOfVehicleParseSuccessful)
                {
                    string model = vehicleProperties[1];
                    string color = vehicleProperties[2];
                    int horsepower = int.Parse(vehicleProperties[3]);
                    
                    Vehicle vehicle = new Vehicle(type, model, color, horsepower);

                    listOfVehicles.Add(vehicle);
                }
            
                input = Console.ReadLine();
            }

            string cmd = Console.ReadLine();

            while (cmd != "Close the Catalogue")
            {
                foreach (var vehicle in listOfVehicles)
                {
                    if (vehicle.Model == cmd)
                    {
                        Console.WriteLine(vehicle);
                    }
                }

                cmd = Console.ReadLine();
            }

            List<Vehicle> cars = listOfVehicles.Where(vehicle => vehicle.Type == TypeOfVehicle.Car).ToList();
            List<Vehicle> trucks = listOfVehicles.Where(vehicle => vehicle.Type == TypeOfVehicle.Truck).ToList();

            double avgHorsepowerOfCars = cars.Count > 0 ? cars.Average(car => car.Horsepower) : 0.00; //ако има поне една кола -> сметни средните конски сили, ако не -> върни 0.00;
            double avgHorsepowerOfTrucks = trucks.Count > 0 ? trucks.Average(truck => truck.Horsepower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {avgHorsepowerOfCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgHorsepowerOfTrucks:f2}.");
        }
    }


    enum TypeOfVehicle
    {
        Car,
        Truck
    }
    
    class Vehicle
    {
        public Vehicle(TypeOfVehicle type, string model, string color, int horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }
        public TypeOfVehicle Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Type: {this.Type}");
            stringBuilder.AppendLine($"Model: {this.Model}");
            stringBuilder.AppendLine($"Color: {this.Color}");
            stringBuilder.AppendLine($"Horsepower: {this.Horsepower}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
