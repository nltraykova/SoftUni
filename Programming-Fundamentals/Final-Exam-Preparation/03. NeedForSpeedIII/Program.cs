using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> listOfCars = new List<Car>();
            
            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] infoCars = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
                string name = infoCars[0];
                int mileage = int.Parse(infoCars[1]);
                int fuel = int.Parse(infoCars[2]);

                Car car = new Car(name, mileage, fuel);

                listOfCars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] tokens = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Drive":
                        Drive(tokens[1], int.Parse(tokens[2]), int.Parse(tokens[3]), listOfCars);
                        break;
                    case "Refuel":
                        Refuel(tokens[1], int.Parse(tokens[2]), listOfCars);
                        break;
                    case "Revert":
                        Revert(tokens[1], int.Parse(tokens[2]), listOfCars);
                        break;
                }


                command = Console.ReadLine();
            }

            foreach (var car in listOfCars)
            {
                Console.WriteLine($"{car.Name} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }
        
        static void Drive(string carName, int distance, int fuel, List<Car> listOfCars)
        {
            Car car = listOfCars.First(car => car.Name == carName);

            if (car.Fuel - fuel <= 0)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                car.Mileage += distance;
                car.Fuel -= fuel;
                Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
            }

            if (car.Mileage >= 100000)
            {
                listOfCars.Remove(car);
                Console.WriteLine($"Time to sell the {carName}!");
            }
        }

        static void Refuel(string carName, int fuel, List<Car> listOfCars)
        {
            Car car = listOfCars.First(car => car.Name == carName);

            int currFuel = car.Fuel;
            
            car.Fuel += fuel;

            if (car.Fuel > 75)
            {
                car.Fuel = 75;
            }

            Console.WriteLine($"{carName} refueled with {car.Fuel - currFuel} liters");
        }

        static void Revert(string carName, int kilometers, List<Car> listOfCars)
        {
            Car car = listOfCars.First(car => car.Name == carName);

            int currMileage = car.Mileage;
            
            car.Mileage -= kilometers;

            if (car.Mileage < 10000)
            {
                car.Mileage = 10000;
                return;
            }

            Console.WriteLine($"{carName} mileage decreased by {currMileage - car.Mileage} kilometers");
        }

    }

    class Car
    {
        public Car(string name, int mileage, int fuel)
        {
            this.Name = name;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }
        public string Name { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
