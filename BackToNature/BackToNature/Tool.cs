using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToNature
{
    public abstract class Tool
    {
        protected string name;
        protected int durability;
        protected int staminaUsage;
        protected int upgradeLevel;
        protected float toolLevel;

        protected abstract void Use();

        protected abstract void Sell();

    }
}
