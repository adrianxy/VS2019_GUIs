using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_5
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        // WPROWADZANIE LINIJKI KODU
        private void button_ok_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + comboBox1.Text + " " + comboBox2.Text + " " + comboBox3.Text + Environment.NewLine;
            il_rozkazow++;
        }

        // WYKONYWANIE CAŁEGO PROGRAMU
        private void button_wykonajPorgram_Click(object sender, EventArgs e)
        {
            Czyszczenie_bez_usuwania_kodu();
            button_krokowo.BackColor = Color.Red;
            A_i = 0;
            B_i = 0;
            C_i = 0;
            D_i = 0;
            for (int i = 0; i < il_rozkazow; i++)
            {
                Krok_działania_programu(i);
                blokada_dzialania_krokowego = true; // uruchamiając cały program na raz nie można korzystać z pracy krokowej (należy uprzednio wyczyścić zmienne przyciskiem "wyczyść")
                
                if (blad == true) // obsługa błędu
                {
                    Czyszczenie_bez_usuwania_kodu();
                    MessageBox.Show("Błąd");
                    break;
                }
            }
        }

        // WYKONYWANIE JEDNEGO KROKU PROGRAMU
        private void button_krokowo_Click(object sender, EventArgs e)
        { 
            if (blokada_dzialania_krokowego == false && licznik_krokow_i < il_rozkazow)
            {
                Krok_działania_programu(licznik_krokow_i++);
                textBox2.Text = textBox2.Text + licznik_krokow_i + Environment.NewLine; // numeracja linii przy pracy krokowej
            }
            else
            {
                blokada_dzialania_krokowego = true;
            }

            if (blad == true) // obsługa błędu
            {
                Czyszczenie_bez_usuwania_kodu();
                MessageBox.Show("Błąd");
                blokada_dzialania_krokowego = true;
            }
        }

        // CZYSZCZENIE ZMIENNYCH ZACHODZUJĄC KOD PROGRAMU 
        private void button_czysc_zmienne_Click(object sender, EventArgs e)
        {
            Czyszczenie_bez_usuwania_kodu();
        }

        // RESETOWANIE CAŁOŚCI PROGRAMU
        private void button_reset_Click(object sender, EventArgs e)
        {
            Czyszczenie();
        }

        // ZAPISYWANIE DO PLIKU
        private void button_zapisz_Click(object sender, EventArgs e)
        {
            using (Stream stream = new FileStream("program.txt", FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    sw.Write(textBox1.Text);    // zapis tekstu do pliku
                    sw.Close();
                }
            }
        }

        // ODCZYTYWANIE Z PLIKU
        private void button_odczytaj_Click(object sender, EventArgs e)
        {
            Czyszczenie();
            using (Stream stream = new FileStream("program.txt", FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)  // czytanie kodu z pliku linijka po linijce
                    {
                        il_rozkazow++;
                        textBox1.Text = textBox1.Text + line + Environment.NewLine;
                    }
                }
            }
        }

        // F. WEW. WYWOŁANIE ODPOWIEDNIEJ OPERACJI
        private void Krok_działania_programu(int ktora_linia)
        {
            wyraz_linii_programu = textBox1.Lines[ktora_linia].Split(' '); // rozbijanie każdej linijki kodu na słowa

            if (wyraz_linii_programu[0] == "ADD")   // na podstawie pierwszego słowa dokonywany jest wybór operacji
            {
                ADD_function();
            }
            if (wyraz_linii_programu[0] == "SUB")
            {
                SUB_function();
            }
            if (wyraz_linii_programu[0] == "MOV")
            {
                MOV_function();
            }
            Odswiez();
        }

        // F. WEW. OPERACJA ADD (DODAWANIE)
        private void ADD_function()
        {
            Pobieranie_temp_i();    // pobieranie danej wskazanej w trzecim ComboBoxie
            Sumowanie();            // dodawanie temp_i do rejestru wskazanego w drugim ComboBoxie
            
            if (temp_i < 0 || A_i < 0 || A_i >= Math.Pow(2,16) || B_i < 0 || B_i >= Math.Pow(2, 16) || C_i < 0 || C_i >= Math.Pow(2, 16) || D_i < 0 || D_i >= Math.Pow(2, 16))
            {
                blad = true;    // jeśli wynik operacji daje ujemną wartość rejestru lub dana z trzeciego ComboBoxa jest ujemna -> oflagowuję błąd
            }
        }

        // F. WEW. OPERACJA (ODEJMOWANIE)
        private void SUB_function()
        {
            Pobieranie_temp_i();
            temp_i = temp_i * (-1);
            Sumowanie();

            if (temp_i > 0 || A_i < 0 || A_i >= Math.Pow(2, 16) || B_i < 0 || B_i >= Math.Pow(2, 16) || C_i < 0 || C_i >= Math.Pow(2, 16) || D_i < 0 || D_i >= Math.Pow(2, 16))
            {
                blad = true;    // jeśli wynik operacji daje ujemną wartość rejestru lub dana z trzeciego ComboBoxa jest ujemna -> oflagowuję błąd
            }
        }

        // F. WEW. OPERACJA (PRZESUWANIA)
        private void MOV_function()
        {
            Pobieranie_temp_i();
            Przenoszenie();

            if (temp_i < 0 || A_i < 0 || B_i < 0 || C_i < 0 || D_i < 0)
            {
                blad = true;    // jeśli wynik operacji daje ujemną wartość rejestru lub dana z trzeciego ComboBoxa jest ujemna -> oflagowuję błąd
            }
        }

        // F. WEW. ODCZYTANIE DANEJ Z 3 COMBOBOXA
        private void Pobieranie_temp_i()
        {
            if (wyraz_linii_programu[2] == "AH")
            {
                temp_i = A_i / 256;     // _H oznacza że rejest ten odpowiada za wartości x * 256 więc obliczam warotść x (A = 1024 -> AH = 4, A = 1025 -> AH = 4) 
            }
            else if (wyraz_linii_programu[2] == "BH")
            {
                temp_i = B_i / 256;
            }
            else if (wyraz_linii_programu[2] == "CH")
            {
                temp_i = C_i / 256;
            }
            else if (wyraz_linii_programu[2] == "DH")
            {
                temp_i = D_i / 256;
            }
            else if (wyraz_linii_programu[2] == "AL")
            {
                temp_i = A_i % 256;     // _L oznacza że rejest ten odpowiada za 256 * x + (0-256) więc (A = 255 -> AL = 255, A = 256 -> AL = 1)
            }
            else if (wyraz_linii_programu[2] == "BL")
            {
                temp_i = B_i % 256;
            }
            else if (wyraz_linii_programu[2] == "CL")
            {
                temp_i = C_i % 256;
            }
            else if (wyraz_linii_programu[2] == "DL")
            {
                temp_i = D_i % 256;
            }
            else if (wyraz_linii_programu[2] == "AX")
            {
                temp_i = A_i;           // AX oznacza że operuję na całej wartości rejestru
            }
            else if (wyraz_linii_programu[2] == "BX")
            {
                temp_i = B_i;
            }
            else if (wyraz_linii_programu[2] == "CX")
            {
                temp_i = C_i;
            }
            else if (wyraz_linii_programu[2] == "DX")
            {
                temp_i = D_i;
            }
            else
            {
                    temp_i = Int32.Parse(wyraz_linii_programu[2]);  // jeśli użytkownik wporwadzi liczbę
            }
        }

        // F. WEW. DZIAŁANIE FUNKCJI SUMUJĄCEJ
        private void Sumowanie()
        {
            if (wyraz_linii_programu[1] == "AH")
            {
                A_i += temp_i * 256;        // jako że chcę to dodać do bitów odpowiadających za >= 256 
            }
            else if (wyraz_linii_programu[1] == "BH")
            {
                B_i += temp_i * 256;
            }
            else if (wyraz_linii_programu[1] == "CH")
            {
                C_i += temp_i * 256;
            }
            else if (wyraz_linii_programu[1] == "DH")
            {
                D_i += temp_i * 256;
            }
            else if (wyraz_linii_programu[1] == "AL")
            {
                if ((A_i % 256 + temp_i) < 256)     // nie można przepełnić rejestru _L 
                {
                    A_i += temp_i;
                }
                blad = true;
            }
            else if (wyraz_linii_programu[1] == "BL")
            {
                if ((B_i % 256 + temp_i) < 256)
                {
                    B_i += temp_i;
                }
                blad = true;
            }
            else if (wyraz_linii_programu[1] == "CL")
            {
                if ((C_i % 256 + temp_i) < 256)
                {
                    C_i += temp_i;
                }
                blad = true;
            }
            else if (wyraz_linii_programu[1] == "DL")
            {
                if ((D_i % 256 + temp_i) < 256)
                {
                    D_i += temp_i;
                }
                blad = true;
            }
            else if (wyraz_linii_programu[1] == "AX")
            {
                A_i += temp_i;
            }
            else if (wyraz_linii_programu[1] == "BX")
            {
                B_i += temp_i;
            }
            else if (wyraz_linii_programu[1] == "CX")
            {
                C_i += temp_i;
            }
            else if (wyraz_linii_programu[1] == "DX")
            {
                D_i += temp_i;
            }
        }

        // F. WEW. DZIAŁANIE FUNCKJI PRZESUWANIA
        private void Przenoszenie()
        {
            if (wyraz_linii_programu[1] == "AH")
            {
                A_i = temp_i * 256 + A_i % 256;     // przenoszenie do _H z zachowaniem wartości w _L
            }
            else if (wyraz_linii_programu[1] == "BH")
            {
                B_i = temp_i * 256 + B_i % 256;
            }
            else if (wyraz_linii_programu[1] == "CH")
            {
                C_i = temp_i * 256 + C_i % 256;
            }
            else if (wyraz_linii_programu[1] == "DH")
            {
                D_i = temp_i * 256 + D_i % 256;
            }
            else if (wyraz_linii_programu[1] == "AL")
            {
                A_i = temp_i + A_i / 256;           // przenoszenie do _L z zachowaniem wartości _H
            }
            else if (wyraz_linii_programu[1] == "BL")
            {
                B_i = temp_i + B_i / 256;
            }
            else if (wyraz_linii_programu[1] == "CL")
            {
                C_i = temp_i + C_i / 256;
            }
            else if (wyraz_linii_programu[1] == "DL")
            {
                D_i = temp_i + D_i / 256;
            }
            else if (wyraz_linii_programu[1] == "AX")
            {
                A_i = temp_i;
            }
            else if (wyraz_linii_programu[1] == "BX")
            {
                B_i = temp_i;
            }
            else if (wyraz_linii_programu[1] == "CX")
            {
                C_i = temp_i;
            }
            else if (wyraz_linii_programu[1] == "DX")
            {
                D_i = temp_i;
            }
        }

        // F. WEW. CZYSZCZENIE - RESETOWANIE PROGRAMU
        private void Czyszczenie()
        {
            button_krokowo.BackColor = Color.White;
            il_rozkazow = 0;
            licznik_krokow_i = 0;
            A_i = 0;
            B_i = 0;
            C_i = 0;
            D_i = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            blad = false;
            blokada_dzialania_krokowego = false;
            Odswiez();
        }

        // F. WEW. CZYSZCZENIE DANYCH, ZOSTAWIAJĄC KOD PROGRAMU
        private void Czyszczenie_bez_usuwania_kodu()
        {
            button_krokowo.BackColor = Color.White;
            licznik_krokow_i = 0;
            A_i = 0;
            B_i = 0;
            C_i = 0;
            D_i = 0;
            textBox2.Text = "";
            blad = false;
            blokada_dzialania_krokowego = false;
            Odswiez();
        }

        // F. WEW. WYPEŁNIANIE REJESTRÓW
        private void Odswiez()
        {
            label_ax_dec.Text = A_i.ToString(); // wyświeltanie wartości dziesiętnej rejestrów
            label_bx_dec.Text = B_i.ToString();
            label_cx_dec.Text = C_i.ToString();
            label_dx_dec.Text = D_i.ToString();

            bajty = BitConverter.GetBytes(A_i); // zamiaina rejestru A na na 32 elementowy ciąg bitowy
            druga_tablica = bajty[0];           // wartości 2^0 - 2^7  zapisane bitowo
            pierwsza_tablica = bajty[1];        // wartości 2^8 - 2^15 zapisane bitowo

            label_ah_bin.Text = Convert.ToString(pierwsza_tablica, 2).PadLeft(8, '0');  // wyświetlanie AH
            label_al_bin.Text = Convert.ToString(druga_tablica, 2).PadLeft(8, '0');     // wyświetlanie AL

            bajty = BitConverter.GetBytes(B_i);
            druga_tablica = bajty[0];
            pierwsza_tablica = bajty[1];

            label_bh_bin.Text = Convert.ToString(pierwsza_tablica, 2).PadLeft(8, '0');
            label_bl_bin.Text = Convert.ToString(druga_tablica, 2).PadLeft(8, '0');

            bajty = BitConverter.GetBytes(C_i);
            druga_tablica = bajty[0];
            pierwsza_tablica = bajty[1];

            label_ch_bin.Text = Convert.ToString(pierwsza_tablica, 2).PadLeft(8, '0');
            label_cl_bin.Text = Convert.ToString(druga_tablica, 2).PadLeft(8, '0');

            bajty = BitConverter.GetBytes(D_i);
            druga_tablica = bajty[0];
            pierwsza_tablica = bajty[1];

            label_dh_bin.Text = Convert.ToString(pierwsza_tablica, 2).PadLeft(8, '0');
            label_dl_bin.Text = Convert.ToString(druga_tablica, 2).PadLeft(8, '0');
        }
    }
}
