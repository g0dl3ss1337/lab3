using System;
using System.Text;

namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        Console.WriteLine("Введіть довжину першої сторони прямокутника: ");
        double side1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Введіть довжину другої сторони прямокутника:");
        double side2 = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);
        
        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
    }
}