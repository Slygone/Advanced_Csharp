using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.Domian.Models;

namespace Task01.Domian.Utils
{
    public static class Helpers<T> where T : Shape
    {
        public static void CheckType(T shape)
        {
            Console.WriteLine(shape.ToString());
        }
    }
}
