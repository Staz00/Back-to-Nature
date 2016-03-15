using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToNature
{
    public abstract class Tool
    {
        public string name;
        protected int durability;
        protected int staminaUsage;
        protected int upgradeLevel;
        protected float toolLevel;
        protected int durabilityCost;

        public abstract void Use();
        public abstract void Repair();

        public abstract void Upgrade();

        protected abstract void Sell();

    }
}
