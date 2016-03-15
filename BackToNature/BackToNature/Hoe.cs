using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToNature
{
    public class Hoe : Tool
    {
        public Hoe()
        {
            base.name = "Hoe";
            base.durability = 5;
            base.durabilityCost = 5;
            base.staminaUsage = 10;
        }

        public override void Use()
        {
            durability -= durabilityCost;

            Console.WriteLine(name + "'s durability is now " + durability);
        }

        public override void Repair()
        {
            durability++;
        }

        protected override void Sell()
        {
            throw new NotImplementedException();
        }

        public override void Upgrade()
        {
            throw new NotImplementedException();
        }
    }
}
