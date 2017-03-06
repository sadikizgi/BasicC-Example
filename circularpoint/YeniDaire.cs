using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP12042016
{
    class YeniDaire
    {
        int r;
        Nokta merkez;

        public YeniDaire()
        {
            r = 1;
            merkez = new Nokta();
        }

        public YeniDaire(int r, int x, int y)
        {
            this.r = r;
            merkez = new Nokta(x, y);
        }
        public YeniDaire(int r, Nokta n)
        {
            this.r = r;
            merkez = n;
            //merkez = new Nokta(n.x, n.y);
        }
       
        public double alan()
        {
            return Math.PI * r * r;
        }

        public double uzaklik(YeniDaire d)
        {
            //return Math.Sqrt(Math.Pow(merkez.x - d.merkez.x, 2) +
            //Math.Pow(merkez.y - d.merkez.y, 2)); 
            return merkez.uzaklik(d.merkez);
        }

        public string ToString()
        {
            return "daire r..:" + this.r + "  "+ merkez.ToString();
                      
        }
    }
}
