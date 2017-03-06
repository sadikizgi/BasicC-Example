using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPL15042016
{
    class Kart
    {
        private string numara;
        private string tip;
        public Kart(string tip, string numara)
        {
            this.numara = numara;
            this.tip = tip;
        }

        public override string ToString()
        {
            return string.Format("{0,-7}:{1}",tip,numara);// tip + ":" + numara;
        }
    }
}
