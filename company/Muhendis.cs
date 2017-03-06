using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP05042016
{
    class Muhendis
    {
        int kimlikNo;
        string isim;
        float saatUCreti;
        int calismaSaati;

        public float SaatUCreti
        {
            get
            {
                return saatUCreti;
            }
            set
            {
                if (value < 10 || value > 100)
                    saatUCreti = 30;
                else
                    saatUCreti = value;
            }
        }

        public int CalismaSaati
        {
            get
            {
                return calismaSaati;
            }

            set
            {
                if (value < 20 || value > 40)
                    calismaSaati = 30;
                else
                    calismaSaati = value;
            }
        }
        public Muhendis(int no, string isim, 
                          float ucret, int saat)
        {
            kimlikNo = no;
            this.isim = isim;
            SaatUCreti = ucret;
            CalismaSaati = saat;

        }

        public float MaasHesapla()
        {
            return saatUCreti * calismaSaati;
        }

        public  string ToString()
        {
            return "kimlik no..:"+kimlikNo + "  " 
                + "isim..:"+ isim +
                   " Görevi..:Muhendis  "+ " maaşı " + MaasHesapla();
        }

    }
}
