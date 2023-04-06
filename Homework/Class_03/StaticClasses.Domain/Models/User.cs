using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }
        public User()
        {
            Id = new Random().Next(1,100000);
            Orders = new List<Order>();
        }

        public User (int id, string userName, string address)
        {
            Id = id;
            UserName = userName;
            Address = address;
            Orders = new List<Order>();
        }

        public void PrintOrders()
        {
            int orderNumber = 1;
            foreach(Order order in Orders) 
            {
                Console.WriteLine($"{orderNumber}) {order.Title}");
                orderNumber++;
            }
        }
    }
}
