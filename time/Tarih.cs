using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP08042016
{
    class Tarih
    {
        int yil, ay, gun;

        public int Ay
        {
            get
            {
                return ay;
            }

            set
            {
                ay = value;
            }
        }

        public int Gun
        {
            get
            {

                return gun;
            }

            set
            {
                int[] gunSayilari = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                if (gunSayilari[Ay - 1] >= value)
                    gun = value;
                else if (Ay == 2 && value == 29 && ((Yil % 4 == 0 && Yil % 100 != 0) || Yil % 400 == 0))
                    gun = value;
            }
        }

        public int Yil
        {
            get
            {
                return yil;
            }

            set
            {
                yil = value;
            }
        }

        public Tarih(int gun, int ay, int yil)
        {
            Ay = ay;
            Yil = yil;
            Gun = gun;
        }

        public override string ToString()
        {
            return Gun+"/"+Ay+"/"+Yil;
        }
    }
}
