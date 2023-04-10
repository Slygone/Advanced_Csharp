using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Domian.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle() { }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override string? ToString()
        {
            return "I am a circle";
        }
        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
        public override double GetPerimeter()
        {
            return 2 * Radius * Math.PI;
        }
    }
}
