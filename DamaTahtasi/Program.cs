using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamaTahtasi
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                //for (int i = 0; i < 4; i++)
                //{
                //    for (int j = 0; j < 4; j++)
                //    {
                //        Console.Write(" *");
                //    }
                //    Console.WriteLine();
                //}
                
            }
            Console.ReadLine();
        }
    }
}
