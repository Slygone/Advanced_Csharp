using StaticClasses.Domain.Enums;
using StaticClasses.Domain.Helpers;

namespace StaticClasses.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public OrderStatus Status { get; set; }
        
        //default constructor
        public Order()
        {
            //default values given
            Id = new Random().Next(1, 100000);
            Status = OrderStatus.Created;
        }

        public Order (int id, string title, string description, OrderStatus status)
        {
            //TODO validations
            Id = id;
            Title = title;
            Description = description;
            Status = status;
        }

        public void Print()
        {
            Console.WriteLine($"{TextHelper.ToCapitalFirstLetter(Title)} {Description} {Status.ToString()} ");
        }
    }
}
