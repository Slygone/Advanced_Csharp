using SEDC.TryBeingFit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Domain.DbInterfaces
{
    public interface IDatabase<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetByID(int id);
        void Add(T entity);
        void RemoveById (int id);
        void Update(T entity);  
    }
}
