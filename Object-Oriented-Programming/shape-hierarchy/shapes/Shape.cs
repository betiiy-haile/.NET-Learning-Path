// we use abstract key word here - to avoid instantiation of this class - we can't create an object of this class
public abstract class Shape {
    public string Name { get; set; }
    protected  Shape( string name) {
        Name = name;
    }

    public abstract  double CalculateArea();
}