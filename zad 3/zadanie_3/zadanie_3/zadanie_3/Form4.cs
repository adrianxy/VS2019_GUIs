using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_3
{
    public partial class Form4 : Form
    {
        public static Form4 instance;
        public Form4()
        {
            InitializeComponent();
            instance = this;
            label_samouczek_opis.Hide();
            label_test3_wynik.Hide();
            label_test3_wynik.Text = "0";
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            temp_i = 0;
            temp_s = "czekaj";
        }

        // uruchomienie gry
        private void b_test3_start_Click(object sender, EventArgs e)
        {
            b_test3_start.Hide();
            b_test3_samouczek.Hide();
            label_test3_wynik.Show();

            pictureBox1.BackColor = Color.White;
            pictureBox1.Show();
            pictureBox2.BackColor = Color.White;
            pictureBox2.Show();
            pictureBox3.BackColor = Color.White;
            pictureBox3.Show();
            pictureBox4.BackColor = Color.White;
            pictureBox4.Show();
            pictureBox5.BackColor = Color.White;
            pictureBox5.Show();
            pictureBox6.BackColor = Color.White;
            pictureBox6.Show();
            pictureBox7.BackColor = Color.White;
            pictureBox7.Show();
            pictureBox8.BackColor = Color.White;
            pictureBox8.Show();
            pictureBox9.BackColor = Color.White;
            pictureBox9.Show();

            czy_test_samou_s = "Test";
            timer1.Enabled = true;

            Focus();
        }

        // uruchomienie samouczka
        private void b_test3_samouczek_Click(object sender, EventArgs e)
        {
            b_test3_start.Hide();
            b_test3_samouczek.Hide();
            label_samouczek_opis.Show();

            pictureBox1.BackColor = Color.White;
            pictureBox1.Show();
            pictureBox2.BackColor = Color.White;
            pictureBox2.Show();
            pictureBox3.BackColor = Color.White;
            pictureBox3.Show();
            pictureBox4.BackColor = Color.White;
            pictureBox4.Show();
            pictureBox5.BackColor = Color.White;
            pictureBox5.Show();
            pictureBox6.BackColor = Color.White;
            pictureBox6.Show();
            pictureBox7.BackColor = Color.White;
            pictureBox7.Show();
            pictureBox8.BackColor = Color.White;
            pictureBox8.Show();
            pictureBox9.BackColor = Color.White;
            pictureBox9.Show();

            czy_test_samou_s = "Samouczek";
            timer1.Enabled = true;

            Focus();
        }

        // czyszczenie okna przed rysowaniem kolejnego zwierzaka
        private void czyszczenie_okien()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
        }

        // wyświetlanie zwierzaka
        private void wczytaj_obraz(PictureBox okno)
        {
            okno.Image = null;
            if (ktore_zwierze_i == 1)
            {
                timer1.Interval = 1200;
                okno.Image = global::zadanie_3.Properties.Resources.dzik_1pkt;
            }
            else if (ktore_zwierze_i == 2)
            {
                timer1.Interval = 800;
                okno.Image = global::zadanie_3.Properties.Resources.kruk_2pkt;
            }
            else if (ktore_zwierze_i == 3)
            {
                timer1.Interval = 500;
                okno.Image = global::zadanie_3.Properties.Resources.borsuk_3pkt;
            }
        }

        // losowanie pola i zwierzaka
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_test3_wynik.Text = wynik_i.ToString();

            ktore_pole_i = rnd.Next(1, 10);
            ktore_zwierze_i = rnd.Next(1, 4);
            czy_moge_dostac_pkt = true;

            czyszczenie_okien();
            //if (temp_i % 2 == 0)
            {
                if (ktore_pole_i == 1)
                {
                    wczytaj_obraz(pictureBox1);
                }
                else if (ktore_pole_i == 2)
                {
                    wczytaj_obraz(pictureBox2);
                }
                else if (ktore_pole_i == 3)
                {
                    wczytaj_obraz(pictureBox3);
                }
                else if (ktore_pole_i == 4)
                {
                    wczytaj_obraz(pictureBox4);
                }
                else if (ktore_pole_i == 5)
                {
                    wczytaj_obraz(pictureBox5);
                }
                else if (ktore_pole_i == 6)
                {
                    wczytaj_obraz(pictureBox6);
                }
                else if (ktore_pole_i == 7)
                {
                    wczytaj_obraz(pictureBox7);
                }
                else if (ktore_pole_i == 8)
                {
                    wczytaj_obraz(pictureBox8);
                }
                else if (ktore_pole_i == 9)
                {
                    wczytaj_obraz(pictureBox9);
                }
            }
            temp_i++;
            if (temp_i == 11)
            {
                timer1.Enabled = false;
                if (czy_test_samou_s == "Test")
                {
                    MessageBox.Show("Twój wynik to:" + wynik_i.ToString());
                    Form1.instance.wynik3_i.Text = wynik_i.ToString();

                }
            }
        }

        // zliczanie punktów
        private void ile_dodac(bool czy_ok)
        {
            if (czy_ok == true & czy_moge_dostac_pkt == true)
            {
                wynik_i += ktore_zwierze_i;
            }
            else
            {
                wynik_i -= ktore_zwierze_i;
            }
            czy_moge_dostac_pkt = false;
            label_test3_wynik.Text = wynik_i.ToString();
        }

        // okcja po wciśnięciu zwierzaka
        private void wcisnieto_obrazek(int x)
        {
            if (czy_test_samou_s == "Test")
            {
                if (ktore_pole_i == x)
                {
                    ile_dodac(true);
                }
                else
                {
                    ile_dodac(false);
                }
            }
        }

        // trafianie w zwierzaka
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            wcisnieto_obrazek(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            wcisnieto_obrazek(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            wcisnieto_obrazek(3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            wcisnieto_obrazek(4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            wcisnieto_obrazek(5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            wcisnieto_obrazek(6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            wcisnieto_obrazek(7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            wcisnieto_obrazek(8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            wcisnieto_obrazek(9);
        }

        // granie na klawiaturze numerycznej
        private void key_press_basic(object sender, KeyPressEventArgs e)
        {
            
            if(e.KeyChar == '7')
            {
                this.pictureBox1_Click(sender, e);
            }
            if(e.KeyChar == '8')
            {
                this.pictureBox2_Click(sender, e);
            }
            if (e.KeyChar == '9')
            {
                this.pictureBox3_Click(sender, e);
            }
            if (e.KeyChar == '4')
            {
                this.pictureBox4_Click(sender, e);
            }
            if (e.KeyChar == '5')
            {
                this.pictureBox5_Click(sender, e);
            }
            if (e.KeyChar == '6')
            {
                this.pictureBox3_Click(sender, e);
            }
            if (e.KeyChar == '1')
            {
                this.pictureBox7_Click(sender, e);
            }
            if (e.KeyChar == '2')
            {
                this.pictureBox8_Click(sender, e);
            }
            if (e.KeyChar == '3')
            {
                this.pictureBox9_Click(sender, e);
            }
        }
    } 
}
