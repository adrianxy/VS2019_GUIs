
namespace zadanie_5
{
    partial class form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// 
        int il_rozkazow;
        int A_i, B_i, C_i, D_i, temp_i;
        int licznik_krokow_i;
        string[] wyraz_linii_programu = new string[3];
        byte[] bajty = new byte[2];
        byte pierwsza_tablica;
        byte druga_tablica;
        bool blokada_dzialania_krokowego;
        bool blad;

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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_ax_dec = new System.Windows.Forms.Label();
            this.label_bx_dec = new System.Windows.Forms.Label();
            this.label_cx_dec = new System.Windows.Forms.Label();
            this.label_dx_dec = new System.Windows.Forms.Label();
            this.label_ah_bin = new System.Windows.Forms.Label();
            this.label_al_bin = new System.Windows.Forms.Label();
            this.label_bh_bin = new System.Windows.Forms.Label();
            this.label_bl_bin = new System.Windows.Forms.Label();
            this.label_ch_bin = new System.Windows.Forms.Label();
            this.label_cl_bin = new System.Windows.Forms.Label();
            this.label_dh_bin = new System.Windows.Forms.Label();
            this.label_dl_bin = new System.Windows.Forms.Label();
            this.button_wykonajPorgram = new System.Windows.Forms.Button();
            this.button_krokowo = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_zapisz = new System.Windows.Forms.Button();
            this.button_odczytaj = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button_czysc_zmienne = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MOV",
            "ADD",
            "SUB"});
            this.comboBox1.Location = new System.Drawing.Point(12, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Items.AddRange(new object[] {
            "AX",
            "AH",
            "AL",
            "BX",
            "BH",
            "BL",
            "CX",
            "CH",
            "CL",
            "DX",
            "DH",
            "DL"});
            this.comboBox2.Location = new System.Drawing.Point(135, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(117, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "AX",
            "AH",
            "AL",
            "BX",
            "BH",
            "BL",
            "CX",
            "CH",
            "CL",
            "DX",
            "DH",
            "DL"});
            this.comboBox3.Location = new System.Drawing.Point(258, 49);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(117, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(381, 49);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 3;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(117, 402);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(327, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "AX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(327, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "BX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(326, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "CX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.Location = new System.Drawing.Point(326, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "DX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(399, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "DEC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(574, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "BIN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label7.Location = new System.Drawing.Point(526, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "NH";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label8.Location = new System.Drawing.Point(626, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "NL";
            // 
            // label_ax_dec
            // 
            this.label_ax_dec.AutoSize = true;
            this.label_ax_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ax_dec.Location = new System.Drawing.Point(401, 172);
            this.label_ax_dec.Name = "label_ax_dec";
            this.label_ax_dec.Size = new System.Drawing.Size(15, 16);
            this.label_ax_dec.TabIndex = 13;
            this.label_ax_dec.Text = "0";
            // 
            // label_bx_dec
            // 
            this.label_bx_dec.AutoSize = true;
            this.label_bx_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_bx_dec.Location = new System.Drawing.Point(401, 230);
            this.label_bx_dec.Name = "label_bx_dec";
            this.label_bx_dec.Size = new System.Drawing.Size(15, 16);
            this.label_bx_dec.TabIndex = 14;
            this.label_bx_dec.Text = "0";
            // 
            // label_cx_dec
            // 
            this.label_cx_dec.AutoSize = true;
            this.label_cx_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cx_dec.Location = new System.Drawing.Point(401, 288);
            this.label_cx_dec.Name = "label_cx_dec";
            this.label_cx_dec.Size = new System.Drawing.Size(15, 16);
            this.label_cx_dec.TabIndex = 15;
            this.label_cx_dec.Text = "0";
            // 
            // label_dx_dec
            // 
            this.label_dx_dec.AutoSize = true;
            this.label_dx_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dx_dec.Location = new System.Drawing.Point(401, 346);
            this.label_dx_dec.Name = "label_dx_dec";
            this.label_dx_dec.Size = new System.Drawing.Size(15, 16);
            this.label_dx_dec.TabIndex = 16;
            this.label_dx_dec.Text = "0";
            // 
            // label_ah_bin
            // 
            this.label_ah_bin.AutoSize = true;
            this.label_ah_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ah_bin.Location = new System.Drawing.Point(528, 172);
            this.label_ah_bin.Name = "label_ah_bin";
            this.label_ah_bin.Size = new System.Drawing.Size(64, 16);
            this.label_ah_bin.TabIndex = 17;
            this.label_ah_bin.Text = "00000000";
            // 
            // label_al_bin
            // 
            this.label_al_bin.AutoSize = true;
            this.label_al_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_al_bin.Location = new System.Drawing.Point(628, 174);
            this.label_al_bin.Name = "label_al_bin";
            this.label_al_bin.Size = new System.Drawing.Size(64, 16);
            this.label_al_bin.TabIndex = 18;
            this.label_al_bin.Text = "00000000";
            // 
            // label_bh_bin
            // 
            this.label_bh_bin.AutoSize = true;
            this.label_bh_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_bh_bin.Location = new System.Drawing.Point(528, 228);
            this.label_bh_bin.Name = "label_bh_bin";
            this.label_bh_bin.Size = new System.Drawing.Size(64, 16);
            this.label_bh_bin.TabIndex = 19;
            this.label_bh_bin.Text = "00000000";
            // 
            // label_bl_bin
            // 
            this.label_bl_bin.AutoSize = true;
            this.label_bl_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_bl_bin.Location = new System.Drawing.Point(628, 228);
            this.label_bl_bin.Name = "label_bl_bin";
            this.label_bl_bin.Size = new System.Drawing.Size(64, 16);
            this.label_bl_bin.TabIndex = 20;
            this.label_bl_bin.Text = "00000000";
            // 
            // label_ch_bin
            // 
            this.label_ch_bin.AutoSize = true;
            this.label_ch_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ch_bin.Location = new System.Drawing.Point(528, 281);
            this.label_ch_bin.Name = "label_ch_bin";
            this.label_ch_bin.Size = new System.Drawing.Size(64, 16);
            this.label_ch_bin.TabIndex = 21;
            this.label_ch_bin.Text = "00000000";
            // 
            // label_cl_bin
            // 
            this.label_cl_bin.AutoSize = true;
            this.label_cl_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cl_bin.Location = new System.Drawing.Point(628, 281);
            this.label_cl_bin.Name = "label_cl_bin";
            this.label_cl_bin.Size = new System.Drawing.Size(64, 16);
            this.label_cl_bin.TabIndex = 22;
            this.label_cl_bin.Text = "00000000";
            // 
            // label_dh_bin
            // 
            this.label_dh_bin.AutoSize = true;
            this.label_dh_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dh_bin.Location = new System.Drawing.Point(528, 339);
            this.label_dh_bin.Name = "label_dh_bin";
            this.label_dh_bin.Size = new System.Drawing.Size(64, 16);
            this.label_dh_bin.TabIndex = 23;
            this.label_dh_bin.Text = "00000000";
            // 
            // label_dl_bin
            // 
            this.label_dl_bin.AutoSize = true;
            this.label_dl_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dl_bin.Location = new System.Drawing.Point(628, 339);
            this.label_dl_bin.Name = "label_dl_bin";
            this.label_dl_bin.Size = new System.Drawing.Size(64, 16);
            this.label_dl_bin.TabIndex = 24;
            this.label_dl_bin.Text = "00000000";
            // 
            // button_wykonajPorgram
            // 
            this.button_wykonajPorgram.Location = new System.Drawing.Point(325, 394);
            this.button_wykonajPorgram.Name = "button_wykonajPorgram";
            this.button_wykonajPorgram.Size = new System.Drawing.Size(131, 23);
            this.button_wykonajPorgram.TabIndex = 26;
            this.button_wykonajPorgram.Text = "wykonaj program";
            this.button_wykonajPorgram.UseVisualStyleBackColor = true;
            this.button_wykonajPorgram.Click += new System.EventHandler(this.button_wykonajPorgram_Click);
            // 
            // button_krokowo
            // 
            this.button_krokowo.Location = new System.Drawing.Point(462, 394);
            this.button_krokowo.Name = "button_krokowo";
            this.button_krokowo.Size = new System.Drawing.Size(130, 23);
            this.button_krokowo.TabIndex = 27;
            this.button_krokowo.Text = "wykonaj krok";
            this.button_krokowo.UseVisualStyleBackColor = true;
            this.button_krokowo.Click += new System.EventHandler(this.button_krokowo_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(90, 484);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(162, 23);
            this.button_reset.TabIndex = 28;
            this.button_reset.Text = "zresetuj program";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_zapisz
            // 
            this.button_zapisz.Location = new System.Drawing.Point(325, 432);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Size = new System.Drawing.Size(177, 23);
            this.button_zapisz.TabIndex = 29;
            this.button_zapisz.Text = "zapisz do pliku";
            this.button_zapisz.UseVisualStyleBackColor = true;
            this.button_zapisz.Click += new System.EventHandler(this.button_zapisz_Click);
            // 
            // button_odczytaj
            // 
            this.button_odczytaj.Location = new System.Drawing.Point(531, 432);
            this.button_odczytaj.Name = "button_odczytaj";
            this.button_odczytaj.Size = new System.Drawing.Size(175, 23);
            this.button_odczytaj.TabIndex = 30;
            this.button_odczytaj.Text = "odczytaj z pliku";
            this.button_odczytaj.UseVisualStyleBackColor = true;
            this.button_odczytaj.Click += new System.EventHandler(this.button_odczytaj_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 76);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(39, 402);
            this.textBox2.TabIndex = 31;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // button_czysc_zmienne
            // 
            this.button_czysc_zmienne.Location = new System.Drawing.Point(598, 394);
            this.button_czysc_zmienne.Name = "button_czysc_zmienne";
            this.button_czysc_zmienne.Size = new System.Drawing.Size(108, 23);
            this.button_czysc_zmienne.TabIndex = 32;
            this.button_czysc_zmienne.Text = "wyczysc";
            this.button_czysc_zmienne.UseVisualStyleBackColor = true;
            this.button_czysc_zmienne.Click += new System.EventHandler(this.button_czysc_zmienne_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 39);
            this.label9.TabIndex = 33;
            this.label9.Text = "wybierz z listy lub\r\nwporwadz liczbę \r\ncałkowitą dodatnią";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 528);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_czysc_zmienne);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button_odczytaj);
            this.Controls.Add(this.button_zapisz);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_krokowo);
            this.Controls.Add(this.button_wykonajPorgram);
            this.Controls.Add(this.label_dl_bin);
            this.Controls.Add(this.label_dh_bin);
            this.Controls.Add(this.label_cl_bin);
            this.Controls.Add(this.label_ch_bin);
            this.Controls.Add(this.label_bl_bin);
            this.Controls.Add(this.label_bh_bin);
            this.Controls.Add(this.label_al_bin);
            this.Controls.Add(this.label_ah_bin);
            this.Controls.Add(this.label_dx_dec);
            this.Controls.Add(this.label_cx_dec);
            this.Controls.Add(this.label_bx_dec);
            this.Controls.Add(this.label_ax_dec);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_ax_dec;
        private System.Windows.Forms.Label label_bx_dec;
        private System.Windows.Forms.Label label_cx_dec;
        private System.Windows.Forms.Label label_dx_dec;
        private System.Windows.Forms.Label label_ah_bin;
        private System.Windows.Forms.Label label_al_bin;
        private System.Windows.Forms.Label label_bh_bin;
        private System.Windows.Forms.Label label_bl_bin;
        private System.Windows.Forms.Label label_ch_bin;
        private System.Windows.Forms.Label label_cl_bin;
        private System.Windows.Forms.Label label_dh_bin;
        private System.Windows.Forms.Label label_dl_bin;
        private System.Windows.Forms.Button button_wykonajPorgram;
        private System.Windows.Forms.Button button_krokowo;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_zapisz;
        private System.Windows.Forms.Button button_odczytaj;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button button_czysc_zmienne;
        private System.Windows.Forms.Label label9;
    }
}

