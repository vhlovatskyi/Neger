using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Boy : Person
    {
        public override bool CanReceiveGift(Elf elf) => elf.IsKind;
    }
}
