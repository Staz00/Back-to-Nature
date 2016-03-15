using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToNature
{
    public class FieldSpace
    {
        public enum ContentType { GRASS, WOOD, UNPLOWED, UNWATERED, STONE, EMPTY, CROPS}

        Field[,] field = new Field[3, 3];
        Random random = new Random();

        public FieldSpace()
        {
            for(int x = 0; x < field.GetLength(0); x++)
            {
                for(int y = 0; y < field.GetLength(1); y++)
                {
                    
                    int rng = random.Next(0, 5);

                    if (rng == 0)
                    {
                        field[x, y].contentType = ContentType.GRASS;
                        field[x, y].content = '*';
                    }

                    else if (rng == 1)
                    {
                        field[x, y].contentType = ContentType.WOOD;
                        field[x, y].content = '=';
                    }

                       
                    else if(rng == 2)
                    {
                        field[x, y].contentType = ContentType.UNPLOWED;
                        field[x, y].content = '#';
                    }
                        
                    else if (rng == 3)
                    {
                        field[x, y].contentType = ContentType.UNWATERED;
                        field[x, y].content = '&';
                    }
                        
                    else if (rng == 4)
                    {
                        field[x, y].contentType = ContentType.STONE;
                        field[x, y].content = '0';
                    }
                    else if (rng == 5)
                    {
                        field[x, y].contentType = ContentType.EMPTY;
                        field[x, y].content = 'X';
                    }

                    field[x, y].hasCrop = false;
                }
            }
        }

        private void SetFieldSpace(int x, int y)
        {
            field[x, y].content = 'X';
            field[x, y].contentType = ContentType.EMPTY;
        }

        private bool CheckSpaceWithEquipped(Player.EquippedTool? tool, ContentType type, int x, int y)
        {
            if (tool.Value == Player.EquippedTool.Sickle && type == ContentType.GRASS)
            {
                SetFieldSpace(x, y);

                return true;
            }
            else if (tool.Value== Player.EquippedTool.Axe && type == ContentType.WOOD)
            {
                SetFieldSpace(x, y);
                return true;
            }
            else if (tool.Value == Player.EquippedTool.Pickaxe && type == ContentType.STONE)
            {
                SetFieldSpace(x, y);

                return true;
            }
            else if (tool.Value == Player.EquippedTool.Hoe && type == ContentType.UNPLOWED)
            {
                SetFieldSpace(x, y);

                return true;
            }
            else if (tool.Value == Player.EquippedTool.WateringCan && type == ContentType.UNWATERED)
            {
                SetFieldSpace(x, y);

                return true;
            }
            else if (tool.Value == Player.EquippedTool.Crops && type == ContentType.EMPTY)
            {
                field[x, y].content = 'O';
                field[x, y].contentType = ContentType.CROPS;
                field[x, y].hasCrop = true;
                return true;
            }
            else
            {
                Console.WriteLine("Please select the appropriate tool for the space you selected");
                Console.ReadLine();
                return false;
            }

            
        }

        public bool SelectSpace(int x, int y, Player.EquippedTool? tool)
        {
            int xPos = x - 1;
            int yPos = y - 1;

            if (field[xPos, yPos].hasCrop)
            {
                Console.WriteLine("Space is already occupied");
                return false;
            }

            if(CheckSpaceWithEquipped(tool, field[xPos, yPos].contentType, xPos, yPos))
            {
                return true;
            }

            return false;

        }

        public void PrintMatrix()
        {
            Console.WriteLine("\n* means it has grass\n= means it has wood\n# means it is unplowed\n& means it is unwatered\n0 means it has stone");

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write("{0,3}", "|" + field[i, j].content + "|");
                }
                Console.WriteLine();
            }
        }


        public struct Field
        {
            public char content;
            public int daysBeforeHarvest;
            public bool hasCrop;
            public ContentType contentType;
        }
    }
}
