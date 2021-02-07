using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Uygulamaları
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                           ***PALİNDROM***\n");
            Console.WriteLine("Eğer bir kelimenin düz okunuşu ile ters okunuşu birbirinin aynı ise palindromdur, değilse palindrom değildir.\n");
            Console.Write("Kontrol etmek istediğiniz kelimeyi giriniz(Çıkış için ('q'): ");
            string giris = Console.ReadLine();

            bool sonuc;
            while (giris != "q")
            {
                if (giris.Length >= 2)
                {
                    sonuc = palindromkelime(giris);
                    if (sonuc == true)
                        Console.WriteLine(giris + " palindromdur.");
                    else
                        Console.WriteLine(giris + " palindrom değil.");
                    Console.Write("Kontrol etmek istediğiniz kelimeyi giriniz(Çıkış için ('q'): ");
                    
                }
                else
                {
                    Console.WriteLine("En az 2 kelime girin");
                }
                giris = Console.ReadLine();
            }



        }

        static bool palindromkelime(string kelime)
        {
            bool sonuc = true;
            for (int i = 0; i <= kelime.Length / 2; i++)
            {
                if (kelime[i] != kelime[kelime.Length - 1 - i])
                {
                    sonuc = false;
                    break;
                }
            }
            return sonuc;

        }
    }
}
