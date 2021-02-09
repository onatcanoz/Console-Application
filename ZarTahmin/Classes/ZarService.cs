using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarTahmin.Classes
{
    class ZarService
    {
        public void Atis()
        {
            Zar zar = new Zar();

            Console.WriteLine("Devam için 'Enter'a çıkmak için 'q' ya basın: ");
            string input = Console.ReadLine();


            while (input != "q")

            {
                Console.Write("1.Zar Tahmininiz: ");
                int Tahmin1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Zar Tahmininiz: ");
                int Tahmin2 = Convert.ToInt32(Console.ReadLine());
                zar.ZarAt();
                int zar1 = zar.ZarSayisiniGetir();

                zar.ZarAt();
                int zar2 = zar.ZarSayisiniGetir();

                if (Tahmin1 == zar1 && Tahmin2 == zar2)
                {
                    Console.WriteLine("2 sayıyıda bildin----10TL kazandınız!!");
                }
                else if (Tahmin1 == zar1 && Tahmin2 != zar2 || Tahmin1 != zar1 && Tahmin2 == zar2)
                {
                    Console.WriteLine("2 sayıdan 1'ini bildin-----1TL kazandınız!!");
                }
                else
                {
                    Console.WriteLine("2'sinide bilemedin-----1TL borçlusun!!");
                }
                Console.WriteLine("Zar 1: " + zar1 + "\nZar 2: " + zar2);
                input = Console.ReadLine();
            }
        }
    }
}
