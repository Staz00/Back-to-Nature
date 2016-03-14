using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToNature
{
    public class Sickle : Tool
    {
        public Sickle(string _name, int _durability, int _upgradeLeve1, int _staminaUsage, float _toolLevel)
        {
            name = _name;
            base.durability = _durability;
            base.staminaUsage = _staminaUsage;
            base.upgradeLevel = _upgradeLeve1;
            base.toolLevel = _toolLevel;
        }

        protected override void Sell()
        {
            throw new NotImplementedException();
        }

        protected override void Use()
        {
            throw new NotImplementedException();
        }
    }
}
