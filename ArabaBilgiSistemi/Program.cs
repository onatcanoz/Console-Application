using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaBilgiSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Arabalar araba1 = new Arabalar()
            {
                Id = 1,
                Marka = "Ww",
                Model = "Golf",
                MotorHacmi = 1.400,
                BeygirGucu = 122,
                MaxHız = 240,
                SıfırdanYuzeHizlanma = 10.2,
                KapiSayisi = 4,
                Cekis = ArabaCekisTuruEnum.Önden_çekiş,
                Agırlık = 1.295,
                ArabaTurleri = ArabaTurleriEnum.binek,
            };
            Console.WriteLine("                                          ***ARABA BİLGİLERİ***");
            Console.WriteLine("ARABA: 1");
            Console.WriteLine("Id: " + araba1.Id);
            Console.WriteLine("Marka: " + araba1.Marka);
            Console.WriteLine("Model: " + araba1.Model);
            Console.WriteLine("Motor: "+araba1.MotorHacmi);
            Console.WriteLine("Beygir: "+araba1.BeygirGucu);
            Console.WriteLine("MaxHız: "+araba1.MaxHız);
            Console.WriteLine("0-100: "+araba1.SıfırdanYuzeHizlanma);
            Console.WriteLine("Çekiş: "+araba1.Cekis+ " (" + (int)araba1.Cekis + ") ");
            Console.WriteLine("Ağırlık: "+ araba1.Agırlık);
            Console.WriteLine("Kapı Sayısı: "+ araba1.KapiSayisi);
            Console.WriteLine("Araba Türü: "+ araba1.ArabaTurleri+ " (" + (int)araba1.ArabaTurleri + ") ");
            Console.WriteLine("************************************************************************************************************************");


            Arabalar araba2 = new Arabalar();
            araba2.Id = 2;
            araba2.Marka = "Seat";
            araba2.Model = "Leon";
            araba2.MotorHacmi = 1.400;
            araba2.BeygirGucu = 150;
            araba2.MaxHız = 240;
            araba2.SıfırdanYuzeHizlanma = 9.2;
            araba2.Cekis = ArabaCekisTuruEnum.Önden_çekiş;
            araba2.Agırlık = 1.231;
            araba2.KapiSayisi = 4;
            araba2.ArabaTurleri = ArabaTurleriEnum.binek;

            Console.WriteLine("ARABA: 2");
            Console.WriteLine("Id: " + araba2.Id);
            Console.WriteLine("Marka: " + araba2.Marka);
            Console.WriteLine("Model: " + araba2.Model);
            Console.WriteLine("Motor: " + araba2.MotorHacmi);
            Console.WriteLine("Beygir: " + araba2.BeygirGucu);
            Console.WriteLine("MaxHız: " + araba2.MaxHız);
            Console.WriteLine("0-100: " + araba2.SıfırdanYuzeHizlanma);
            Console.WriteLine("Çekiş: " + araba2.Cekis + " (" + (int)araba2.Cekis + ") ");
            Console.WriteLine("Ağırlık: " + araba2.Agırlık);
            Console.WriteLine("Kapı Sayısı: " + araba2.KapiSayisi);
            Console.WriteLine("Araba Türü: " + araba2.ArabaTurleri + " (" + (int)araba2.ArabaTurleri + ") ");
            Console.WriteLine("************************************************************************************************************************");

            Arabalar[] arabalar = new Arabalar[2];

            arabalar[0] = araba1;
            arabalar[1] = araba2;

            for (int i = 0; i < arabalar.Length; i++)
            {
                Console.WriteLine("Id: "+arabalar[i].Id+"\n"+ "Marka: "+arabalar[i].Marka+ "\n" + "Model: "+ arabalar[i].Model+ "\n" + "Motor: "+ arabalar[i].MotorHacmi+"\n" + 
                    "Beygir: "+arabalar[i].BeygirGucu+ "\n" + "MaxHız: "+arabalar[i].MaxHız+ "\n" + "0-100: "+arabalar[i].SıfırdanYuzeHizlanma+ "\n" + "Çekiş: "+arabalar[i].Cekis+ "\n" +
                    "Ağırlık: "+arabalar[i].Agırlık+ "\n" + "Kapı Sayısı: "+arabalar[i].KapiSayisi+ "\n" + "Araba Türü: " +arabalar[i].ArabaTurleri);
            }


            Console.ReadLine();

        }
    }
}
