using System.Drawing;

namespace zadanie_1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.

        FormLegenda Legenda;

        private float liczba_wprowadzana_f;
        private float liczba_akumulowana_f;
        private string liczba_wprowadzana_s;
        private string operacja;
        private string anal_cyfr;
        private string zero_num_s;
        private string zero_num_m;
        private string zero_num_h;

        Bitmap bmp;
        Graphics g;
        int WIDTH, HEIGHT, secHAND, minHAND, hrHAND;
        int cx, cy; //center

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
            this.but_nr1 = new System.Windows.Forms.Button();
            this.but_nr2 = new System.Windows.Forms.Button();
            this.but_nr3 = new System.Windows.Forms.Button();
            this.but_nr4 = new System.Windows.Forms.Button();
            this.but_nr5 = new System.Windows.Forms.Button();
            this.but_nr6 = new System.Windows.Forms.Button();
            this.but_nr7 = new System.Windows.Forms.Button();
            this.but_nr8 = new System.Windows.Forms.Button();
            this.but_nr9 = new System.Windows.Forms.Button();
            this.but_nr0 = new System.Windows.Forms.Button();
            this.but_dot = new System.Windows.Forms.Button();
            this.but_equal = new System.Windows.Forms.Button();
            this.but_plus = new System.Windows.Forms.Button();
            this.but_minus = new System.Windows.Forms.Button();
            this.but_multiply = new System.Windows.Forms.Button();
            this.but_divide = new System.Windows.Forms.Button();
            this.but_clear_last = new System.Windows.Forms.Button();
            this.but_clear_all = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wybórTłaKalkulatoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koloryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niebieskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoltyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.białyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zachódSłońcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podstawowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analogowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyfrowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niebieskieTłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CzerwonaCzcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podstawowyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.but_potega = new System.Windows.Forms.Button();
            this.but_pierwiastek = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zegar_cyfrowy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_nr1
            // 
            this.but_nr1.Location = new System.Drawing.Point(120, 570);
            this.but_nr1.Name = "but_nr1";
            this.but_nr1.Size = new System.Drawing.Size(60, 60);
            this.but_nr1.TabIndex = 0;
            this.but_nr1.Text = "1";
            this.but_nr1.UseVisualStyleBackColor = true;
            this.but_nr1.Click += new System.EventHandler(this.button_Click);
            this.but_nr1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_nr2
            // 
            this.but_nr2.Location = new System.Drawing.Point(186, 570);
            this.but_nr2.Name = "but_nr2";
            this.but_nr2.Size = new System.Drawing.Size(60, 60);
            this.but_nr2.TabIndex = 1;
            this.but_nr2.Text = "2";
            this.but_nr2.UseVisualStyleBackColor = true;
            this.but_nr2.Click += new System.EventHandler(this.button_Click);
            this.but_nr2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_nr3
            // 
            this.but_nr3.Location = new System.Drawing.Point(252, 570);
            this.but_nr3.Name = "but_nr3";
            this.but_nr3.Size = new System.Drawing.Size(60, 60);
            this.but_nr3.TabIndex = 2;
            this.but_nr3.Text = "3";
            this.but_nr3.UseVisualStyleBackColor = true;
            this.but_nr3.Click += new System.EventHandler(this.button_Click);
            this.but_nr3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_nr4
            // 
            this.but_nr4.Location = new System.Drawing.Point(120, 504);
            this.but_nr4.Name = "but_nr4";
            this.but_nr4.Size = new System.Drawing.Size(60, 60);
            this.but_nr4.TabIndex = 3;
            this.but_nr4.Text = "4";
            this.but_nr4.UseVisualStyleBackColor = true;
            this.but_nr4.Click += new System.EventHandler(this.button_Click);
            this.but_nr4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_nr5
            // 
            this.but_nr5.Location = new System.Drawing.Point(186, 504);
            this.but_nr5.Name = "but_nr5";
            this.but_nr5.Size = new System.Drawing.Size(60, 60);
            this.but_nr5.TabIndex = 4;
            this.but_nr5.Text = "5";
            this.but_nr5.UseVisualStyleBackColor = true;
            this.but_nr5.Click += new System.EventHandler(this.button_Click);
            this.but_nr5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_nr6
            // 
            this.but_nr6.Location = new System.Drawing.Point(252, 504);
            this.but_nr6.Name = "but_nr6";
            this.but_nr6.Size = new System.Drawing.Size(60, 60);
            this.but_nr6.TabIndex = 5;
            this.but_nr6.Text = "6";
            this.but_nr6.UseVisualStyleBackColor = true;
            this.but_nr6.Click += new System.EventHandler(this.button_Click);
            this.but_nr6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_nr7
            // 
            this.but_nr7.Location = new System.Drawing.Point(120, 438);
            this.but_nr7.Name = "but_nr7";
            this.but_nr7.Size = new System.Drawing.Size(60, 60);
            this.but_nr7.TabIndex = 6;
            this.but_nr7.Text = "7";
            this.but_nr7.UseVisualStyleBackColor = true;
            this.but_nr7.Click += new System.EventHandler(this.button_Click);
            this.but_nr7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_nr8
            // 
            this.but_nr8.Location = new System.Drawing.Point(186, 438);
            this.but_nr8.Name = "but_nr8";
            this.but_nr8.Size = new System.Drawing.Size(60, 60);
            this.but_nr8.TabIndex = 7;
            this.but_nr8.Text = "8";
            this.but_nr8.UseVisualStyleBackColor = true;
            this.but_nr8.Click += new System.EventHandler(this.button_Click);
            this.but_nr8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_nr9
            // 
            this.but_nr9.Location = new System.Drawing.Point(252, 438);
            this.but_nr9.Name = "but_nr9";
            this.but_nr9.Size = new System.Drawing.Size(60, 60);
            this.but_nr9.TabIndex = 8;
            this.but_nr9.Text = "9";
            this.but_nr9.UseVisualStyleBackColor = true;
            this.but_nr9.Click += new System.EventHandler(this.button_Click);
            this.but_nr9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_nr0
            // 
            this.but_nr0.Location = new System.Drawing.Point(120, 636);
            this.but_nr0.Name = "but_nr0";
            this.but_nr0.Size = new System.Drawing.Size(126, 60);
            this.but_nr0.TabIndex = 9;
            this.but_nr0.Text = "0";
            this.but_nr0.UseVisualStyleBackColor = true;
            this.but_nr0.Click += new System.EventHandler(this.button_Click);
            this.but_nr0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_dot
            // 
            this.but_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.but_dot.Location = new System.Drawing.Point(252, 636);
            this.but_dot.Name = "but_dot";
            this.but_dot.Size = new System.Drawing.Size(60, 60);
            this.but_dot.TabIndex = 10;
            this.but_dot.Text = ",";
            this.but_dot.UseVisualStyleBackColor = true;
            this.but_dot.Click += new System.EventHandler(this.button_Click);
            this.but_dot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_equal
            // 
            this.but_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.but_equal.Location = new System.Drawing.Point(318, 570);
            this.but_equal.Name = "but_equal";
            this.but_equal.Size = new System.Drawing.Size(60, 126);
            this.but_equal.TabIndex = 11;
            this.but_equal.Text = "=";
            this.but_equal.UseVisualStyleBackColor = true;
            this.but_equal.Click += new System.EventHandler(this.button_Click);
            this.but_equal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_plus
            // 
            this.but_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.but_plus.Location = new System.Drawing.Point(318, 438);
            this.but_plus.Name = "but_plus";
            this.but_plus.Size = new System.Drawing.Size(60, 126);
            this.but_plus.TabIndex = 12;
            this.but_plus.Text = "+";
            this.but_plus.UseVisualStyleBackColor = true;
            this.but_plus.Click += new System.EventHandler(this.button_Click);
            this.but_plus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_minus
            // 
            this.but_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.but_minus.Location = new System.Drawing.Point(318, 372);
            this.but_minus.Name = "but_minus";
            this.but_minus.Size = new System.Drawing.Size(60, 60);
            this.but_minus.TabIndex = 13;
            this.but_minus.Text = "-";
            this.but_minus.UseVisualStyleBackColor = true;
            this.but_minus.Click += new System.EventHandler(this.button_Click);
            this.but_minus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_multiply
            // 
            this.but_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.but_multiply.Location = new System.Drawing.Point(252, 372);
            this.but_multiply.Name = "but_multiply";
            this.but_multiply.Size = new System.Drawing.Size(60, 60);
            this.but_multiply.TabIndex = 14;
            this.but_multiply.Text = "*";
            this.but_multiply.UseVisualStyleBackColor = true;
            this.but_multiply.Click += new System.EventHandler(this.button_Click);
            this.but_multiply.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_divide
            // 
            this.but_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.but_divide.Location = new System.Drawing.Point(186, 372);
            this.but_divide.Name = "but_divide";
            this.but_divide.Size = new System.Drawing.Size(60, 60);
            this.but_divide.TabIndex = 15;
            this.but_divide.Text = "/";
            this.but_divide.UseVisualStyleBackColor = true;
            this.but_divide.Click += new System.EventHandler(this.button_Click);
            this.but_divide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_clear_last
            // 
            this.but_clear_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.but_clear_last.Location = new System.Drawing.Point(120, 372);
            this.but_clear_last.Name = "but_clear_last";
            this.but_clear_last.Size = new System.Drawing.Size(60, 60);
            this.but_clear_last.TabIndex = 16;
            this.but_clear_last.Text = "CE";
            this.but_clear_last.UseVisualStyleBackColor = true;
            this.but_clear_last.Click += new System.EventHandler(this.button_Click);
            this.but_clear_last.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_clear_all
            // 
            this.but_clear_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.but_clear_all.Location = new System.Drawing.Point(120, 306);
            this.but_clear_all.Name = "but_clear_all";
            this.but_clear_all.Size = new System.Drawing.Size(126, 60);
            this.but_clear_all.TabIndex = 17;
            this.but_clear_all.Text = "C";
            this.but_clear_all.UseVisualStyleBackColor = true;
            this.but_clear_all.Click += new System.EventHandler(this.button_Click);
            this.but_clear_all.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytujToolStripMenuItem,
            this.legendaToolStripMenuItem,
            this.autorzyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wybórTłaKalkulatoraToolStripMenuItem,
            this.zegarToolStripMenuItem});
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            // 
            // wybórTłaKalkulatoraToolStripMenuItem
            // 
            this.wybórTłaKalkulatoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.koloryToolStripMenuItem,
            this.zachódSłońcaToolStripMenuItem,
            this.podstawowyToolStripMenuItem});
            this.wybórTłaKalkulatoraToolStripMenuItem.Name = "wybórTłaKalkulatoraToolStripMenuItem";
            this.wybórTłaKalkulatoraToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.wybórTłaKalkulatoraToolStripMenuItem.Text = "Wybór tła kalkulatora";
            // 
            // koloryToolStripMenuItem
            // 
            this.koloryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.niebieskiToolStripMenuItem,
            this.zoltyToolStripMenuItem,
            this.szaryToolStripMenuItem,
            this.białyToolStripMenuItem});
            this.koloryToolStripMenuItem.Name = "koloryToolStripMenuItem";
            this.koloryToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.koloryToolStripMenuItem.Text = "Kolory";
            // 
            // niebieskiToolStripMenuItem
            // 
            this.niebieskiToolStripMenuItem.Name = "niebieskiToolStripMenuItem";
            this.niebieskiToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.niebieskiToolStripMenuItem.Text = "Niebieski";
            this.niebieskiToolStripMenuItem.Click += new System.EventHandler(this.niebieskiToolStripMenuItem_Click);
            // 
            // zoltyToolStripMenuItem
            // 
            this.zoltyToolStripMenuItem.Name = "zoltyToolStripMenuItem";
            this.zoltyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.zoltyToolStripMenuItem.Text = "Żółty";
            this.zoltyToolStripMenuItem.Click += new System.EventHandler(this.zoltyToolStripMenuItem_Click);
            // 
            // szaryToolStripMenuItem
            // 
            this.szaryToolStripMenuItem.Name = "szaryToolStripMenuItem";
            this.szaryToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.szaryToolStripMenuItem.Text = "Szary";
            this.szaryToolStripMenuItem.Click += new System.EventHandler(this.szaryToolStripMenuItem_Click);
            // 
            // białyToolStripMenuItem
            // 
            this.białyToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.białyToolStripMenuItem.Name = "białyToolStripMenuItem";
            this.białyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.białyToolStripMenuItem.Text = "Biały";
            this.białyToolStripMenuItem.Click += new System.EventHandler(this.białyToolStripMenuItem_Click);
            // 
            // zachódSłońcaToolStripMenuItem
            // 
            this.zachódSłońcaToolStripMenuItem.Name = "zachódSłońcaToolStripMenuItem";
            this.zachódSłońcaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.zachódSłońcaToolStripMenuItem.Text = "Zachód słońca";
            this.zachódSłońcaToolStripMenuItem.Click += new System.EventHandler(this.zachódSłońcaToolStripMenuItem_Click);
            // 
            // podstawowyToolStripMenuItem
            // 
            this.podstawowyToolStripMenuItem.Name = "podstawowyToolStripMenuItem";
            this.podstawowyToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.podstawowyToolStripMenuItem.Text = "Podstawowy";
            this.podstawowyToolStripMenuItem.Click += new System.EventHandler(this.podstawowyToolStripMenuItem_Click);
            // 
            // zegarToolStripMenuItem
            // 
            this.zegarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analogowyToolStripMenuItem,
            this.cyfrowyToolStripMenuItem,
            this.brakToolStripMenuItem});
            this.zegarToolStripMenuItem.Name = "zegarToolStripMenuItem";
            this.zegarToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.zegarToolStripMenuItem.Text = "Zegar";
            // 
            // analogowyToolStripMenuItem
            // 
            this.analogowyToolStripMenuItem.Name = "analogowyToolStripMenuItem";
            this.analogowyToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.analogowyToolStripMenuItem.Text = "Analogowy";
            this.analogowyToolStripMenuItem.Click += new System.EventHandler(this.analogowyToolStripMenuItem_Click);
            // 
            // cyfrowyToolStripMenuItem
            // 
            this.cyfrowyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.niebieskieTłoToolStripMenuItem,
            this.CzerwonaCzcionkaToolStripMenuItem,
            this.podstawowyToolStripMenuItem1});
            this.cyfrowyToolStripMenuItem.Name = "cyfrowyToolStripMenuItem";
            this.cyfrowyToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.cyfrowyToolStripMenuItem.Text = "Cyfrowy";
            this.cyfrowyToolStripMenuItem.Click += new System.EventHandler(this.cyfrowyToolStripMenuItem_Click);
            // 
            // niebieskieTłoToolStripMenuItem
            // 
            this.niebieskieTłoToolStripMenuItem.Name = "niebieskieTłoToolStripMenuItem";
            this.niebieskieTłoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.niebieskieTłoToolStripMenuItem.Text = "Niebieskie tło";
            this.niebieskieTłoToolStripMenuItem.Click += new System.EventHandler(this.niebieskieTłoToolStripMenuItem_Click);
            // 
            // CzerwonaCzcionkaToolStripMenuItem
            // 
            this.CzerwonaCzcionkaToolStripMenuItem.Name = "CzerwonaCzcionkaToolStripMenuItem";
            this.CzerwonaCzcionkaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.CzerwonaCzcionkaToolStripMenuItem.Text = "Czerwona czcionka";
            this.CzerwonaCzcionkaToolStripMenuItem.Click += new System.EventHandler(this.żółtaCzcionkaToolStripMenuItem_Click);
            // 
            // podstawowyToolStripMenuItem1
            // 
            this.podstawowyToolStripMenuItem1.Name = "podstawowyToolStripMenuItem1";
            this.podstawowyToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.podstawowyToolStripMenuItem1.Text = "Podstawowy";
            this.podstawowyToolStripMenuItem1.Click += new System.EventHandler(this.podstawowyToolStripMenuItem1_Click);
            // 
            // brakToolStripMenuItem
            // 
            this.brakToolStripMenuItem.Name = "brakToolStripMenuItem";
            this.brakToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.brakToolStripMenuItem.Text = "Brak";
            this.brakToolStripMenuItem.Click += new System.EventHandler(this.brakToolStripMenuItem_Click);
            // 
            // legendaToolStripMenuItem
            // 
            this.legendaToolStripMenuItem.Name = "legendaToolStripMenuItem";
            this.legendaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.legendaToolStripMenuItem.Text = "Legenda";
            this.legendaToolStripMenuItem.Click += new System.EventHandler(this.legendaToolStripMenuItem_Click);
            // 
            // autorzyToolStripMenuItem
            // 
            this.autorzyToolStripMenuItem.Name = "autorzyToolStripMenuItem";
            this.autorzyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.autorzyToolStripMenuItem.Text = "Autorzy";
            this.autorzyToolStripMenuItem.Click += new System.EventHandler(this.autorzyToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // but_potega
            // 
            this.but_potega.Location = new System.Drawing.Point(252, 306);
            this.but_potega.Name = "but_potega";
            this.but_potega.Size = new System.Drawing.Size(126, 26);
            this.but_potega.TabIndex = 21;
            this.but_potega.Text = "x^2";
            this.but_potega.UseVisualStyleBackColor = true;
            this.but_potega.Click += new System.EventHandler(this.button_Click);
            this.but_potega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // but_pierwiastek
            // 
            this.but_pierwiastek.Location = new System.Drawing.Point(252, 338);
            this.but_pierwiastek.Name = "but_pierwiastek";
            this.but_pierwiastek.Size = new System.Drawing.Size(126, 26);
            this.but_pierwiastek.TabIndex = 22;
            this.but_pierwiastek.Text = "pierwiastek";
            this.but_pierwiastek.UseVisualStyleBackColor = true;
            this.but_pierwiastek.Click += new System.EventHandler(this.button_Click);
            this.but_pierwiastek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zegar_cyfrowy
            // 
            this.zegar_cyfrowy.AutoSize = true;
            this.zegar_cyfrowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.zegar_cyfrowy.Location = new System.Drawing.Point(111, 100);
            this.zegar_cyfrowy.Name = "zegar_cyfrowy";
            this.zegar_cyfrowy.Size = new System.Drawing.Size(0, 54);
            this.zegar_cyfrowy.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(134, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox1.Location = new System.Drawing.Point(134, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 31);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 723);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.zegar_cyfrowy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but_pierwiastek);
            this.Controls.Add(this.but_potega);
            this.Controls.Add(this.but_clear_all);
            this.Controls.Add(this.but_clear_last);
            this.Controls.Add(this.but_divide);
            this.Controls.Add(this.but_multiply);
            this.Controls.Add(this.but_minus);
            this.Controls.Add(this.but_plus);
            this.Controls.Add(this.but_equal);
            this.Controls.Add(this.but_dot);
            this.Controls.Add(this.but_nr0);
            this.Controls.Add(this.but_nr9);
            this.Controls.Add(this.but_nr8);
            this.Controls.Add(this.but_nr7);
            this.Controls.Add(this.but_nr6);
            this.Controls.Add(this.but_nr5);
            this.Controls.Add(this.but_nr4);
            this.Controls.Add(this.but_nr3);
            this.Controls.Add(this.but_nr2);
            this.Controls.Add(this.but_nr1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_nr1;
        private System.Windows.Forms.Button but_nr2;
        private System.Windows.Forms.Button but_nr3;
        private System.Windows.Forms.Button but_nr4;
        private System.Windows.Forms.Button but_nr5;
        private System.Windows.Forms.Button but_nr6;
        private System.Windows.Forms.Button but_nr7;
        private System.Windows.Forms.Button but_nr8;
        private System.Windows.Forms.Button but_nr9;
        private System.Windows.Forms.Button but_nr0;
        private System.Windows.Forms.Button but_dot;
        private System.Windows.Forms.Button but_equal;
        private System.Windows.Forms.Button but_plus;
        private System.Windows.Forms.Button but_minus;
        private System.Windows.Forms.Button but_multiply;
        private System.Windows.Forms.Button but_divide;
        private System.Windows.Forms.Button but_clear_last;
        private System.Windows.Forms.Button but_clear_all;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wybórTłaKalkulatoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koloryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niebieskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoltyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szaryToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem białyToolStripMenuItem;
        private System.Windows.Forms.Button but_potega;
        private System.Windows.Forms.Button but_pierwiastek;
        private System.Windows.Forms.ToolStripMenuItem zachódSłońcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podstawowyToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem zegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analogowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyfrowyToolStripMenuItem;
        private System.Windows.Forms.Label zegar_cyfrowy;
        private System.Windows.Forms.ToolStripMenuItem niebieskieTłoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CzerwonaCzcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podstawowyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorzyToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

