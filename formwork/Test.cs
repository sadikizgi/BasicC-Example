using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPL22042016
{
    class Test
    {
        static void Main(string[] args)
        {
            MaasliCalisan m1 = new MaasliCalisan("Selahattin", "AKKAS", 1, 500);
            //Console.WriteLine(m1.ToString());
            //Calisan c1= m1;
            //Console.WriteLine(c1);

            MaasliCalisan m2 = new MaasliCalisan("Merve","OZDES",2,499);

            SaatlikCalisan s1 = new SaatlikCalisan("Erdi","KAYA",3,30,30);
            SaatlikCalisan s2 = new SaatlikCalisan("Furkan", "URAL", 4, 35, 45);

            Calisan[] calisanlar=new Calisan[4];
            calisanlar[0] = m1;
            calisanlar[1] = m2;
            calisanlar[2] = s1;
            calisanlar[3] = s2;

            for (int i = 0; i < calisanlar.Length; i++)
            {
                Console.WriteLine(calisanlar[i]);
                Console.WriteLine(calisanlar[i].Kazanc());
            }
            if (m1.Karsilastir(m2)==1)
                Console.WriteLine("m1 daha fazla kazaniyor");
        }
    }
}
