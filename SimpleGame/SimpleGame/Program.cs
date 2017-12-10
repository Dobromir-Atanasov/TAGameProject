using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Some testing. All must be moved to method Initialize Console.
            {
                System.Console.SetWindowSize(128, 70);
                System.Console.Title = "SimpleGame";
                Console.BufferHeight = 70;

                for (int i = 0; i < 70; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
