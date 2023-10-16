using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace zadanie_3     // ANALOGICZNIE JAK W "FORM2.cs"
{
    public partial class Form3 : Form
    {
        public static Form3 instance;
        public Form3()
        {
            InitializeComponent();
            instance = this;
            label_samouczek_opis.Hide();
            label_test1_wynik.Hide();
            label_test1_wynik.Text = "0";
            pictureBox1.Hide();
            czas_i = 0;
        }

        private void grajTest()
        {
            timer2.Enabled = false;

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
            Form1.instance.wynik2_i.Text = wynik_i.ToString();
        }

        private void grajSamouczek()
        {
            timer2.Enabled = false;
        }

        private void b_test2_start_Click(object sender, EventArgs e)
        {
            label_test1_wynik.Show();
            b_test1_start.Hide();
            b_test1_samouczek.Hide();

            pictureBox1.BackColor = Color.White;
            pictureBox1.Show();

            moment_zmiany_i = rnd.Next(100, 300);

            czy_test_samou_s = "Test";
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            czas_i++;
            if (czas_i == moment_zmiany_i)
            {
                /*SoundPlayer splayer = new SoundPlayer("C:/Users/11adi/OneDrive/Pulpit/testowamuza.wav");
                splayer.Play();*/
                SystemSounds.Exclamation.Play();
            }
            if (czy_test_samou_s == "Samouczek")
            {
                label_test1_wynik.Text = "Wciśnij za:" + (moment_zmiany_i - czas_i).ToString() + "ms";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (czy_test_samou_s == "Test")
            {
                pictureBox1.BackColor = Color.Red;
                grajTest();
            }
            else if (czy_test_samou_s == "Samouczek")
            {
                pictureBox1.BackColor = Color.Red;
                grajSamouczek();
            }
        }

        private void b_test2_samouczek_Click(object sender, EventArgs e)
        {
            label_samouczek_opis.Show();
            label_test1_wynik.Show();
            b_test1_start.Hide();
            b_test1_samouczek.Hide();

            pictureBox1.BackColor = Color.White;
            pictureBox1.Show();

            moment_zmiany_i = rnd.Next(100, 300);

            czy_test_samou_s = "Samouczek";
            timer2.Enabled = true;
        }
    }
}