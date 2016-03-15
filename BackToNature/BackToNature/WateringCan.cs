using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToNature
{
    public class WateringCan : Tool
    {
        public WateringCan()
        {
            base.name = "WateringCan";
            base.durability = 5;
            base.durabilityCost = 5;
            base.staminaUsage = 10;
        }

        public override void Repair()
        {
            durability++;
        }

        public override void Upgrade()
        {
            throw new NotImplementedException();
        }

        public override void Use()
        {
            durability -= durabilityCost;

            Console.WriteLine(name + "'s durability is now " + durability);
        }

        protected override void Sell()
        {
            throw new NotImplementedException();
        }
    }
}
