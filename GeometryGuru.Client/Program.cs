using GeometryGuru.Application.Services;
using GeometryGuru.Domain.Models;

class Program
{
    static void Main()
    {
        ShapeService service = new();

        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;    
            Console.WriteLine("=== GEOMETRY GURU ===");
            Console.ResetColor();
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("0. Chiqish");
            Console.Write("Tanlang (1-3): ");

            string tanla = Console.ReadLine();

            switch (tanla)
            {
                case "1":
                    CreateCircle(service);
                    break;

                case "2":
                    CreateRectangle(service);
                    break;

                case "3":
                    CreateTriangle(service);
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Xato tanlov!");
                    toxta();
                    break;
            }
        }
    }

    static void CreateCircle(ShapeService service)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=== CIRCLE ===");
        Console.ResetColor();
        double radius = ReadPositiveDouble("Radiusni kiriting: ");
        Shape circle = new Circle(radius);

        ShowResult(service.CalculateArea(circle));
    }

       static void CreateRectangle(ShapeService service)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=== RECTANGLE ===");
        Console.ResetColor();
        double width = ReadPositiveDouble("Enini kiriting: ");
        double height = ReadPositiveDouble("Bo'yini kiriting: ");

        Shape rectangle = new Rectangle(width, height);

        ShowResult(service.CalculateArea(rectangle));
    }

    static void CreateTriangle(ShapeService service)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=== TRIANGLE ===");
        Console.ResetColor();
        double b = ReadPositiveDouble("Asosini kiriting: ");
        double h = ReadPositiveDouble("Balandligini kiriting: ");

        Shape triangle = new Triangle(b, h);

        ShowResult(service.CalculateArea(triangle));
    }

    static double ReadPositiveDouble(string message)
    {
        double value;
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                return value;

            Console.WriteLine("Xato! Musbat son kiriting.");
        }
    }

    static void ShowResult(double natija)
    {
        Console.WriteLine($"\nNatija:{natija}");
        toxta();
    }

    static void toxta()
    {
        Console.WriteLine("\nDavom etish uchun biror tugma bosing...");
        Console.ReadKey();
    }
}
