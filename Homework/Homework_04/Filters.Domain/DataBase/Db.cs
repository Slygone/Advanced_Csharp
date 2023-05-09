using Filters.Domain.Models;

namespace Filters.Domain.DataBase
{
    public static class Db
    {
        public static List<Person> People { get; set; }
        public static List<Dog> Dogs { get; set; }
        static Db()
        {
            People = new List<Person>();
            Dogs = new List<Dog>();
        }
    }
}
