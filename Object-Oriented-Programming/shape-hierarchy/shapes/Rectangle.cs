public class Rectangle : Shape {

    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(string name, double width, double height) : base(name)
    {
        Width = width;
        Height = height;
    }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}