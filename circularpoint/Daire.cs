using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP12042016
{
    class Daire
    {
        int x;
        int y;
        int r;

        public int R
        {
            get
            {
                return r;
            }

            set
            {
                if (value < 1)
                    r = 1;
                else
                    r = value;
            }
        }

        public Daire()
        {
            x = y = 0;
            R = 1;
        }
        public Daire(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.R = r;
        }

        public double alan()
        {
            return Math.PI * r * r;

        }

        public double uzaklik(Daire d)
        {
            return Math.Sqrt(Math.Pow(this.x - d.x, 2) +
                Math.Pow(this.y - d.y, 2));

        }

    }
}
