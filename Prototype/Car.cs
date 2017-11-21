namespace PrototypePattern
{
    // Concrete class Car inherits Vehicle
    class Car : Vehicle
    {
        // Default constructor
        public Car()
        {

        }

        // Ovveriden method Clone() that clones the object
        public override Vehicle Clone()
        {
            return (Vehicle)MemberwiseClone();
        }
    }
}
