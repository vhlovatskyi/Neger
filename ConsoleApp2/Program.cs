using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            List<Gift> gifts = new List<Gift>
            {
                new Gift("лялька"),
                new Gift("машинка"),
                new Gift("лєго")
            };

            List<Person> recipients = new List<Person>
            {
                new Girl(),
                new Boy()
            };

            List<Elf> elves = new List<Elf>
            {
                new KindElf(),
                new EvilElf()
            };

            foreach (var elf in elves)
            {
                Console.WriteLine($"{elf.GetType().Name}:");

                foreach (var recipient in recipients)
                {
                    foreach (var gift in gifts)
                    {
                        elf.GiveGift(recipient, gift);
                    }
                }
            }
        }
    }
}