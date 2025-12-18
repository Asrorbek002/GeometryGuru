using GeometryGuru.Domain.Models;

namespace GeometryGuru.Application.Services;

public class ShapeService
{
    public double CalculateArea(Shape shape)
    {
        return shape.CalculateArea();
    }
}
