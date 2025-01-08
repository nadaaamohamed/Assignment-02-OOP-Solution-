using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_OOP
{
    internal struct Rectangle
    {

        #region Attributes
        private double width;
        private double height;
        #endregion

        #region Constructor
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        #endregion

        #region Propreites
        public double Width
        {
            get { return width; }
            set {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Please enter a valid width");
                }
            }
            
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Please enter a valid height");
                }
            }
        }

        public double Area
        {
            get { return width * height; }
        }



        #endregion

        #region Methods
        public override string ToString()
        {
            return $"The width of the rectangle is {width} and the height is {height} and the area is {Area}";
        } 
        #endregion
    }
}
