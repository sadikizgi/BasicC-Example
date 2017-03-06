using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP12042016
{
    class Dikdortgen
    {
        private int uzunKenar;
        private int kisaKenar;

        public int UzunKenar
        {
            get
            {
                return uzunKenar;
            }

            set
            {
                if (value < 1)
                    uzunKenar = 1;
                else
                    uzunKenar = value;
            }
        }

        public int KisaKenar
        {
            get
            {
                return kisaKenar;
            }

            set
            {
                if (value < 1)
                    kisaKenar = 1;
                else
                    kisaKenar = value;
            }
        }

        public Dikdortgen(int k1, int k2)
        {
            KisaKenar = k1;
            UzunKenar = k2;
        }

        public int alan()
        {
            return kisaKenar * uzunKenar;
        }
        public int cevre()
        {
            return 2 * (kisaKenar + uzunKenar);
        }
        public string ToString()
        {
            return "uzunKenar..:" + uzunKenar +
                "kisa kenar...:" + kisaKenar +
                "alanı...:" + alan() +
                "cevre..:" + cevre();
        }
        public int CompareTo(Dikdortgen dortgen)
        {
            if (this.alan() > dortgen.alan())
                return 1;
            else if (this.alan() < dortgen.alan())
                return -1;
            else
                return 0;
        }





    }
}
