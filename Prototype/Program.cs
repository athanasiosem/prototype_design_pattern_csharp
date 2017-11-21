using System.Diagnostics;

namespace PrototypePattern
{
    // Client Class
    static class Program
    {
        // Main method
        static void Main()
        {

            // Example #1
            // Instantiate a Car class
            var car1 = new Car()
            {
                Brand ="BMW",
                Model = "Z3"
            };

            // Get an exact copy of the car1 car.
            var car2 = (Car)car1.Clone();

            // Print car2 details - it should print "Brand is: BMW and model is: Z3"
            Debug.WriteLine("Brand is: " + car2.Brand + " and model is: " + car2.Model);

            // Example #2
            // Instantiate a Motorcycle class
            var motorcycle1 = new Motorcycle()
            {
                Brand = "Yamaha",
                Model = "Z125"
            };

            // Get an exact copy of the motorcycle1 motorcycle.
            var motorcycle2 = (Motorcycle)motorcycle1.Clone();

            // Print motorcycle2 details - it should print "Brand is: Yamaha and model is: Z125"
            Debug.WriteLine("Brand is: " + motorcycle2.Brand + " and model is: " + motorcycle2.Model);

        }
    }
}
