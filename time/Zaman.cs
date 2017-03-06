using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP08042016
{
    class Zaman
    {
        int saat;
        int dakika;
        int saniye;

        public int Saat
        {
            get
            {
                return saat;
            }

            set
            {
                if (value >= 0 && value < 24)
                    saat = value;
                else
                {
                    saat = 0;
                    Console.WriteLine("Saat 0 ile 23 arasinda olmalidir!");
                }

            }
        }

        public int Dakika
        {
            get
            {
                return dakika;
            }

            set
            {
                if (value >= 0 && value < 60)
                    dakika = value;
                else
                {
                    dakika = 0;
                    Console.WriteLine("Dakika 0 ile 59 arasindali olmalidir!");

                }
            }
        }

        public int Saniye
        {
            get
            {
                return saniye;
            }

            set
            {
                if (value >= 0 && value < 60)
                    saniye = value;
                else
                {
                    saniye = 0;
                    Console.WriteLine("Saniye 0 ile 60 arasinda olmalidir.");
                }
            }
        }

        public Zaman(int saat=0,int dakika=0, int saniye=0)
        {
            //Saat = saat;
            //Dakika = dakika;
            //Saniye = saniye;
            Ayarla(saat, dakika, saniye);
        }

        public Zaman(Zaman z):this(z.Saat,z.Dakika,z.Saniye)
        {
            //Saat = z.Saat;
            //Dakika = z.Dakika;
            //Saniye = z.Saniye;
        }

        public void Ayarla(int saat, int dakika, int saniye)
        {
            Saat = saat;
            Dakika = dakika;
            Saniye = saniye;
        }
        public string ToEvrenselString()
        {
            
            return string.Format("{0:D2}:{1:D2}:{2:D2}",Saat,Dakika,Saniye);
        }
        public override string ToString()
        {
            string onceSonra;
            int geciciSaat=Saat;
            if (Saat > 12)
            {
                onceSonra = "ÖS";
                geciciSaat = Saat % 12;
            }
            else if (Saat == 12)
            {
                onceSonra = "ÖS";
            }
            else if (Saat == 0)
            {
                onceSonra = "ÖÖ";
                geciciSaat = 12;
            }
            else
                onceSonra = "ÖÖ";
            return String.Format("{0:D2}:{1:D2}:{2:D2} {3}",geciciSaat,Dakika,Saniye,onceSonra);
            
        }
    }
}
