using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace zadanie_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pozycja_czytnika_i = 0;
            wyswietl_O = 0;
        }

        private void textBox_N_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // PRZESZUKIWANIE SŁOWNIKA I CENZUROWANIE TYCH SŁÓW
                temp_s = "";
                tekst_nad_s = textBox_N.Text;
                foreach (string line in File.ReadLines("Grubianstwa.txt"))
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        temp_s += '*'.ToString();
                    }
                    tekst_nad_s = tekst_nad_s.Replace(line, temp_s, StringComparison.CurrentCultureIgnoreCase);
                    temp_s = "";
                }
            }
            catch
            {
                MessageBox.Show("Brak pliku Grubianstwa.txt");
            }
        }

        private void b_konwersja_Click(object sender, EventArgs e)
        {
            try
            {
                tekst_nad_byte = Encoding.ASCII.GetBytes(tekst_nad_s);         // zamiana liter tekstu na reprezentację liczbową w postaci bajtu (256 różnych liczb)
                tekst_nad_bitArray = new BitArray(tekst_nad_byte);                  // zamiana bajtu w ciąg 8 bitów, 

                // KODOWANIE ZNAKÓW W POSTACI BITOWEJ (1bitStartu_8bitówSymbolu_2bityKońca)
                n = 0;      // licznik bajtów
                for (int i = 0; i < tekst_nad_byte.Length; i++)
                {
                    tekst_nad_bin_s = tekst_nad_bin_s + "1";                // dodanie bit satrtu
                                                                            // dodanie 8 bitów reprezentujących symbol, ascii_bit[0] - najmniej znaczący bit, dlatego jest wprowadzanie bitów od [7] do [0]
                    for (int j = 7; j >= 0; j--)
                    {
                        if (tekst_nad_bitArray[j + 8 * n].ToString() == "False")
                        {
                            tekst_nad_bin_s = tekst_nad_bin_s + "0";
                        }
                        else
                        {
                            tekst_nad_bin_s = tekst_nad_bin_s + "1";
                        }
                    }
                    tekst_nad_bin_s = tekst_nad_bin_s + "11";                   // dodanie bit stopu
                    n++;
                }
                //ZAPISANIE CIĄGU ZAKODOWANYCH BITÓW ZNAKÓW DO PLIKU (CAŁY ZAKODOWANY TEKST NA RAZ)
                File.WriteAllText("ASCII_N.txt", tekst_nad_bin_s);
                tekst_nad_bin_s = "";
            }
            catch
            {
                MessageBox.Show("najpierw wprowadź tekst");
            }
        }

        private void b_wyswietl_N_Click(object sender, EventArgs e)
        {
            // WPROWADZANIE ZNAKÓW W POSTACI BITOWEJ (8bitówSymbolu)
            try
            {
                if (tekst_nad_byte != null)
                {
                    n = 0;
                    for (int i = 0; i < tekst_nad_byte.Length; i++)
                    {
                        // dodanie 8 bitów reprezentujących symbol, ascii_bit[0] - najmniej znaczący bit, dlatego jest wprowadzanie bitów od [7] do [0]
                        for (int j = 7; j >= 0; j--)
                        {
                            if (tekst_nad_bitArray[j + 8 * n].ToString() == "False")
                            {
                                tekst_nad_bin_s = tekst_nad_bin_s + "0";
                            }
                            else
                            {
                                tekst_nad_bin_s = tekst_nad_bin_s + "1";
                            }
                        }
                        n++;
                    }
                    // WYŚWIETLENIE BITÓW ZNAKU (NIEZAKODOWANYCH)
                    MessageBox.Show(tekst_nad_bin_s);
                    tekst_nad_bin_s = "";
                }
            }
            catch
            {
                MessageBox.Show("Błąd");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // PRZEPISYWANIE KOLEJNYCH PO SOBIE BITÓW DANYCH W PLIKU NADAWCY Z PLIKU NADAWCY DO ODBIORCY
            przepisywanie_kolejnych_po_sobie_bitow_danych_w_pliku_nadawcy_z_pliku_nadawcy_do_odbiorcy();
            
            // Wyświetlanie tekstu w oknie odbiorcy
            if (wyswietl_O == 1)
            {
                wyświetlanie_tekstu_w_oknie_odbiorcy();
            }
        }

        private void b_wyslij_Click(object sender, EventArgs e)
        {
            wyswietl_O = 0;
            pozycja_czytnika_i = 0;
            File.WriteAllText("ASCII_O.txt", "");
            // ROZPOCZYNA PROCEDURĘ WYSYŁANIA BIT PO BICIE DO ODBIORCY
            timer1.Enabled = true;
        }

        private void b_wyswietl_O_Click(object sender, EventArgs e)
        {
            wyswietl_O = 1;
        }

        // AUTORZY
        private void autorzyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adrian Nowogrodzki 184332 \nOskar Nowak 184289");
        }

        // WYŚWIETLANIE OKIENKA ZE SŁOWAMI ZAKAZANYMI
        private void słownikGrubiaństwToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Slownik_grubianstw = new Form2();
            this.Slownik_grubianstw.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // WYCZYŚĆ DANE PLIKÓW TEKSTOWYCH
            File.WriteAllText("ASCII_N.txt", "");
            File.WriteAllText("ASCII_O.txt", "");
        }

        // PRZEPISYWANIE KOLEJNYCH PO SOBIE BITÓW DANYCH W PLIKU NADAWCY Z PLIKU NADAWCY DO ODBIORCY
        private void przepisywanie_kolejnych_po_sobie_bitow_danych_w_pliku_nadawcy_z_pliku_nadawcy_do_odbiorcy()
        {
            using (FileStream fs = new FileStream(@"ASCII_N.txt", FileMode.Open, FileAccess.Read))
            {
                fs.Position = pozycja_czytnika_i;       // ustawianie pozyji czytnika
                if (fs.Position < 11 * n)
                {
                    fs.Read(znak_odb_byte, pozycja_czytnika_i, 1);  // w pliku tekstowym jest tekst zapisany binarnie (0,1), tu następuje czytanie do wektora b [temp_i] jednego znaku(0,1), ale b przyjmuje wartość dziesiętną tego symbolu  ((char)0->(int)48 | 1->49)

                    znak_odb_c = Convert.ToChar(znak_odb_byte[pozycja_czytnika_i]); // zamiana tego znaku zapisanego w incie na symbol ((int)48->(char)0 | 49->1)

                    if (pozycja_czytnika_i == 0)
                    {
                        File.WriteAllText("ASCII_O.txt", "");   // czyszczenie pliku odbiorcy jeśli pierwszy symbol
                    }
                    // ZAPIS BITU DO PLIKU ODBIORCY
                    using (FileStream sb = new FileStream("ASCII_O.txt", FileMode.Open, FileAccess.Write))
                    {
                        StreamWriter sw = new StreamWriter(sb);
                        sb.Position = pozycja_czytnika_i;
                        sw.Write(znak_odb_c);
                        sw.Close();
                    }
                }
            }
            pozycja_czytnika_i++;
        }


        // Wyświetlanie tekstu w oknie odbiorcy
        private void wyświetlanie_tekstu_w_oknie_odbiorcy()
        {
            tekst_odb_s0 = File.ReadAllText("ASCII_O.txt");       // odczytanie kodu binarnego z pliku odbiorcy
            Array.Clear(tekst_odb_s1, 0, tekst_odb_s1.Length);
            ilosc_znakow_odb_i = 0;

            // JEŚLI PRZESŁANO 11 BITÓW LUB WIĘCEJ TO PRZYSTĘPUJE DO WYODRĘBNIANIA 8 BITÓW ZNAKU Z 11 ZAKODOWANYCH BITÓW
            while ((tekst_odb_s0.Length - 11 * ilosc_znakow_odb_i) >= 11)
            {
                tekst_odb_s1[ilosc_znakow_odb_i] = tekst_odb_s0.Substring(1 + 11 * ilosc_znakow_odb_i, 8);
                ilosc_znakow_odb_i++;
            }
            // ZAMIANA CIĄGU BITÓW W SYMBOLE I ŁĄCZENIE ICH W TEKST ODBIORCY
            tekst_odb_s2 = string.Join("", tekst_odb_s1);
            tekst_odb_s = "";
            while (tekst_odb_s2.Length > 0)
            {
                first8 = tekst_odb_s2.Substring(0, 8);
                tekst_odb_s2 = tekst_odb_s2.Substring(8);
                number = Convert.ToInt32(first8, 2);
                tekst_odb_s += (char)number;
            }
            textBox_O.Text = tekst_odb_s;    // wyświetlanie tekstu
        }
    }
}

// METODA DO PORÓWANANIA NIE UWZGLĘDNIAJĄCA WIELKOŚCI LITER
public static class ExtensionMethodsString
{
    public static string Replace(this String thisString, string oldValue, string newValue, StringComparison stringComparison)
    {
        string working = thisString;
        int index = working.IndexOf(oldValue, stringComparison);
        while (index != -1)
        {
            working = working.Remove(index, oldValue.Length);
            working = working.Insert(index, newValue);
            index = index + newValue.Length;
            index = working.IndexOf(oldValue, index, stringComparison);
        }
        return working;
    }
}

