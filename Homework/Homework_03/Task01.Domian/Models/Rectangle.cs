using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Domian.Models
{
    public class Rectangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Rectangle() { }
        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override string? ToString()
        {
            return "I am a rectangle";
        }

        public override double GetArea()
        {
            return SideA * SideB;
        }
        public override double GetPerimeter()
        {
            return (2 * SideA) + (2 * SideB);
        }
    }
}
