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

            Elf kindElf = new KindElf();
            Elf evilElf = new EvilElf();

            Console.WriteLine("Добрий ельф:");
            foreach (var recipient in recipients)
            {
                foreach (var gift in gifts)
                {
                    kindElf.GiveGift(recipient, gift);
                }
            }

            Console.WriteLine("\nЗлий ельф:");
            foreach (var recipient in recipients)
            {
                foreach (var gift in gifts)
                {
                    evilElf.GiveGift(recipient, gift);
                }
            }
        }
    }
}