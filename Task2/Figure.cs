namespace Task2;

public class Figure
{
    public Point[] points;
    
    public Figure(Point point1, Point point2, Point point3)
    {
        points = new Point[] { point1, point2, point3 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        points = new Point[] { point1, point2, point3, point4 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        points = new Point[] { point1, point2, point3, point4, point5 };
    }

    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)); 
        // https://www.geogebra.org/m/FuTSBcrP
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        int pointsCount = points.Length;

        for (int i = 0; i < pointsCount; i++)
        {
            Point currentPoint = points[i];
            Point nextPoint = points[(i + 1) % pointsCount];
            perimeter += GetSideLength(currentPoint, nextPoint);
        }
        
        Console.WriteLine($"Назва багатокутника: {points.Length}-кутник");
        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}