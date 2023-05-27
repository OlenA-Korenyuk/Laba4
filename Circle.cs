using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Circle
    {
        private Point center;
        private double radius;

        public Circle(Point center, double radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public void SetRadius(double radius)
        {
            if (radius > 0)
            {
                this.radius = radius;
            }
            else
            {
                Console.WriteLine("Радіус не може бути від'ємним");
            }

        }

        public bool ContainsPoint(Point point)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - center.X, 2) + Math.Pow(point.Y - center.Y, 2));
            return distance <= radius;
        }

        public double Radius
        {
            get { return radius; }
        }
    }

