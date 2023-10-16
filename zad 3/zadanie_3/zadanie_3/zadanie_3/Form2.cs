using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_3
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            label_samouczek_opis.Hide();
            label_test1_wynik.Hide();
            label_test1_wynik.Text = "0";
            pictureBox1.Hide();
            czas_i = 0;
        }

        // zliczanie punktów
        private void grajTest()
        {
            timer1.Enabled = false;

            if (czas_i >= moment_zmiany_i)
            {
                if ((czas_i - moment_zmiany_i) != 0)
                {
                    wynik_i = 330 / (czas_i - moment_zmiany_i);
                    label_test1_wynik.Text = wynik_i.ToString();
                }
                else
                {
                    wynik_i = 330;
                    label_test1_wynik.Text = wynik_i.ToString();
                }
            }
            else
            {
                wynik_i = 0;
                label_test1_wynik.Text = wynik_i.ToString();
            }

            MessageBox.Show("Twój wynik to:" + wynik_i.ToString());
            Form1.instance.wynik1_i.Text = wynik_i.ToString();
        }

        private void grajSamouczek()
        {
            timer1.Enabled = false;            
        }

        // przycisk startu gry
        private void b_test1_start_Click(object sender, EventArgs e)
        {
            label_test1_wynik.Show();
            b_test1_start.Hide();
            b_test1_samouczek.Hide();

            pictureBox1.BackColor = Color.White;
            pictureBox1.Show();

            moment_zmiany_i = rnd.Next(100, 300);

            czy_test_samou_s = "Test";
            timer1.Enabled = true;
        }
        // przycisk startu samouczka
        private void b_test1_samouczek_Click(object sender, EventArgs e)
        {
            label_samouczek_opis.Show();
            label_test1_wynik.Show();
            b_test1_start.Hide();
            b_test1_samouczek.Hide();

            pictureBox1.BackColor = Color.White;
            pictureBox1.Show();

            moment_zmiany_i = rnd.Next(100, 300);

            czy_test_samou_s = "Samouczek";
            timer1.Enabled = true;
        }

        // liczenie czasu gry
        private void timer1_Tick(object sender, EventArgs e)
        {
            czas_i++;
            if (czas_i == moment_zmiany_i)
            {
                pictureBox1.BackColor = Color.Red;
            }
            if (czy_test_samou_s == "Samouczek")
            {
                label_test1_wynik.Text = "Wciśnij za:" + (moment_zmiany_i - czas_i).ToString() + "ms";
            }
        }

        // akcja kończąca grę
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (czy_test_samou_s == "Test")
            {
                grajTest();
            }
            else if (czy_test_samou_s == "Samouczek")
            {
                grajSamouczek();
            }
        }
    }
}
