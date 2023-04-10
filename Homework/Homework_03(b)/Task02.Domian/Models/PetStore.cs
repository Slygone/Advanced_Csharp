using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Domian.Models
{
    public class PetStore<T> where T : Pet
    {
        public List<T> pets { get; set; }
        public void PrintsPets()
        {
            foreach (T pet in pets)
            {
                pet.PrintInfo();
            }
        }

        public void BuyPet(string name)
        {
            T pet = pets.FirstOrDefault(p => p.Name == name);

            if (pet != null)
            {
                Console.WriteLine($"The pet {pet.Name} has been adopted!");
                pets.Remove(pet);
            }
            else
            {
                Console.WriteLine("No such name exists!");
            }
        }

    }
}
