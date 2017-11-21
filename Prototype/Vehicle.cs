namespace PrototypePattern
{
    // Abstract class that will be implemented by concrete classes.
    abstract class Vehicle
    {
        // Clone method that returns Vehicle and will be implented by concrete classes. 
        public abstract Vehicle Clone();

        // Properties
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
