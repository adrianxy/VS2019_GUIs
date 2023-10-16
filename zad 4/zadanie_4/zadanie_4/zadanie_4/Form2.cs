using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using OpenHardwareMonitor.Hardware;

namespace zadanie_4
{
    public partial class Form2 : Form
    {
        private Computer computer;
        
        public static Form2 instance;
        public Label ingerencja_operatora_s;
        
        public Form2()
        {
            InitializeComponent();
            instance = this;
            ingerencja_operatora_s = label1;

            // Inicjalizujemy obiekt Computer
            computer = new Computer();
            computer.CPUEnabled = true; // Umożliwiamy odczyt temperatury procesora
            computer.GPUEnabled = true; // Umożliwiamy odczyt temperatury karty graficznej
            computer.FanControllerEnabled = true; // Umożliwiamy odczyt prędkości wentylatorów
            computer.MainboardEnabled = true; // Umożliwiamy odczyt temperatury płyty głównej

            computer.Open();

            went1_on_off = true;
            linia_on_off = true;
        }

        private void menu_operatora_b_Click(object sender, EventArgs e)
        {
            okno3 = new Form3();
            okno3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // wentylator 1 (jego obroty stopniowo spadaja i trzeba naprawiac)
            if (went1_on_off)
            {
                wentylator_i = 300 + rnd.Next(went_zepsucie_i, went_zepsucie_i + 5);
                if (wentylator_i <= 0)
                {
                    wentylator_i = 0;
                }
                wentylator_tb.Text = wentylator_i.ToString();
                if (rnd.Next(-10, 10) < 0)
                {
                    went_zepsucie_i -= 5;
                }
                
                if (went_zepsucie_i < -200)
                {
                    wentylator_tb.BackColor = Color.Red;
                }
                else if (went_zepsucie_i < -100)
                {
                    wentylator_tb.BackColor = Color.Yellow;
                }
                else
                {
                    wentylator_tb.BackColor = Color.White;
                }
            }
            
            // wentylator 2 (zapasowy, nie ulego uszkoczeniu)
            if (went2_on_off)
            {
                wentylator2_i = 300 + rnd.Next(-5, 5);
                wentylator2_tb.Text = wentylator2_i.ToString();
            }

            // nagrzewnica
            // Przeszukujemy wszystkie obiekty w systemie, w tym CPU
            foreach (var hardwareItem in computer.Hardware)
            {
                hardwareItem.Update();

                // Szukamy CPU
                if (hardwareItem.HardwareType == HardwareType.CPU)
                {
                    // Dla CPU pobieramy temperature
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            nagrzwnica_i = 300 + (int)sensor.Value + nagrzewnica_inger_oper_i;
                            nagrzewnica_tb.Text = nagrzwnica_i.ToString();
                        }
                    }
                }
            }
            if (nagrzwnica_i < 340)
            {
                nagrzewnica_tb.BackColor = Color.Red;
            }
            else if (nagrzwnica_i < 350)
            {
                nagrzewnica_tb.BackColor = Color.Yellow;
            }
            else
            {
                nagrzewnica_tb.BackColor = Color.White;
            }



            // chłodnica
            // Przeszukujemy wszystkie obiekty w systemie, w tym GPU
            foreach (var hardwareItem in computer.Hardware)
            {
                hardwareItem.Update();

                // Szukamy GPU
                if (hardwareItem.HardwareType == HardwareType.GpuNvidia)
                {
                    // Dla GPU pobieramy temperature
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            chlodnica_i = -100 + (int)sensor.Value + chlodnica_inger_oper_i;
                            chlodnica_tb.Text = chlodnica_i.ToString();
                        }
                    }
                }
            }
            if (chlodnica_i > -70)
            {
                chlodnica_tb.BackColor = Color.Red;
            }
            else if (chlodnica_i > -75)
            {
                chlodnica_tb.BackColor = Color.Yellow;
            }
            else
            {
                chlodnica_tb.BackColor = Color.White;
            }

            // linia
            if(linia_on_off)
            {
                linia_tb.Text = "ON";
                linia_tb.BackColor = Color.White;
                if(rnd.Next(0,10) == 5)
                {
                    linia_on_off = false;
                }
            }
            else
            {
                linia_tb.Text = "OFF";
                linia_tb.BackColor = Color.Red;
            }


            // ingerencja operatora:
            if (ingerencja_operatora_s.Text == "wylacz wentylator glowny i wlacz awaryjny")
            {
                went1_on_off = false;
                wentylator_tb.BackColor = Color.White;
                wentylator_tb.Text = "0";

               went2_on_off = true;
            }
            else if (ingerencja_operatora_s.Text == "wymiana wentylatora glownego na nowy i wylaczenie 2 wentylatora")
            {
                went_zepsucie_i = 0;
                went1_on_off = true;

                went2_on_off = false;
                wentylator2_tb.Text = "0";
            }
            else if (ingerencja_operatora_s.Text == "zmniejsz energię dostarczaną do nagrzewnicy o 5W")
            {
                nagrzewnica_inger_oper_i -= 5;
            }
            else if (ingerencja_operatora_s.Text == "zwieksz energię dostarczaną do nagrzewnicy o 5W")
            {
                nagrzewnica_inger_oper_i += 5;
            }
            else if (ingerencja_operatora_s.Text == "zmniejsz energię dostarczaną do chlodnicy o 5W")
            {
                chlodnica_inger_oper_i += 5;
            }
            else if (ingerencja_operatora_s.Text == "zwieksz energię dostarczaną do chlodnicy o 5W")
            {
                chlodnica_inger_oper_i -= 5;
            }
            else if (ingerencja_operatora_s.Text == "zresetuj linie")
            {
                linia_on_off = true;
            }
            ingerencja_operatora_s.Text = ""; // zerowanie ingerencji operatora     
        }
    }
}
