using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_OOP
{
    internal struct Point
    {
        double x { get; set; }
        double y { get; set; }
        #region Constructors
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"x: {x}, y: {y}";   
        }
        public void  Createpoint ()
        {
            Console.WriteLine("x");
           x = double.Parse(Console.ReadLine());

            Console.WriteLine("y");    
            y = double.Parse(Console.ReadLine());
        }

       public double Distance(Point p1 , Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }
        #endregion
    }
}
