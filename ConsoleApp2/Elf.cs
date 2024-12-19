using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Elf : IGiveGift
    {
        public abstract bool IsKind { get; }

        public void GiveGift(Person recipient, Gift gift)
        {
            if (recipient.CanReceiveGift(this))
            {
                recipient.ReceiveGift(gift);
                Console.WriteLine($"{GetType().Name} подарував {gift.Type} для {recipient.GetType().Name}.");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} не може подарувати подарунок {recipient.GetType().Name}.");
            }
        }
    }
}
