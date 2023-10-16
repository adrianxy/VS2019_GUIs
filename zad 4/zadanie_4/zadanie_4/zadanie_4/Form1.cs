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
    public partial class Form1 : Form
    {
        // import danych z innych okien przez label3
        public static Form1 instance;
        public Label czy_kliknieto;
        public Form1()
        {
            InitializeComponent();
            // import danych z innych okien
            instance = this;
            czy_kliknieto = label3;
        }

        private void zaloguj_b_Click(object sender, EventArgs e)
        {
            czy_kliknieto.Text = "tak";
            // Sprawdzenie czy login i hasło są poprawne
            if (login_tb.Text == login_s && haslo_tb.Text == haslo_s)
            {
                // Jeśli są, otwieramy nowe okno
                if (okno2 == null)
                okno2= new Form2();
                okno2.Show();

                // Ukrywamy okno logowania
                this.Hide();

                login_tb.Text = "";
                haslo_tb.Text = "";

                timer1.Enabled = true;
            }
            else
            {
                // Jeśli nie są, wyświetlamy komunikat o błędnych danych logowania
                MessageBox.Show("Nieprawidłowy login lub hasło.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Czyszczenie pól tekstowych
                login_tb.Text = "";
                haslo_tb.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (czy_kliknieto.Text == "nie") 
            {
                czas_i++;
            }
            else if(czy_kliknieto.Text == "tak")
            {
                czas_i = 0;
            }

            if (czas_i == 10)
            {
                MessageBox.Show("Jesteś?");
            }
            if (czas_i >= 20) 
            {
                var formsToClose = Application.OpenForms.Cast<Form>().ToList();

                foreach (Form form in formsToClose) // iterujemy po kopii listy formularzy
                {
                    if(form != this)
                    form.Hide(); // zamykamy każdy formularz
                }
                if (this != null)
                this.Show();
                czas_i = 0;
            }
            czy_kliknieto.Text = "nie";
        }
    }
}
