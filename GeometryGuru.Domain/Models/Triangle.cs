namespace GeometryGuru.Domain.Models;

public class Triangle : Shape
{
    public double Base { get; }
    public double Height { get; }

    public Triangle(double b, double h)
    {
        Base = b;
        Height = h;
    }

    public override double CalculateArea()
    {
        return (Base * Height) / 2;
    }
}
