using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP12042016
{
    class Nokta
    {
        public int x;
        private int y;
        public Nokta()
        {
            x = y = 0;
        }
        public Nokta(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double uzaklik(Nokta n)
        {
            return Math.Sqrt(Math.Pow(this.x - n.x, 2) +
                            Math.Pow(this.y - n.y, 2));

        }

        public string ToString()
        {
            return "(" + x + "," + y + ")";
        }



    }
}





