using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Girl : Person
    {
        public override bool CanReceiveGift(Elf elf) => elf.IsKind;
    }
}
