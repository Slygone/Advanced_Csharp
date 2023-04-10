using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help.Domian.Models
{
    public class Car
    {
        public int PrimaryKey {  get; set; }
        public string Name { get; set; }
        public Car() { }
        public Car(int primaryKey, string name)
        {
            PrimaryKey = primaryKey;
            Name = name;
        }
        List <Car> List { get; set; }


    }
}
