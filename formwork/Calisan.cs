using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPL22042016
{
   abstract class Calisan
    {
        string ad;
        string soyad;
        int tcKimlikNo;

        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }

        public string Soyad
        {
            get
            {
                return soyad;
            }

            set
            {
                soyad = value;
            }
        }

        public int TcKimlikNo
        {
            get
            {
                return tcKimlikNo;
            }

             set
            {
                tcKimlikNo = value;
            }
        }
        public Calisan(string ad, string soyad, int tcKimlikNo)
        {
            Ad = ad;
            Soyad = soyad;
            TcKimlikNo = tcKimlikNo;
        }

        public override string ToString()
        {
            return Ad + " " +Soyad +" TC:"+TcKimlikNo;
        }

        public abstract double Kazanc();
    }
}
