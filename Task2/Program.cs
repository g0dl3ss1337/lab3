namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        Figure rectangle = new Figure(
            new Point(0, 0, "a"),
            new Point(4, 0, "b"),
            new Point(4, 3, "c"),
            new Point(0, 3, "d")
        );

        rectangle.CalculatePerimeter();
    }
}