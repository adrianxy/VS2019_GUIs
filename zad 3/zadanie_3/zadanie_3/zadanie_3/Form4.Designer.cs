using System;

namespace zadanie_3
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        Random rnd = new Random();
        int moment_zmiany_i;
        int temp_i;
        int wynik_i;
        string czy_test_samou_s;
        int ktore_pole_i;
        int ktore_zwierze_i;
        bool czy_moge_dostac_pkt;
        string temp_s;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_samouczek_opis = new System.Windows.Forms.Label();
            this.b_test3_samouczek = new System.Windows.Forms.Button();
            this.label_test3_wynik = new System.Windows.Forms.Label();
            this.b_test3_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // label_samouczek_opis
            // 
            this.label_samouczek_opis.AutoSize = true;
            this.label_samouczek_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_samouczek_opis.Location = new System.Drawing.Point(183, 486);
            this.label_samouczek_opis.Name = "label_samouczek_opis";
            this.label_samouczek_opis.Size = new System.Drawing.Size(256, 16);
            this.label_samouczek_opis.TabIndex = 14;
            this.label_samouczek_opis.Text = "Uderzaj zwierzaki jak najszybciej potrafisz";
            // 
            // b_test3_samouczek
            // 
            this.b_test3_samouczek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_test3_samouczek.Location = new System.Drawing.Point(12, 12);
            this.b_test3_samouczek.Name = "b_test3_samouczek";
            this.b_test3_samouczek.Size = new System.Drawing.Size(187, 52);
            this.b_test3_samouczek.TabIndex = 12;
            this.b_test3_samouczek.Text = "Rozpocznij samouczek";
            this.b_test3_samouczek.UseVisualStyleBackColor = true;
            this.b_test3_samouczek.Click += new System.EventHandler(this.b_test3_samouczek_Click);
            // 
            // label_test3_wynik
            // 
            this.label_test3_wynik.AutoSize = true;
            this.label_test3_wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_test3_wynik.Location = new System.Drawing.Point(551, 12);
            this.label_test3_wynik.Name = "label_test3_wynik";
            this.label_test3_wynik.Size = new System.Drawing.Size(0, 24);
            this.label_test3_wynik.TabIndex = 11;
            // 
            // b_test3_start
            // 
            this.b_test3_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_test3_start.Location = new System.Drawing.Point(12, 70);
            this.b_test3_start.Name = "b_test3_start";
            this.b_test3_start.Size = new System.Drawing.Size(187, 52);
            this.b_test3_start.TabIndex = 10;
            this.b_test3_start.Text = "Rozpocznij test";
            this.b_test3_start.UseVisualStyleBackColor = true;
            this.b_test3_start.Click += new System.EventHandler(this.b_test3_start_Click);
            this.b_test3_start.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press_basic);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(231, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(396, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(159, 156);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(66, 174);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(159, 145);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(231, 174);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(159, 145);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(396, 174);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(159, 145);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(66, 325);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(159, 142);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(231, 325);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(159, 142);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(396, 325);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(158, 142);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 21;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 544);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_samouczek_opis);
            this.Controls.Add(this.b_test3_samouczek);
            this.Controls.Add(this.label_test3_wynik);
            this.Controls.Add(this.b_test3_start);
            this.Name = "Form4";
            this.Text = "Test 3";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press_basic);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_samouczek_opis;
        private System.Windows.Forms.Button b_test3_samouczek;
        private System.Windows.Forms.Label label_test3_wynik;
        private System.Windows.Forms.Button b_test3_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Timer timer2;
    }
}