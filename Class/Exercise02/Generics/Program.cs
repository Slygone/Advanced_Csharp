using Generics;
using Generics.Domain;
using Generics.Domain.Helpers;
using Generics.Domain.Models;

NonGenericListHelper nonGenericListHelper = new NonGenericListHelper();
List<string> strings = new List<string>() { "Hello", "Bye", "Welcome" };
List<int> ints  = new List<int> { 1, 2, 3 };

nonGenericListHelper.PrintListOfStrings(strings);
nonGenericListHelper.PrintListOfInts(ints);
nonGenericListHelper.PrintInfoForStringsList(strings);
nonGenericListHelper.PrintInfoForIntsList(ints);

GenericListHelper<string>.PrintList(strings);
GenericListHelper<string>.PrintListInfo(strings);
GenericListHelper<int>.PrintList(ints);

GenericDb<Product> productsDb = new GenericDb<Product>();
GenericDb<Order> ordersDb = new GenericDb<Order>();


productsDb.Add(new Product { Id = 1, Title = "Pizza", Description = "Pepperoni" });
productsDb.Add(new Product { Id = 2, Title = "Coca Cola", Description = "Pop" });

Console.WriteLine("============================");
productsDb.PrintAll();
productsDb.RemoveById(1);
productsDb.PrintAll();

ordersDb.Add(new Order { Id = 1, OrderBy = "Nikola", Address = "Street 245b" });
ordersDb.PrintAll();

