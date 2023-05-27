using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.OutputEncoding = Encoding.UTF8;
            Point center = new Point(0, 0);
            double radius = 5;
            Circle circle = new Circle(center, radius);

            Console.WriteLine("Центр кола: ({0}, {1})", center.X, center.Y);
            Console.WriteLine("Радіус кола: {0}", radius);

            Point point1 = new Point(3, 4);
            Console.WriteLine("Точка ({0}, {1})  {2} колу", point1.X, point1.Y, circle.ContainsPoint(point1) ? "належить" : "не належить");

            Point point2 = new Point(6, 7);
            Console.WriteLine("Точка ({0}, {1})  {2} колу ", point2.X, point2.Y, circle.ContainsPoint(point2) ? "належить" : "не належить");

            Console.WriteLine("Введіть значення х точки");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення у для точки");
            int m = int.Parse(Console.ReadLine());
            Point point3 = new Point(n, m);
            Console.WriteLine("Точка ({0}, {1})  {2} колу ", point3.X, point3.Y, circle.ContainsPoint(point3) ? "належить" : "не належить");

            Console.Write("Введіть нове значення радіусу кола: ");
            int NewRadius = int.Parse(Console.ReadLine());
            circle.SetRadius(NewRadius);
            Console.WriteLine("Радіус кола змінено на {0}", circle.Radius);
            Console.WriteLine("Центр кола: ({0}, {1})", center.X, center.Y);
            Console.WriteLine("Радіус кола: {0}", circle.Radius);

            Console.WriteLine("Введіть значення х точки");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення у для точки");
            int l = int.Parse(Console.ReadLine());
            Point point4 = new Point(k, l);
            Console.WriteLine("Точка ({0}, {1})  {2} колу ", point4.X, point4.Y, circle.ContainsPoint(point4) ? "належить" : "не належить");

            Console.ReadLine();
        }
        catch(System.FormatException)
        {
            Console.WriteLine("Введіть число!");
        }
        catch (System.OverflowException)
        {
            Console.WriteLine("Введіть число!");
        }
    }
}




