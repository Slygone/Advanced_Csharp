using Help.Domian.Interfaces;

namespace Help.Domian.Models
{
    public class ReadsCar : DataRepository<Car>
    {
        public int Create(Car entity)
        {
            return entity.PrimaryKey;
        }

        public int CreateAll(List<Car> entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int primaryKey)
        {
            throw new NotImplementedException();
        }

        public Car Read(int primaryKey)
        {
            throw new NotImplementedException();
        }

        public bool Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
