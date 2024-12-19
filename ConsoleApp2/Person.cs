using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Person
    {
        public abstract bool CanReceiveGift(Elf elf);

        public void ReceiveGift(Gift gift)
        {
            Console.WriteLine($"{GetType().Name} отримав подарунок: {gift.Type}.");
        }
    }
}
