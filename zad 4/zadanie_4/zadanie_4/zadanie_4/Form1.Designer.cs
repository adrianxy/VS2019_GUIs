
namespace zadanie_4
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// 

        Form2 okno2;
        private const string login_s = "admin";
        private const string haslo_s = "admin";

        int czas_i;
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
            this.login_tb = new System.Windows.Forms.TextBox();
            this.haslo_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zaloguj_b = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_tb
            // 
            this.login_tb.Location = new System.Drawing.Point(108, 73);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(212, 20);
            this.login_tb.TabIndex = 0;
            // 
            // haslo_tb
            // 
            this.haslo_tb.Location = new System.Drawing.Point(108, 108);
            this.haslo_tb.Name = "haslo_tb";
            this.haslo_tb.Size = new System.Drawing.Size(212, 20);
            this.haslo_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasło:";
            // 
            // zaloguj_b
            // 
            this.zaloguj_b.Location = new System.Drawing.Point(108, 148);
            this.zaloguj_b.Name = "zaloguj_b";
            this.zaloguj_b.Size = new System.Drawing.Size(75, 23);
            this.zaloguj_b.TabIndex = 4;
            this.zaloguj_b.Text = "zaloguj";
            this.zaloguj_b.UseVisualStyleBackColor = true;
            this.zaloguj_b.Click += new System.EventHandler(this.zaloguj_b_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 335);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zaloguj_b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.haslo_tb);
            this.Controls.Add(this.login_tb);
            this.Name = "Form1";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox haslo_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button zaloguj_b;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

