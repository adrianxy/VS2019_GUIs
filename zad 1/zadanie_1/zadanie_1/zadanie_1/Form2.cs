using System;
using System.Drawing;
using System.Windows.Forms;

namespace zadanie_1
{
    public partial class FormLegenda : Form
    {
        public FormLegenda()
        {
            InitializeComponent();
        }

        private void FormLegenda_Load(object sender, EventArgs e)
        {
            label1.Text = " aplikacja       klawiatura \n      =      " +
                "              'e' \n     CE                  'b' \n      C  " +
                "                  'c' \n     x^2                   'p' \npierwiastek           'q'";
            label1.Font = new Font("Arial", 10);
        }
    }
}
