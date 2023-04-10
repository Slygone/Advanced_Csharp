using Help.Domian.Interfaces;
using Help.Domian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help.Domian
{
    public class ReadsHouse : DataRepository<House>
    {
        public int Create(House entity)
        {     
            string filePath = $@"C:\temp\{entity.PrimaryKey}.txt";
            File.WriteAllText(filePath, entity.ToString()) ;
            return entity.PrimaryKey;
        }

        public int CreateAll(List<House> entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int primaryKey)
        {
            throw new NotImplementedException();
        }

        public House Read(int primaryKey)
        {
            throw new NotImplementedException();
        }

        public bool Update(House entity)
        {
            throw new NotImplementedException();
        }
    }
}
