using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc, sayi;
            Console.WriteLine("***                                   Faktoriyel***");


            Console.Write("Pozitif bir tamsayı giriniz(Çıkış için ('q'): ");
            string q = Console.ReadLine();

            while (q != "q")
            {

                sayi = Convert.ToInt32(q);
                if (sayi == 0 || sayi > 0)
                {
                      sonuc = 1;
                    for (int i = 1; i <= sayi; i++)
                    {
                        sonuc *= i;
                    }
                    Console.WriteLine("Sonuç: " + sonuc);
                    Console.Write("Pozitif bir tamsayı giriniz(Çıkış için ('q'): ");

                }
                else               
                {
                    Console.Write("Pozitif bir tamsayı giriniz(Çıkış için ('q'): ");
                }
                
                q = Console.ReadLine();
            }


            //Console.ReadLine();
        }
    }
}
