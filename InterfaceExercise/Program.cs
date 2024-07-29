using InterfaceExercise.Models;
using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car
            {
                Make = "Toyota",
                Model = "Camry",
                Color = "Red",
                HasTrunk = true,
                Name = "Toyota Company",
                Logo = "Toyota Logo"
            };

            var truck = new Truck
            {
                Make = "Ford",
                Model = "F-150",
                Color = "Black",
                BedSize = 8.0,
                Name = "Ford Company",
                Logo = "Ford Logo"
            };

            var suv = new SUV
            {
                Make = "Honda",
                Model = "CR-V",
                Color = "Blue",
                NumberOfSeats = 5,
                Name = "Honda Company",
                Logo = "Honda Logo"
            };

            car.DisplayDetails();
            truck.DisplayDetails();
            suv.DisplayDetails();

            Console.ReadLine();
        }
    }
}
