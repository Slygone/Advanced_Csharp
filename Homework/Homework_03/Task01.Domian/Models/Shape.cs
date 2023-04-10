using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Domian.Models
{
    public class Shape
    {
        public int Id { get; set; }
        public Shape () { }
        public Shape (int id) 
        {
            Id = id;
        }

        public virtual double GetArea()
        {
            return 2.00;
        }
        public virtual double GetPerimeter()
        {
            return 1.00;
        }
    }
}
