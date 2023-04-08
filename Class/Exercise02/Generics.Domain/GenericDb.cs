using Generics.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Domain
{
    public class GenericDb<T> where T : BaseEntity
    {
        private List<T> items;

        public GenericDb()
        {
            items = new List<T>();
        }

        public List<T> GetAll()
        {
            return items;
        }

        public void PrintAll()
        {
            foreach(T item in items) 
            {
            Console.WriteLine(item.GetInfo());
            }
        }

        public T GetById(int id)
        {
            return items.FirstOrDefault(x => x.Id == id);
        }
        public void Add(T item)
        {
            items.Add(item);
            Console.WriteLine($"The item was added!");
        }

        public void RemoveById(int id)
        {
            T itemToRemove = items.FirstOrDefault(x => x.Id == id);
            if(itemToRemove == null)
            {
                Console.WriteLine($"There is no member with Id {id} in the db.");
                return;
            }
            items.Remove(itemToRemove);
            Console.WriteLine($"The item was removed!");
        }
    }
}
