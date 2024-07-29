using InterfaceExercise.Interfaces;
using System;

namespace InterfaceExercise.Models
{
    public class SUV : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; } = 4;
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public int NumberOfSeats { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"SUV Details:\n Make: {Make}, Model: {Model}, Color: {Color}, Wheels: {NumberOfWheels}, Number of Seats: {NumberOfSeats}\n Company: {Name}, Logo: {Logo}");
        }
    }
}
