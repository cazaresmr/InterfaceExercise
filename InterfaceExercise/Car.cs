using InterfaceExercise.Interfaces;
using System;

namespace InterfaceExercise.Models
{
    public class Car : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; } = 4;
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public bool HasTrunk { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Car Details:\n Make: {Make}, Model: {Model}, Color: {Color}, Wheels: {NumberOfWheels}, Has Trunk: {HasTrunk}\n Company: {Name}, Logo: {Logo}");
        }
    }
}
