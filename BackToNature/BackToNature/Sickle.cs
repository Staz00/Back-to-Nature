using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToNature
{
    public class Sickle : Tool
    {
        public Sickle(string _name, int _durability, int _upgradeLeve1)
        {
            base.name = _name;
            base.durability = _durability;
            base.upgradeLevel = _upgradeLeve1;
        }

        protected override void Discard()
        {
        }

        protected override void Sell()
        {
            
        }

        protected override void Use()
        {
            durability--;

            if(durability <= 0)
            {
                //tool is broken
            }
        }

    }
}
