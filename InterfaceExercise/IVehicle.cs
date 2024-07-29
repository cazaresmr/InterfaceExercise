namespace InterfaceExercise.Interfaces
{
    public interface IVehicle
    {
        int NumberOfWheels { get; set; }
        string Color { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        void DisplayDetails();
    }
}
