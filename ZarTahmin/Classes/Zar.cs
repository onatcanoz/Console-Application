using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarTahmin.Classes
{
    class Zar
    {
        int _sayi;
        Random rasgele = new Random();
        public void ZarAt()
        {
            int sayi = rasgele.Next(1, 7);
            _sayi = sayi;
        }
        public int ZarSayisiniGetir()
        {
            return _sayi;
        }
    }
}
