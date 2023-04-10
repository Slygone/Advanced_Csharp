using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.Domian.Models;

namespace Task01.Domian
{
    public class Db<T> where T : Shape
    {
        public List <Shape> shapes { get; set; }


        public void PrintArea(T shape)
        {
            Console.WriteLine(shape.GetArea());
        }
        public void PrintPerimeters(T shape)
        {
            Console.WriteLine(shape.GetPerimeter());
        }
    }
}
