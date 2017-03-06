using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYP03052016
{
    public partial class Form1 : Form
    {
        Color eski;
        ArrayList list = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            eski = this.BackColor;        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = eski;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "MERHABA";
            label1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            label1.Text = textBox1.Text;
            label1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            list.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void toplamButton_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < list.Count; i++)
            {
                try
                {
                    toplam += Convert.ToInt32(list[i]);
                    MessageBox.Show("toplamın altı "+list[i]);
                }
                catch (FormatException)
                {
                    MessageBox.Show("sayıya çevrilemiyor..:"+list[i]);
                   
                }catch(Exception)
                {

                }
                

            }
            textBox2.Text = toplam.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
