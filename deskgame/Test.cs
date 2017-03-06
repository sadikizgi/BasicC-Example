using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPL15042016
{
    class Test
    {
        static void Main(string[] args)
        {
           // Kart k1 = new Kart("Karo", "4");
            //Console.WriteLine(k1);
            Deste deste = new Deste();
            deste.Karistir();
            deste.Goster();
            Console.WriteLine("Kart cekme");
            Console.WriteLine(deste.KartCek());
            Console.WriteLine(deste.KartCek());

        }
    }
}
