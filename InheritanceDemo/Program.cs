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

        }
    }

}
