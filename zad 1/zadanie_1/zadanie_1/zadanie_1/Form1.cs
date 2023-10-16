using System;
using System.Drawing;
using System.Windows.Forms;

namespace zadanie_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WIDTH = 300; HEIGHT = 300; secHAND = 140; minHAND = 110; hrHAND = 80;
            this.liczba_wprowadzana_s = "";
            this.operacja = "";
            this.liczba_akumulowana_f = 0;
        }

        // akcje po kliknięciu w przyciski
        private void button_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            
            //wprowadzanie liczb
            if (przycisk.Text == "0")
            {
                this.liczba_wprowadzana_s = this.liczba_wprowadzana_s + "0";
                this.textBox1.Text = this.liczba_wprowadzana_s;
                this.liczba_wprowadzana_f = (float)Convert.ToDouble(this.liczba_wprowadzana_s);
            }
            if (przycisk.Text == "1")
            {
                this.liczba_wprowadzana_s = this.liczba_wprowadzana_s + "1";
                this.textBox1.Text = this.liczba_wprowadzana_s;
                this.liczba_wprowadzana_f = (float)Convert.ToDouble(this.liczba_wprowadzana_s);
            }
            if (przycisk.Text == "2")
            {
                this.liczba_wprowadzana_s = this.liczba_wprowadzana_s + "2";
                this.textBox1.Text = this.liczba_wprowadzana_s;
                this.liczba_wprowadzana_f = (float)Convert.ToDouble(this.liczba_wprowadzana_s);
            }
            if (przycisk.Text == "3")
            {
                this.liczba_wprowadzana_s = this.liczba_wprowadzana_s + "3";
                this.textBox1.Text = this.liczba_wprowadzana_s;
                this.liczba_wprowadzana_f = (float)Convert.ToDouble(this.liczba_wprowadzana_s);
            }
            if (przycisk.Text == "4")
            {
                this.liczba_wprowadzana_s = this.liczba_wprowadzana_s + "4";
                this.textBox1.Text = this.liczba_wprowadzana_s;
                this.liczba_wprowadzana_f = (float)Convert.ToDouble(this.liczba_wprowadzana_s);
            }
            if (przycisk.Text == "5")
            {
                this.liczba_wprowadzana_s = this.liczba_wprowadzana_s + "5";
                this.textBox1.Text = this.liczba_wprowadzana_s;
                this.liczba_wprowadzana_f = (float)Convert.ToDouble(this.liczba_wprowadzana_s);
            }
            if (przycisk.Text == "6")
            {
                this.liczba_wprowadzana_s = this.liczba_wprowadzana_s + "6";
                this.textBox1.Text = this.liczba_wprowadzana_s;
                this.liczba_wprowadzana_f = (float)Convert.ToDouble(this.liczba_wprowadzana_s);
            }
            if (przycisk.Text == "7")
            {
                this.liczba_wprowadzana_s = this.liczba_wprowadzana_s + "7";
                this.textBox1.Text = this.liczba_wprowadzana_s;
                this.liczba_wprowadzana_f = (float)Convert.ToDouble(this.liczba_wprowadzana_s);
            }
            if (przycisk.Text == "8")
            {
                this.liczba_wprowadzana_s = this.liczba_wprowadzana_s + "8";
                this.textBox1.Text = this.liczba_wprowadzana_s;
                this.liczba_wprowadzana_f = (float)Convert.ToDouble(this.liczba_wprowadzana_s);
            }
            if (przycisk.Text == "9")
            {
                this.liczba_wprowadzana_s = this.liczba_wprowadzana_s + "9";
                this.textBox1.Text = this.liczba_wprowadzana_s;
                this.liczba_wprowadzana_f = (float)Convert.ToDouble(this.liczba_wprowadzana_s);
            }


            //wprowadzanie liczby po przecinku
            if (przycisk.Text == ",")
            {
                if (!liczba_wprowadzana_s.Contains(","))   //zabezpieczenie przed wielona ","
                {
                    this.liczba_wprowadzana_s = this.liczba_wprowadzana_s + ",";
                    this.textBox1.Text = this.liczba_wprowadzana_s;
                }
            }


            //wybór operacji, wynik po wciśnięciu "="
            if (przycisk.Text == "+")
            {
                if (liczba_akumulowana_f == 0)
                {
                    this.liczba_akumulowana_f = this.liczba_wprowadzana_f;
                }
                this.liczba_wprowadzana_f = 0;
                this.liczba_wprowadzana_s = "";
                this.operacja = "+";
            }
            if (przycisk.Text == "-")
            {
                if (liczba_akumulowana_f == 0)
                {
                    this.liczba_akumulowana_f = this.liczba_wprowadzana_f;
                }
                this.liczba_wprowadzana_f = 0;
                this.liczba_wprowadzana_s = "-";
                if (operacja != "/" & operacja != "*")
                {
                    this.operacja = "-";
                }
            }
            if (przycisk.Text == "*")
            {
                if (liczba_akumulowana_f == 0)
                {
                    this.liczba_akumulowana_f = this.liczba_wprowadzana_f;
                }
                this.liczba_wprowadzana_f = 0;
                this.liczba_wprowadzana_s = "";
                this.operacja = "*";
            }
            if (przycisk.Text == "/")
            {
                if (liczba_akumulowana_f == 0)
                {
                    this.liczba_akumulowana_f = this.liczba_wprowadzana_f;
                }
                this.liczba_wprowadzana_f = 0;
                this.liczba_wprowadzana_s = "";
                this.operacja = "/";
            }
            if (przycisk.Text == "x^2")
            {
                if (liczba_akumulowana_f == 0)
                {
                    this.liczba_akumulowana_f = this.liczba_wprowadzana_f;
                }
                this.liczba_wprowadzana_f = 0;
                this.liczba_wprowadzana_s = "";
                this.operacja = "x^2";
            }
            if (przycisk.Text == "pierwiastek")
            {
                if (liczba_akumulowana_f == 0)
                {
                    this.liczba_akumulowana_f = this.liczba_wprowadzana_f;
                }
                this.liczba_wprowadzana_f = 0;
                this.liczba_wprowadzana_s = "";
                this.operacja = "pierwiastek";
            }


            //czyszczenie
            if (przycisk.Text == "CE")
            {
                if (this.liczba_wprowadzana_s.Length > 0)
                {
                    this.liczba_wprowadzana_s = this.liczba_wprowadzana_s.Remove(this.liczba_wprowadzana_s.Length - 1, 1);
                    if (this.liczba_wprowadzana_s.Length == 0)
                    {
                        this.liczba_wprowadzana_s = "0";
                    }
                    else if (this.liczba_wprowadzana_s == "-")
                    {
                        this.liczba_wprowadzana_s = "0";
                    }
                    this.liczba_wprowadzana_f = (float)Convert.ToDouble(this.liczba_wprowadzana_s);
                }
                this.textBox1.Text = this.liczba_wprowadzana_s;
            }
            if (przycisk.Text == "C")
            {
                this.liczba_akumulowana_f = 0;
                this.liczba_wprowadzana_f = 0;
                this.liczba_wprowadzana_s = "";
                this.textBox1.Text = "";
            }


            //obliczanie wyniku na podstawie wybranej operacji
            if (przycisk.Text == "=")
            {
                if (operacja == "+")
                {
                    this.liczba_akumulowana_f = this.liczba_akumulowana_f + this.liczba_wprowadzana_f;
                    this.textBox1.Text = this.liczba_akumulowana_f.ToString();
                }
                if (operacja == "-")
                {
                    this.liczba_akumulowana_f = this.liczba_akumulowana_f + this.liczba_wprowadzana_f;
                    this.textBox1.Text = this.liczba_akumulowana_f.ToString();
                }
                if (operacja == "*")
                {
                    this.liczba_akumulowana_f = this.liczba_akumulowana_f * this.liczba_wprowadzana_f;
                    this.textBox1.Text = this.liczba_akumulowana_f.ToString();
                }
                if (operacja == "/")
                {
                    if (liczba_wprowadzana_f != 0)
                    {
                        this.liczba_akumulowana_f = this.liczba_akumulowana_f / this.liczba_wprowadzana_f;
                        this.textBox1.Text = this.liczba_akumulowana_f.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Dzielenie przez zero");
                    }
                }
                if (operacja == "x^2")
                {
                    this.liczba_akumulowana_f = (float)Math.Pow(this.liczba_akumulowana_f, 2);
                    this.textBox1.Text = this.liczba_akumulowana_f.ToString();
                }
                if (operacja == "pierwiastek")
                {
                    this.liczba_akumulowana_f = (float)Math.Sqrt(this.liczba_akumulowana_f);
                    this.textBox1.Text = this.liczba_akumulowana_f.ToString();
                }
            }
        }


        //obsługa klawiatury
        private void button_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                this.but_nr0.PerformClick();
            }
            if (e.KeyChar == '1')
            {
                this.but_nr1.PerformClick();
            }
            if (e.KeyChar == '2')
            {
                this.but_nr2.PerformClick();
            }
            if (e.KeyChar == '3')
            {
                this.but_nr3.PerformClick();
            }
            if (e.KeyChar == '4')
            {
                this.but_nr4.PerformClick();
            }
            if (e.KeyChar == '5')
            {
                this.but_nr5.PerformClick();
            }
            if (e.KeyChar == '6')
            {
                this.but_nr6.PerformClick();
            }
            if (e.KeyChar == '7')
            {
                this.but_nr7.PerformClick();
            }
            if (e.KeyChar == '8')
            {
                this.but_nr8.PerformClick();
            }
            if (e.KeyChar == '9')
            {
                this.but_nr9.PerformClick();
            }
            if (e.KeyChar == 'e')
            {
                this.but_equal.PerformClick();
            }
            if (e.KeyChar == '+')
            {
                this.but_plus.PerformClick();
            }
            if (e.KeyChar == '-')
            {
                this.but_minus.PerformClick();
            }
            if (e.KeyChar == '*')
            {
                this.but_multiply.PerformClick();
            }
            if (e.KeyChar == '/')
            {
                this.but_divide.PerformClick();
            }
            if (e.KeyChar == 'c')
            {
                this.but_clear_all.PerformClick();
            }
            if (e.KeyChar == 'b')
            {
                this.but_clear_last.PerformClick();
            }
            if (e.KeyChar == ',')
            {
                this.but_dot.PerformClick();
            }
            if (e.KeyChar == 'q')
            {
                this.but_pierwiastek.PerformClick();
            }
            if (e.KeyChar == 'p')
            {
                this.but_potega.PerformClick();
            }
        }

        
        //Wybór skórek, kilka funkcji poniżej
        private void niebieskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = System.Drawing.Color.Blue;
        }

        private void szaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = System.Drawing.Color.Gray;
        }

        private void zoltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = System.Drawing.Color.Yellow;
        }

        private void białyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = System.Drawing.Color.White;
        }

        private void zachódSłońcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::zadanie_1.Properties.Resources._20220812_054610;
            this.BackColor = System.Drawing.SystemColors.Control;
        }

        private void podstawowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = System.Drawing.SystemColors.Control;
        }

        private void analogowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tworzenie BMP
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);

            //środek zegara
            cx = WIDTH / 2;
            cy = HEIGHT / 2;

            //ustawienia timera
            timer1.Interval = 1000;  //ms
            timer1.Tick += new EventHandler(this.timer1_Tick);
            timer1.Start();

            this.zegar_cyfrowy.Hide();
            this.pictureBox1.Show();
            this.anal_cyfr = "anal";
        }

        private void cyfrowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.pictureBox1.Hide();
            this.zegar_cyfrowy.Show();
            this.anal_cyfr = "cyfr";
        }

        private void niebieskieTłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zegar_cyfrowy.BackColor = System.Drawing.Color.Blue;
        }

        private void żółtaCzcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zegar_cyfrowy.ForeColor = Color.Red;
        }

        private void podstawowyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.zegar_cyfrowy.ForeColor = Color.Black;
            this.zegar_cyfrowy.BackColor = System.Drawing.SystemColors.Control;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (anal_cyfr == "anal")
            {
                //tworzenie grafiki
                g = Graphics.FromImage(bmp);

                //pobieranie czasu
                int ss = DateTime.Now.Second;
                int mm = DateTime.Now.Minute;
                int hh = DateTime.Now.Hour;

                //tablica na zmienne x,y położenia końcówki wskazówek
                int[] handCoord = new int[2];

                //odświeżanie
                g.Clear(this.BackColor);

                //rysowanie okręgu
                g.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, WIDTH, HEIGHT);

                //podpisywanie godzin zegara
                g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
                g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
                g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
                g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

                //rysowanie wskaźnika sekund
                handCoord = msCoord(ss, secHAND);
                g.DrawLine(new Pen(Color.Red, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                //rysowanie wskaźnika minut
                handCoord = msCoord(mm, minHAND);
                g.DrawLine(new Pen(Color.Black, 3f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                //rysowanie wskaźnika godzin
                handCoord = hrCoord(hh % 12, mm, hrHAND);
                g.DrawLine(new Pen(Color.Gray, 4f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                //ładowanie BMP do pictureBox'a
                pictureBox1.Image = bmp;

                //dispose
                g.Dispose();
            }
            else if (anal_cyfr == "cyfr")
            {
                //pobieranie czasu
                int ss = DateTime.Now.Second;
                int mm = DateTime.Now.Minute;
                int hh = DateTime.Now.Hour;

                //sprawdzanie czy wstawić zero, żeby był format [xx-xx-xx]
                if (ss >= 0 & ss <= 9)
                {
                    zero_num_s = "0";
                }
                if (mm >= 0 & mm <= 9)
                {
                    zero_num_m = "0";
                }
                if (hh >= 0 & hh <= 9)
                {
                    zero_num_h = "0";
                }

                //wyświetlanie zegara
                this.zegar_cyfrowy.Text = (zero_num_h + hh.ToString() + " - " + zero_num_m + mm.ToString() + " - " + zero_num_s + ss.ToString());

                zero_num_s = ""; zero_num_m = ""; zero_num_h = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Hide();
            this.zegar_cyfrowy.Hide();
        }

        //koordynaty dla wskazówek minut i sekund
        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6;   //6 stopni obrót co sekundę/minutę

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }


        //koordynaty dla wskazówki godzin
        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];

            //30 stopni obrót co godzinę
            //kazdej minuty obrót o 0,5 stopnia
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        private void brakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Hide();
            this.zegar_cyfrowy.Hide();
        }

        private void legendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Legenda = new FormLegenda();
            this.Legenda.Show();
        }

        private void autorzyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adrian Nowogrodzki 184332 \nOskar Nowak 184289");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.but_equal.Focus();
        }
    }
}
