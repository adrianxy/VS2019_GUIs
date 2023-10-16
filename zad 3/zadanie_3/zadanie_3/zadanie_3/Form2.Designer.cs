
using System;

namespace zadanie_3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        Random rnd = new Random();
        int moment_zmiany_i;
        int czas_i;
        int wynik_i;
        string czy_test_samou_s;

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
            this.b_test1_start = new System.Windows.Forms.Button();
            this.label_test1_wynik = new System.Windows.Forms.Label();
            this.b_test1_samouczek = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_samouczek_opis = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_test1_start
            // 
            this.b_test1_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_test1_start.Location = new System.Drawing.Point(12, 77);
            this.b_test1_start.Name = "b_test1_start";
            this.b_test1_start.Size = new System.Drawing.Size(187, 52);
            this.b_test1_start.TabIndex = 0;
            this.b_test1_start.Text = "Rozpocznij test";
            this.b_test1_start.UseVisualStyleBackColor = true;
            this.b_test1_start.Click += new System.EventHandler(this.b_test1_start_Click);
            // 
            // label_test1_wynik
            // 
            this.label_test1_wynik.AutoSize = true;
            this.label_test1_wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_test1_wynik.Location = new System.Drawing.Point(412, 19);
            this.label_test1_wynik.Name = "label_test1_wynik";
            this.label_test1_wynik.Size = new System.Drawing.Size(0, 24);
            this.label_test1_wynik.TabIndex = 1;
            // 
            // b_test1_samouczek
            // 
            this.b_test1_samouczek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_test1_samouczek.Location = new System.Drawing.Point(12, 19);
            this.b_test1_samouczek.Name = "b_test1_samouczek";
            this.b_test1_samouczek.Size = new System.Drawing.Size(187, 52);
            this.b_test1_samouczek.TabIndex = 2;
            this.b_test1_samouczek.Text = "Rozpocznij samouczek";
            this.b_test1_samouczek.UseVisualStyleBackColor = true;
            this.b_test1_samouczek.Click += new System.EventHandler(this.b_test1_samouczek_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(126, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 284);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_samouczek_opis
            // 
            this.label_samouczek_opis.AutoSize = true;
            this.label_samouczek_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_samouczek_opis.Location = new System.Drawing.Point(51, 409);
            this.label_samouczek_opis.Name = "label_samouczek_opis";
            this.label_samouczek_opis.Size = new System.Drawing.Size(499, 16);
            this.label_samouczek_opis.TabIndex = 4;
            this.label_samouczek_opis.Text = "Po zmianie koloru prostokąta na czernowy naciśnij w niego jak najszybciej potrafi" +
    "sz";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 461);
            this.Controls.Add(this.label_samouczek_opis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_test1_samouczek);
            this.Controls.Add(this.label_test1_wynik);
            this.Controls.Add(this.b_test1_start);
            this.Name = "Form2";
            this.Text = "Test 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_test1_start;
        private System.Windows.Forms.Label label_test1_wynik;
        private System.Windows.Forms.Button b_test1_samouczek;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_samouczek_opis;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}