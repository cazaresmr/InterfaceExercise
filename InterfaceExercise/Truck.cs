using InterfaceExercise.Interfaces;
using System;

namespace InterfaceExercise.Models
{
    public class Truck : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; } = 6;
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public double BedSize { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Truck Details:\n Make: {Make}, Model: {Model}, Color: {Color}, Wheels: {NumberOfWheels}, Bed Size: {BedSize}\n Company: {Name}, Logo: {Logo}");
        }
    }
}
