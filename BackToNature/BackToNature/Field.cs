using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToNature
{
    public class Field
    {
        char[,] field = new char[3, 3];

        public Field()
        {
            for(int x = 0; x < field.GetLength(0); x++)
            {
                for(int y = 0; y < field.GetLength(1); y++)
                {
                    field[x, y] = 'x';
                }
            }
        }

        public char[,] returnField()
        {
            return field;
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write("{0,3}", field[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
