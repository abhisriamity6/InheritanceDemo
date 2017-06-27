using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class TwoDShape
    {
        double pri_height;
        double pri_width;

        // implementing property
        public double height
        {
            get
            {
                return pri_height;
            }
            set
            {
                pri_height = value;
            }
        }

        public double width
        {
            get
            {
                return pri_width;
            }
            set
            {
                pri_width = value;
            }
        }

        public void ShowDim()
        {
            Console.WriteLine("Width and height are " +
            width + " and " + height);
        }

    }
    class Triangle : TwoDShape
    {
        string Style;

        public string StyleValue
        {
            get
            {
                return Style;
            }
            set
            {
                Style = value;
            }

        }
      public double Area()
        {
            return width * height / 2;
        }
        // Display a triangle's style.
        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + Style);
        }

    }

    class Demo
    {

        static void Main(string[] args)
        {

            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle();
            t1.width = 4.0;
            t1.height = 4.0;
            t1.StyleValue = "isosceles";
            t2.width = 8.0;
            t2.height = 12.0;
            t2.StyleValue = "right";
            Console.WriteLine("Info for t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area is " + t1.Area());
            Console.WriteLine();
            Console.WriteLine("Info for t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Area is " + t2.Area());

            Console.Read();



        }
    }

}
