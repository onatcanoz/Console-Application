using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yas_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("***Yaş Hesaplama***");
            //Console.WriteLine("Doğum Tarihinizi yazınız.(gg.aa.yy): ");
            //DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());

            //DateTime simdikiTarih = DateTime.Now;
            //int yas = simdikiTarih.Year - dogumTarihi.Year;

            //Console.WriteLine("Doğum Tarihi :" + yas);
            //Console.ReadLine();

            Console.WriteLine("***Yaş Hesaplama***");
            Console.WriteLine("Doğum Tarihinizi yazınız.(gg.aa.yy): ");
            string dogumTarihigiris = Console.ReadLine();
            DateTime dogumTarihi = DateTime.Parse(dogumTarihigiris);
            int yas = YasHesapla(dogumTarihi);
            Console.WriteLine("Yaşınız: " + yas);

            Console.ReadLine();
        }

        static int YasHesapla(DateTime dogumTarihi)
        {
            int yas;
            DateTime bugun = DateTime.Now.Date;
            //1.Yöntem:
            //yas = bugun.Year - dogumTarihi.Year;
            //2. Yöntem:
            double toplamSaat = (bugun - dogumTarihi).TotalHours;
            yas = Convert.ToInt32(Math.Floor(toplamSaat))/(365 * 24 +6);
                return yas  ;
             
        }
    }
}
