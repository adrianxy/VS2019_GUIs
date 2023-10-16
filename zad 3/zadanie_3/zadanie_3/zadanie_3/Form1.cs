using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace zadanie_3
{
    public partial class Form1 : Form
    {
        // do przesyłania danych między oknami, "instance" jest w każdym oknie
        public static Form1 instance;
        public Label wynik1_i;
        public Label wynik2_i;
        public Label wynik3_i;
        public Form1()
        {
            InitializeComponent();
            // do przesyłania danych między oknami, "instance = this" jest w każdym oknie
            instance = this;
            wynik1_i = label1;
            wynik2_i = label2;
            wynik3_i = label3;
        }

        // Otworzenie minitestów
        private void b_test1_Click(object sender, EventArgs e)
        {
            OknoTest1 = new Form2();
            OknoTest1.Show();
        }

        private void b_test2_Click(object sender, EventArgs e)
        {
            OknoTest2 = new Form3();
            OknoTest2.Show();
        }

        private void b_test3_Click(object sender, EventArgs e)
        {
            OknoTest3 = new Form4();
            OknoTest3.Show();
        }

        // Wyświetlanie rezultatów na wykresie
        private void button1_Click(object sender, EventArgs e)
        {
            chart_wyniki.Series["Wyniki"].Points.Clear();
            chart_wyniki.Series["Wyniki"].Points.AddXY("1", 10);
            chart_wyniki.Series["Wyniki"].Points[0].Color = Color.Red;;
            chart_wyniki.Series["Wyniki"].Points[0].AxisLabel = "przeciętny wynik T1";
            chart_wyniki.Series["Wyniki"].Points.AddXY("1", label1.Text);
            chart_wyniki.Series["Wyniki"].Points[1].AxisLabel = "twój wynik T1";
            chart_wyniki.Series["Wyniki"].Points.AddXY("2", 10);
            chart_wyniki.Series["Wyniki"].Points[2].Color = Color.Red;
            chart_wyniki.Series["Wyniki"].Points[2].AxisLabel = "przeciętny wynik T2";
            chart_wyniki.Series["Wyniki"].Points.AddXY("2", label2.Text);
            chart_wyniki.Series["Wyniki"].Points[3].AxisLabel = "twój wynik T2";
            chart_wyniki.Series["Wyniki"].Points.AddXY("3", 10);
            chart_wyniki.Series["Wyniki"].Points[4].Color = Color.Red;
            chart_wyniki.Series["Wyniki"].Points[4].AxisLabel = "przeciętny wynik T3";
            chart_wyniki.Series["Wyniki"].Points.AddXY("3", label3.Text);
            chart_wyniki.Series["Wyniki"].Points[5].AxisLabel = "twój wynik T3";
        }
    }
}
