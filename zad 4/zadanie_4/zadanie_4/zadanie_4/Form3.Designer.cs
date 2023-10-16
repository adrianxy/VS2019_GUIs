
namespace zadanie_4
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// 
        //string ingerencja_operatora_s;

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
            this.went_op1_b = new System.Windows.Forms.Button();
            this.went_op2_b = new System.Windows.Forms.Button();
            this.nagrzewnica_op1_b = new System.Windows.Forms.Button();
            this.nagrzewnica_op2_b = new System.Windows.Forms.Button();
            this.chlodnica_op1_b = new System.Windows.Forms.Button();
            this.chlodnica_op2_b = new System.Windows.Forms.Button();
            this.linia_op1_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // went_op1_b
            // 
            this.went_op1_b.Location = new System.Drawing.Point(37, 12);
            this.went_op1_b.Name = "went_op1_b";
            this.went_op1_b.Size = new System.Drawing.Size(156, 49);
            this.went_op1_b.TabIndex = 0;
            this.went_op1_b.Text = "wyłącz wentylator główny i włącz wentylator awaryjny";
            this.went_op1_b.UseVisualStyleBackColor = true;
            this.went_op1_b.Click += new System.EventHandler(this.wyl_went1_wl_went2_b_Click);
            // 
            // went_op2_b
            // 
            this.went_op2_b.Location = new System.Drawing.Point(37, 80);
            this.went_op2_b.Name = "went_op2_b";
            this.went_op2_b.Size = new System.Drawing.Size(156, 49);
            this.went_op2_b.TabIndex = 1;
            this.went_op2_b.Text = "wymiana wentylatora glownego na nowy i wylaczenie 2 wentylatora";
            this.went_op2_b.UseVisualStyleBackColor = true;
            this.went_op2_b.Click += new System.EventHandler(this.went_op2_b_Click);
            // 
            // nagrzewnica_op1_b
            // 
            this.nagrzewnica_op1_b.Location = new System.Drawing.Point(37, 150);
            this.nagrzewnica_op1_b.Name = "nagrzewnica_op1_b";
            this.nagrzewnica_op1_b.Size = new System.Drawing.Size(156, 49);
            this.nagrzewnica_op1_b.TabIndex = 2;
            this.nagrzewnica_op1_b.Text = "zmniejsz energię dostarczaną do nagrzewnicy o 5W";
            this.nagrzewnica_op1_b.UseVisualStyleBackColor = true;
            this.nagrzewnica_op1_b.Click += new System.EventHandler(this.nagrzewnica_op1_b_Click);
            // 
            // nagrzewnica_op2_b
            // 
            this.nagrzewnica_op2_b.Location = new System.Drawing.Point(37, 221);
            this.nagrzewnica_op2_b.Name = "nagrzewnica_op2_b";
            this.nagrzewnica_op2_b.Size = new System.Drawing.Size(156, 49);
            this.nagrzewnica_op2_b.TabIndex = 3;
            this.nagrzewnica_op2_b.Text = "zwieksz energię dostarczaną do nagrzewnicy o 5W";
            this.nagrzewnica_op2_b.UseVisualStyleBackColor = true;
            this.nagrzewnica_op2_b.Click += new System.EventHandler(this.nagrzewnica_op2_b_Click);
            // 
            // chlodnica_op1_b
            // 
            this.chlodnica_op1_b.Location = new System.Drawing.Point(37, 290);
            this.chlodnica_op1_b.Name = "chlodnica_op1_b";
            this.chlodnica_op1_b.Size = new System.Drawing.Size(156, 49);
            this.chlodnica_op1_b.TabIndex = 4;
            this.chlodnica_op1_b.Text = "zmniejsz energię dostarczaną do chlodnicy o 5W";
            this.chlodnica_op1_b.UseVisualStyleBackColor = true;
            this.chlodnica_op1_b.Click += new System.EventHandler(this.chlodnica_op1_b_Click);
            // 
            // chlodnica_op2_b
            // 
            this.chlodnica_op2_b.Location = new System.Drawing.Point(37, 357);
            this.chlodnica_op2_b.Name = "chlodnica_op2_b";
            this.chlodnica_op2_b.Size = new System.Drawing.Size(156, 49);
            this.chlodnica_op2_b.TabIndex = 5;
            this.chlodnica_op2_b.Text = "zwieksz energię dostarczaną do chlodnicy o 5W";
            this.chlodnica_op2_b.UseVisualStyleBackColor = true;
            this.chlodnica_op2_b.Click += new System.EventHandler(this.chlodnica_op2_b_Click);
            // 
            // linia_op1_b
            // 
            this.linia_op1_b.Location = new System.Drawing.Point(37, 427);
            this.linia_op1_b.Name = "linia_op1_b";
            this.linia_op1_b.Size = new System.Drawing.Size(156, 49);
            this.linia_op1_b.TabIndex = 6;
            this.linia_op1_b.Text = "zresetuj linie";
            this.linia_op1_b.UseVisualStyleBackColor = true;
            this.linia_op1_b.Click += new System.EventHandler(this.linia_op1_b_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 576);
            this.Controls.Add(this.linia_op1_b);
            this.Controls.Add(this.chlodnica_op2_b);
            this.Controls.Add(this.chlodnica_op1_b);
            this.Controls.Add(this.nagrzewnica_op2_b);
            this.Controls.Add(this.nagrzewnica_op1_b);
            this.Controls.Add(this.went_op2_b);
            this.Controls.Add(this.went_op1_b);
            this.Name = "Form3";
            this.Text = "Menu operatora";
            this.Click += new System.EventHandler(this.Form3_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button went_op1_b;
        private System.Windows.Forms.Button went_op2_b;
        private System.Windows.Forms.Button nagrzewnica_op1_b;
        private System.Windows.Forms.Button nagrzewnica_op2_b;
        private System.Windows.Forms.Button chlodnica_op1_b;
        private System.Windows.Forms.Button chlodnica_op2_b;
        private System.Windows.Forms.Button linia_op1_b;
    }
}