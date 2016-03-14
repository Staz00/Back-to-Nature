using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToNature
{
    public class Player
    {
        private string name;
        public enum Gender { Male, Female }

        private Gender playerGender;

        public string Name
        {
            get { return name; }
        }

        public void SetName(string _name)
        {
            name = _name;
        }
        
        public void SetGender(string input)
        {
            switch(input)
            {
                case "1":
                    playerGender = Gender.Male;
                    break;

                case "2":
                    playerGender = Gender.Female;
                    break;

                default:
                    playerGender = Gender.Male;
                    break;
            }
        }

        public Gender getGender()
        {
            return playerGender;
        }
    }
}
