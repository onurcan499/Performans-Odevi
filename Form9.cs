using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peformans_ödevi
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
        }
        int sayac = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 3)
            {
                button1.Enabled = false;
                label1.Text = ("Bu Yemeği üretilenden fazla sipariş ettiniz");

            }

            if (sayac == 1)
            {
                label1.Text = ("1.Köfte Sipariş Edildi");
                button1.Enabled = true;
                button3.Enabled = true;
            }
            if (sayac == 2)
            {
                label1.Text = ("2.Köfte Sipariş Edildi");
                button1.Enabled = true;
                button3.Enabled = true;

            }
            if (sayac == 0)
            {

                button1.Enabled = true;
                button3.Visible = false;

            }
            button3.Visible = true;//button3'ün görünürlüğünün açılması
        }

        private void button3_Click(object sender, EventArgs e)
        {

            sayac--;
            if (sayac == 0)
            {
                button1.Enabled = true;
                label1.Text = ("");
                button3.Visible = false;

            }
            if (sayac == 1)
            {
                label1.Text = ("1.Köfte Sipariş Edildi");
                button1.Enabled = true;
                button3.Enabled = true;

            }
            if (sayac == 2)
            {
                label1.Text = ("2.Köfte Sipariş Edildi");
                button1.Enabled = true;
                button3.Enabled = true;

            }
            if (sayac == 3)
            {
                button1.Enabled = false;
                button3.Enabled = true;

            }
        }
    }
}
