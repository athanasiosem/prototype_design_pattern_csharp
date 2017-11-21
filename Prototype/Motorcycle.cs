namespace PrototypePattern
{
    // Concrete class Motorcycle inherits Vehicle
    class Motorcycle : Vehicle
    {
        // Default constructor
        public Motorcycle()
        {

        }

        // Ovveriden method Clone() that clones the object
        public override Vehicle Clone()
        {
            return (Vehicle)MemberwiseClone();
        }
    }
}
