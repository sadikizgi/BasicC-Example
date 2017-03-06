using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPL22042016
{
    class SaatlikCalisan : Calisan
    {
        double saatlikUcret;
        double calisilanSaat;

        public double SaatlikUcret
        {
            get
            {
                return saatlikUcret;
            }

            set
            {
                if (value >= 0)
                    saatlikUcret = value;
                else
                    Console.WriteLine("Saatlik ucret 0dan kucuk olamaz");
            }
        }

        public SaatlikCalisan(string ad, string soyad, int tcKimlikNo, double saatlikUcret, double calisilanSaat)
            :base(ad,soyad,tcKimlikNo)
        {
            SaatlikUcret = saatlikUcret;
            CalisilanSaat = calisilanSaat;
        }

        public double CalisilanSaat
        {
            get
            {
                return calisilanSaat;
            }

            set
            {
                if (value >= 0 && value<168)
                    calisilanSaat = value;
                else
                    Console.WriteLine("Calisilan saat 0dan kucuk ve 168den buyuk olamaz");
            }
        }
        public override double Kazanc()
        {
            if (calisilanSaat < 40)
                return CalisilanSaat * SaatlikUcret;
            else
              return  40 * saatlikUcret + (calisilanSaat - 40) * saatlikUcret * 1.5;
                
        }

        public override string ToString()
        {
            return "Saatli Calisan "+base.ToString()+" Calisilan Saat:"+CalisilanSaat + " Saatlik Ucret:" + SaatlikUcret;
        }
    }
}
