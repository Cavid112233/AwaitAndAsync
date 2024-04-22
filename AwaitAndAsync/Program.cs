namespace AwaitAndAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            await car.DriveAsync();

            var vehicle = new Vehicle();
            await vehicle.TravelAsync();
        }
    }
}
