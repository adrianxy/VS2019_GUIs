using System;

namespace zadanie_4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// 
        public Form3 okno3;
        int nagrzwnica_i;
        int chlodnica_i;
        int wentylator_i;
        int wentylator2_i;
        int went_zepsucie_i;
        bool went1_on_off;
        bool went2_on_off;
        int nagrzewnica_inger_oper_i;
        int chlodnica_inger_oper_i;
        bool linia_on_off;


//        string ingerencja_operatora_s;

        Random rnd = new Random();
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.wentylator_tb = new System.Windows.Forms.TextBox();
            this.nagrzewnica_tb = new System.Windows.Forms.TextBox();
            this.chlodnica_tb = new System.Windows.Forms.TextBox();
            this.wentylator2_tb = new System.Windows.Forms.TextBox();
            this.linia_tb = new System.Windows.Forms.TextBox();
            this.menu_operatora_b = new System.Windows.Forms.Button();
            this.wentylator_pb = new System.Windows.Forms.PictureBox();
            this.linia_pb = new System.Windows.Forms.PictureBox();
            this.nagrzewnica_pb = new System.Windows.Forms.PictureBox();
            this.wentylator2_pb = new System.Windows.Forms.PictureBox();
            this.chlodnica_pb = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wentylator_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linia_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagrzewnica_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wentylator2_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chlodnica_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // wentylator_tb
            // 
            this.wentylator_tb.Location = new System.Drawing.Point(138, 59);
            this.wentylator_tb.Name = "wentylator_tb";
            this.wentylator_tb.Size = new System.Drawing.Size(100, 20);
            this.wentylator_tb.TabIndex = 5;
            // 
            // nagrzewnica_tb
            // 
            this.nagrzewnica_tb.Location = new System.Drawing.Point(313, 59);
            this.nagrzewnica_tb.Name = "nagrzewnica_tb";
            this.nagrzewnica_tb.Size = new System.Drawing.Size(100, 20);
            this.nagrzewnica_tb.TabIndex = 6;
            // 
            // chlodnica_tb
            // 
            this.chlodnica_tb.Location = new System.Drawing.Point(492, 59);
            this.chlodnica_tb.Name = "chlodnica_tb";
            this.chlodnica_tb.Size = new System.Drawing.Size(100, 20);
            this.chlodnica_tb.TabIndex = 7;
            // 
            // wentylator2_tb
            // 
            this.wentylator2_tb.Location = new System.Drawing.Point(138, 350);
            this.wentylator2_tb.Name = "wentylator2_tb";
            this.wentylator2_tb.Size = new System.Drawing.Size(100, 20);
            this.wentylator2_tb.TabIndex = 8;
            // 
            // linia_tb
            // 
            this.linia_tb.Location = new System.Drawing.Point(405, 247);
            this.linia_tb.Name = "linia_tb";
            this.linia_tb.Size = new System.Drawing.Size(100, 20);
            this.linia_tb.TabIndex = 9;
            // 
            // menu_operatora_b
            // 
            this.menu_operatora_b.Location = new System.Drawing.Point(473, 330);
            this.menu_operatora_b.Name = "menu_operatora_b";
            this.menu_operatora_b.Size = new System.Drawing.Size(119, 40);
            this.menu_operatora_b.TabIndex = 10;
            this.menu_operatora_b.Text = "menu operatora";
            this.menu_operatora_b.UseVisualStyleBackColor = true;
            this.menu_operatora_b.Click += new System.EventHandler(this.menu_operatora_b_Click);
            // 
            // wentylator_pb
            // 
            this.wentylator_pb.Image = global::zadanie_4.Properties.Resources.wentylator;
            this.wentylator_pb.Location = new System.Drawing.Point(138, 85);
            this.wentylator_pb.Name = "wentylator_pb";
            this.wentylator_pb.Size = new System.Drawing.Size(100, 100);
            this.wentylator_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wentylator_pb.TabIndex = 0;
            this.wentylator_pb.TabStop = false;
            // 
            // linia_pb
            // 
            this.linia_pb.Image = global::zadanie_4.Properties.Resources.linia;
            this.linia_pb.Location = new System.Drawing.Point(138, 191);
            this.linia_pb.Name = "linia_pb";
            this.linia_pb.Size = new System.Drawing.Size(454, 50);
            this.linia_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.linia_pb.TabIndex = 1;
            this.linia_pb.TabStop = false;
            // 
            // nagrzewnica_pb
            // 
            this.nagrzewnica_pb.Image = global::zadanie_4.Properties.Resources.nagrzewnica;
            this.nagrzewnica_pb.Location = new System.Drawing.Point(313, 85);
            this.nagrzewnica_pb.Name = "nagrzewnica_pb";
            this.nagrzewnica_pb.Size = new System.Drawing.Size(100, 100);
            this.nagrzewnica_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nagrzewnica_pb.TabIndex = 2;
            this.nagrzewnica_pb.TabStop = false;
            // 
            // wentylator2_pb
            // 
            this.wentylator2_pb.Image = global::zadanie_4.Properties.Resources.wentylator;
            this.wentylator2_pb.Location = new System.Drawing.Point(138, 247);
            this.wentylator2_pb.Name = "wentylator2_pb";
            this.wentylator2_pb.Size = new System.Drawing.Size(100, 97);
            this.wentylator2_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wentylator2_pb.TabIndex = 3;
            this.wentylator2_pb.TabStop = false;
            // 
            // chlodnica_pb
            // 
            this.chlodnica_pb.Image = global::zadanie_4.Properties.Resources.chłodnica;
            this.chlodnica_pb.Location = new System.Drawing.Point(492, 85);
            this.chlodnica_pb.Name = "chlodnica_pb";
            this.chlodnica_pb.Size = new System.Drawing.Size(100, 100);
            this.chlodnica_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chlodnica_pb.TabIndex = 4;
            this.chlodnica_pb.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            this.label1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu_operatora_b);
            this.Controls.Add(this.linia_tb);
            this.Controls.Add(this.wentylator2_tb);
            this.Controls.Add(this.chlodnica_tb);
            this.Controls.Add(this.nagrzewnica_tb);
            this.Controls.Add(this.wentylator_tb);
            this.Controls.Add(this.chlodnica_pb);
            this.Controls.Add(this.wentylator2_pb);
            this.Controls.Add(this.nagrzewnica_pb);
            this.Controls.Add(this.linia_pb);
            this.Controls.Add(this.wentylator_pb);
            this.Name = "Form2";
            this.Text = "Hartowanie materiału";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wentylator_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linia_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagrzewnica_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wentylator2_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chlodnica_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox wentylator_tb;
        private System.Windows.Forms.TextBox nagrzewnica_tb;
        private System.Windows.Forms.TextBox chlodnica_tb;
        private System.Windows.Forms.TextBox wentylator2_tb;
        private System.Windows.Forms.TextBox linia_tb;
        private System.Windows.Forms.Button menu_operatora_b;
        private System.Windows.Forms.PictureBox wentylator_pb;
        private System.Windows.Forms.PictureBox linia_pb;
        private System.Windows.Forms.PictureBox nagrzewnica_pb;
        private System.Windows.Forms.PictureBox wentylator2_pb;
        private System.Windows.Forms.PictureBox chlodnica_pb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}