public class Program {
    public static void PrintShapeArea(Shape shape){
        Console.WriteLine($"Shape: {shape.Name}, Area: {shape.CalculateArea()}");
    }

      public static void Main(){
        // Create instances of shapes
        Circle circle = new Circle("Circle", 5);
        Rectangle rectangle = new Rectangle("Rectangle", 4, 6);
        Triangle triangle = new Triangle("Triangle", 4, 5);

        // Print the area of each shape
        PrintShapeArea(circle);
        PrintShapeArea(rectangle);
        PrintShapeArea(triangle);
      }
}