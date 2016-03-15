using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToNature
{
    public class Player
    {
        public enum Gender { Male, Female }

        private string name;
        public string Name
        {
            get { return name; }
        }

        private float stamina = 100;

        public float Stamina
        {
            get { return stamina; }
            set { stamina = value; }
        }
        private double money = 500;
        private Gender playerGender;

        private List<Item> items = new List<Item>();
        private List<Tool> tools = new List<Tool>();

        public Player()
        {
            AddTool(new Sickle(), null);
            AddTool(new Hoe(), null);
            AddTool(new PickAxe(), null);
            AddTool(new Axe(), null);

        }


        public void AddItem(string name, int price)
        {
            items.Add(new Item(name, price));
        }

        public void SellItem(Item item, int? discardAmount)
        {
            int price = 0;

            if(discardAmount== null)
            {
                foreach(var i in items)
                {
                    price += i.price;
                    items.Remove(i);
                }
            }
            else
            {
                foreach (Item i in items)
                {
                    if (i.name == item.name)
                    {
                        for (int amount = 0; amount < discardAmount; amount++)
                        {
                            price += i.price;
                            items.Remove(i);
                        }
                        break;
                    }
                }
            }

            money += price;
        }

        public void DiscardItem(int index)
        {
            items.RemoveAt(index - 1);
        }


        public void DiscardItem(Item item, int discardAmount)
        {
            foreach(var i in items)
            {
                if(i.name == item.name)
                {
                    for(int amount = 0; amount < discardAmount; amount++)
                    {
                        items.Remove(i);
                    }

                    break;
                }
            }
        }

        public void AddTool(int? choice)
        {
            switch (choice)
            {
                case 1:
                    tools.Add(new Sickle());
                    break;
                case 2:
                    tools.Add(new Hoe());
                    break;
                case 3:
                    tools.Add(new PickAxe());
                    break;
                case 4:
                    tools.Add(new Axe());
                    break;
                default:
                    break;
            }
        }


        public void AddTool(Tool tool, int? choice)
        {
            if(choice == null)
                tools.Add(tool);

            else
            {
                switch(choice)
                {
                    case 1:
                        tools.Add(new Sickle());
                        break;
                    case 2:
                        tools.Add(new Hoe());
                        break;
                    case 3: 
                        tools.Add(new PickAxe());
                        break;
                    case 4: 
                        tools.Add(new Axe());
                        break;
                    default:
                        break;
                }
            }
        }

        public void DiscardTool(int index)
        {
            tools.RemoveAt(index - 1);
        }

        public void DisplayTools()
        {
            int count = 1;

            foreach(var t in tools)
            {
                Console.WriteLine(count + ".) " + t.name);
                count++;
            }
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


        public void SetName(string _name)
        {
            name = _name;
        }
        
        public double getMoney()
        {
            return money;
        }
    }
}
