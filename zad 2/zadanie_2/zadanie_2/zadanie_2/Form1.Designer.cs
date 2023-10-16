using System.Collections;
using System.IO;

namespace zadanie_2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        Form2 Slownik_grubianstw; 
        string tekst_nad_s;
        string tekst_nad_bin_s;
        byte[] tekst_nad_byte;
        BitArray tekst_nad_bitArray;
        int n;
        char znak_odb_c;
        int pozycja_czytnika_i;
        string temp_s;
        byte[] znak_odb_byte = new byte[1100];
        int wyswietl_O;
        string tekst_odb_s0;
        string[] tekst_odb_s1 = new string[100];
        int ilosc_znakow_odb_i;
        string tekst_odb_s2;
        string tekst_odb_s;
        string first8;
        int number;
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b_konwersja = new System.Windows.Forms.Button();
            this.b_wyswietl_N = new System.Windows.Forms.Button();
            this.b_wyslij = new System.Windows.Forms.Button();
            this.b_wyswietl_O = new System.Windows.Forms.Button();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.textBox_O = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.autorzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.słownikGrubiaństwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_konwersja
            // 
            this.b_konwersja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_konwersja.Location = new System.Drawing.Point(73, 176);
            this.b_konwersja.Name = "b_konwersja";
            this.b_konwersja.Size = new System.Drawing.Size(294, 57);
            this.b_konwersja.TabIndex = 0;
            this.b_konwersja.Text = "skonwertuj tekst na ciąg bitów w kodzie ASCII";
            this.b_konwersja.UseVisualStyleBackColor = true;
            this.b_konwersja.Click += new System.EventHandler(this.b_konwersja_Click);
            // 
            // b_wyswietl_N
            // 
            this.b_wyswietl_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.b_wyswietl_N.Location = new System.Drawing.Point(73, 357);
            this.b_wyswietl_N.Name = "b_wyswietl_N";
            this.b_wyswietl_N.Size = new System.Drawing.Size(294, 57);
            this.b_wyswietl_N.TabIndex = 1;
            this.b_wyswietl_N.Text = "wyświetl ciąg znaków ASCII";
            this.b_wyswietl_N.UseVisualStyleBackColor = true;
            this.b_wyswietl_N.Click += new System.EventHandler(this.b_wyswietl_N_Click);
            // 
            // b_wyslij
            // 
            this.b_wyslij.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_wyslij.Location = new System.Drawing.Point(73, 239);
            this.b_wyslij.Name = "b_wyslij";
            this.b_wyslij.Size = new System.Drawing.Size(294, 57);
            this.b_wyslij.TabIndex = 2;
            this.b_wyslij.Text = "wyślij kod ASCII do odbiorcy";
            this.b_wyslij.UseVisualStyleBackColor = true;
            this.b_wyslij.Click += new System.EventHandler(this.b_wyslij_Click);
            // 
            // b_wyswietl_O
            // 
            this.b_wyswietl_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_wyswietl_O.Location = new System.Drawing.Point(691, 176);
            this.b_wyswietl_O.Name = "b_wyswietl_O";
            this.b_wyswietl_O.Size = new System.Drawing.Size(294, 57);
            this.b_wyswietl_O.TabIndex = 3;
            this.b_wyswietl_O.Text = "wyświetl tekst";
            this.b_wyswietl_O.UseVisualStyleBackColor = true;
            this.b_wyswietl_O.Click += new System.EventHandler(this.b_wyswietl_O_Click);
            // 
            // textBox_N
            // 
            this.textBox_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_N.Location = new System.Drawing.Point(73, 148);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(294, 22);
            this.textBox_N.TabIndex = 4;
            this.textBox_N.TextChanged += new System.EventHandler(this.textBox_N_TextChanged);
            // 
            // textBox_O
            // 
            this.textBox_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_O.Location = new System.Drawing.Point(691, 148);
            this.textBox_O.Name = "textBox_O";
            this.textBox_O.ReadOnly = true;
            this.textBox_O.Size = new System.Drawing.Size(294, 22);
            this.textBox_O.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(68, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "nadawca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(686, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "odbiorca";
            // 
            // timer1
            // 
            this.timer1.Interval = 22;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorzyToolStripMenuItem,
            this.słownikGrubiaństwToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // autorzyToolStripMenuItem
            // 
            this.autorzyToolStripMenuItem.Name = "autorzyToolStripMenuItem";
            this.autorzyToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.autorzyToolStripMenuItem.Text = "autorzy";
            this.autorzyToolStripMenuItem.Click += new System.EventHandler(this.autorzyToolStripMenuItem_Click);
            // 
            // słownikGrubiaństwToolStripMenuItem
            // 
            this.słownikGrubiaństwToolStripMenuItem.Name = "słownikGrubiaństwToolStripMenuItem";
            this.słownikGrubiaństwToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.słownikGrubiaństwToolStripMenuItem.Text = "słownik grubiaństw";
            this.słownikGrubiaństwToolStripMenuItem.Click += new System.EventHandler(this.słownikGrubiaństwToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(441, 272);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(544, 283);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 592);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_O);
            this.Controls.Add(this.textBox_N);
            this.Controls.Add(this.b_wyswietl_O);
            this.Controls.Add(this.b_wyslij);
            this.Controls.Add(this.b_wyswietl_N);
            this.Controls.Add(this.b_konwersja);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "symulator transmisji szeregowej standardu RS232";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_konwersja;
        private System.Windows.Forms.Button b_wyswietl_N;
        private System.Windows.Forms.Button b_wyslij;
        private System.Windows.Forms.Button b_wyswietl_O;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.TextBox textBox_O;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem autorzyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem słownikGrubiaństwToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

