using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help.Domian.Interfaces
{
    public interface DataRepository<T>
    {
        public int Create(T entity);
        public int CreateAll(List <T> entity);
        public T Read(int primaryKey);
        public bool Update(T entity);
        public bool Delete(int primaryKey);
    }
}
