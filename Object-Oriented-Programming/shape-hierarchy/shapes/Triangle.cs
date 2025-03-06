public class Triangle : Shape {

    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(string name, double height, double baseLength) : base(name)
    {
        Base = baseLength;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Base * Height / 2; 
    }
}