using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToNature
{
    class Program
    {

        static void Main(string[] args)
        {
            GameLoop loop = new GameLoop(false);

            while (!loop.GameOver) { }
        }
    }
}
