
namespace Cars
{
    public class Car : IEquatable<Car?>
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Car);
        }

        public bool Equals(Car? other)
        {
            return other != null &&
                   Model == other.Model &&
                   Color == other.Color;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Model, Color);
        }
    }
}
