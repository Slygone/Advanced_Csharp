using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help.Domian.Models
{
    public class House
    {
        public int PrimaryKey { get; set; }
        public string Name { get; set; }
        public int YardArea { get; set; }

        public House() { }
        public House(int primaryKey, string name, int yardArea)
        {
            PrimaryKey = primaryKey;
            Name = name;
            YardArea = yardArea;
        }

        public override string? ToString()
        {
            return $"Name: {Name},\nPrimaryKey {PrimaryKey},\nYardArea {YardArea}";
        }
    }
}
