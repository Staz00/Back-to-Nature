using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToNature
{
    public class Sickle : Tool
    {
        public Sickle()
        {
            base.name = "Sickle";
            base.durability = 5;
            base.durabilityCost = 5;
            base.staminaUsage = 5;
        }

        public int getStaminaUsage()
        {
            return staminaUsage;
        }

        protected override void Sell()
        {
            throw new NotImplementedException();
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

        public override void Upgrade()
        {
            throw new NotImplementedException();
        }
    }
}
