using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaBilgiSistemi
{
    class Arabalar
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public byte KapiSayisi { get; set; }
        public short BeygirGucu { get; set; }
        public int MyProperty { get; set; }
        public ArabaTurleriEnum ArabaTurleri { get; set; }
        public short MaxHız { get; set; }
        public ArabaCekisTuruEnum Cekis { get; set; }
        public double SıfırdanYuzeHizlanma { get; set; }
        public double Agırlık { get; set; }
        public double MotorHacmi { get; set; }
    }
}
