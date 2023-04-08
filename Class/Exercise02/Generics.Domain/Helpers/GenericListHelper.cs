using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Domain.Helpers
{
    public static class GenericListHelper<T>
    {
        public static void PrintList(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintListInfo(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine($"The list has {items.Count} members. And they are of " +
                    $"type {items.First().GetType()}");
            }
        }
    }
}
