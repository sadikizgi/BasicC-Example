using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYPL06052016
{
    public partial class Form1 : Form
    {
        string girdi;
        string islem;
        double sayi1, sayi2;

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            girdi += "1";
            textBoxGoruntule.Text = girdi;
        }

        private void buttonRakamlar_Click(object sender, EventArgs e)
        {

            girdi += ((Button)sender).Text;
            textBoxGoruntule.Text = girdi;
        }

        private void buttonEsittir_Click(object sender, EventArgs e)
        {
            double.TryParse(girdi, out sayi2);
            switch (islem)
            {
                case "+":
                    textBoxGoruntule.Text = (sayi1 + sayi2).ToString();
                    break;
                case "-":
                    textBoxGoruntule.Text = (sayi1 - sayi2).ToString();
                    break;
                case "*":
                    textBoxGoruntule.Text = (sayi1 * sayi2).ToString();
                    break;
                case "/":
                    if (sayi2 == 0)
                        textBoxGoruntule.Text = "Sonsuz";
                    else
                        textBoxGoruntule.Text = (sayi1 / sayi2).ToString();
                    break;
                default:
                    break;
            }
            girdi = textBoxGoruntule.Text;
            islem = string.Empty;
        }

        private void Islemler_Click(object sender, EventArgs e)
        {
            islem = ((Button)sender).Text;
            double.TryParse(girdi, out sayi1);
            textBoxGoruntule.Clear();
            girdi = String.Empty;
        }
    }
}
