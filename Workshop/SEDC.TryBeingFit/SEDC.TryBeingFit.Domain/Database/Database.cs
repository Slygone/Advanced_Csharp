using SEDC.TryBeingFit.Domain.DbInterfaces;
using SEDC.TryBeingFit.Domain.Models;

namespace SEDC.TryBeingFit.Domain.Database
{
    public class Database<T> : IDatabase<T> where T : BaseEntity
    {
        private List<T> _items { get; set; }
        private int _id;

        public Database() 
        {
            _items = new List<T>();
            _id = 1;
        }
        public void Add(T entity)
        {
            entity.Id = _id++;
            _items.Add(entity);
            Console.WriteLine($"Item with id {entity.Id} added");
        }

        public List<T> GetAll()
        {
            return _items;
        }

        public T GetByID(int id)
        {
            T item  = _items.FirstOrDefault(x => x.Id == id);
            if(item == null)
            {
                throw new Exception($"Item with id {id} was not found");
            }
            return item;
        }

        public void RemoveById(int id)
        {
            T item = _items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                throw new Exception($"Item with id {id} was not found");
            }
            _items.Remove(item);
            Console.WriteLine($"Item with id {id} was removed"); 
        }
        public void Update(T entity)
        {
            T item = _items.FirstOrDefault(x => x.Id == entity.Id);
            if (item == null)
            {
                throw new Exception($"Item with id {entity.Id} was not found");
            }
            item = entity;
        }
    }
}
