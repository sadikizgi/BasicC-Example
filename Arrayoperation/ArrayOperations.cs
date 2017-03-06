using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPL18032016
{
    class ArrayOperations
    {
        public int diziToplami(int[] dizi)
        {
            int toplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                toplam += dizi[i];
            }
            return toplam;
        }

        public double diziOrtalamasi(int[] dizi)
        {
            //double ort;
            //ort = diziToplami(dizi) / (double)dizi.Length;
            //return ort;

           return diziToplami(dizi) / (double)dizi.Length;

        }

        public int enKucukBul(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
                
            }
            return min;
        }

        public double tekCiftOrani(int[] dizi)
        {
            int tek= 0;
            int cift= 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                    cift += dizi[i];
                else
                    tek += dizi[i];
            }
            return tek / (double)cift;
        }

        public int enBuyukBul(int []dizi)
        {
            int max = dizi[0];
            for(int i=0;i<dizi.Length;i++)
            {
                if (dizi[i] > max)
                    max = dizi[i];
            }
            return max;
        }
        public int enKucukEnBuyukToplami(int[] dizi)
        {
            int toplam = enKucukBul(dizi) + enBuyukBul(dizi);
            return toplam;
        }
    }
}
