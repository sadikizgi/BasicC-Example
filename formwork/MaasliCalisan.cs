using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPL22042016
{
    class MaasliCalisan:Calisan,IKarsilastirilabilir
    {
        double haftalikMaas;

        public double HaftalikMaas
        {
            get
            {
                return haftalikMaas;
            }

            set
            {
                if(value>=0)
                    haftalikMaas = value;
                else
                    Console.WriteLine("Maas 0dan kucuk olamaz");
            }
        }

        public MaasliCalisan(string ad,string soyad,int tcKimlikNo,double haftalikMaas)
            :base(ad,soyad,tcKimlikNo)
        {
            HaftalikMaas = haftalikMaas;
        }

        public override double Kazanc()
        {
            return HaftalikMaas;
        }
        public override string ToString()
        {
            return "Maasli "+base.ToString() + "Haftalik Maas:"+ HaftalikMaas;
        }

        public int Karsilastir(object o)
        {
            if (o is Calisan)
            {
                if (Kazanc() > ((Calisan)o).Kazanc())
                    return 1;
                else if (Kazanc() == ((Calisan)o).Kazanc())
                    return 0;
                else
                    return -1;
            }
            return -2;
        }
    }
}
