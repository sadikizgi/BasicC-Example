using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP05042016
{
    class Mudur
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
                if (value < 40 || value > 200)
                    saatUCreti = 80;
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
                if (value < 10 || value > 30)
                    calismaSaati = 20;
                else
                    calismaSaati = value;
            }
        }
        public Mudur(int no, string isim,
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

        public string ToString()
        {
            return "kimlik no..:" + kimlikNo + "  "
                + "isim..:" + isim +
                   " Görevi..:Mudur  "+  " maaşı " + MaasHesapla();
        }

    }
}
