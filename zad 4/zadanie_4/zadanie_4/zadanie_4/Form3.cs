using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_4
{
    
    public partial class Form3 : Form
    {
        public static Form3 instance;
        public Form3()
        {
            InitializeComponent();
            instance = this;
        }

        private void wyl_went1_wl_went2_b_Click(object sender, EventArgs e)
        {
            Form2.instance.ingerencja_operatora_s.Text = "wylacz wentylator glowny i wlacz awaryjny";
            Form1.instance.czy_kliknieto.Text = "tak";
        }

        private void went_op2_b_Click(object sender, EventArgs e)
        {
            Form2.instance.ingerencja_operatora_s.Text = "wymiana wentylatora glownego na nowy i wylaczenie 2 wentylatora";
            Form1.instance.czy_kliknieto.Text = "tak";
        }

        private void nagrzewnica_op1_b_Click(object sender, EventArgs e)
        {
            Form2.instance.ingerencja_operatora_s.Text = "zmniejsz energię dostarczaną do nagrzewnicy o 5W";
            Form1.instance.czy_kliknieto.Text = "tak";
        }

        private void nagrzewnica_op2_b_Click(object sender, EventArgs e)
        {
            Form2.instance.ingerencja_operatora_s.Text = "zwieksz energię dostarczaną do nagrzewnicy o 5W";
            Form1.instance.czy_kliknieto.Text = "tak";
        }

        private void chlodnica_op1_b_Click(object sender, EventArgs e)
        {
            Form2.instance.ingerencja_operatora_s.Text = "zmniejsz energię dostarczaną do chlodnicy o 5W";
            Form1.instance.czy_kliknieto.Text = "tak";
        }

        private void chlodnica_op2_b_Click(object sender, EventArgs e)
        {
            Form2.instance.ingerencja_operatora_s.Text = "zwieksz energię dostarczaną do chlodnicy o 5W";
            Form1.instance.czy_kliknieto.Text = "tak";
        }

        private void linia_op1_b_Click(object sender, EventArgs e)
        {
            Form2.instance.ingerencja_operatora_s.Text = "zresetuj linie";
            Form1.instance.czy_kliknieto.Text = "tak";
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            Form1.instance.czy_kliknieto.Text = "tak";
        }
    }
}
