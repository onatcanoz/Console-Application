using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarTahmin.Classes;

namespace ZarTahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            ZarService zarService = new ZarService();
            zarService.Atis();
        }
    }
}
