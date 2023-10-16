
namespace zadanie_3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        Form2 OknoTest1;
        Form3 OknoTest2;
        Form4 OknoTest3;
        int temp;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.b_test1 = new System.Windows.Forms.Button();
            this.b_test2 = new System.Windows.Forms.Button();
            this.b_test3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart_wyniki = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_wyniki)).BeginInit();
            this.SuspendLayout();
            // 
            // b_test1
            // 
            this.b_test1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.b_test1.Location = new System.Drawing.Point(51, 59);
            this.b_test1.Name = "b_test1";
            this.b_test1.Size = new System.Drawing.Size(205, 200);
            this.b_test1.TabIndex = 0;
            this.b_test1.Text = "Test 1";
            this.b_test1.UseVisualStyleBackColor = true;
            this.b_test1.Click += new System.EventHandler(this.b_test1_Click);
            // 
            // b_test2
            // 
            this.b_test2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.b_test2.Location = new System.Drawing.Point(285, 59);
            this.b_test2.Name = "b_test2";
            this.b_test2.Size = new System.Drawing.Size(205, 200);
            this.b_test2.TabIndex = 1;
            this.b_test2.Text = "Test 2";
            this.b_test2.UseVisualStyleBackColor = true;
            this.b_test2.Click += new System.EventHandler(this.b_test2_Click);
            // 
            // b_test3
            // 
            this.b_test3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.b_test3.Location = new System.Drawing.Point(518, 59);
            this.b_test3.Name = "b_test3";
            this.b_test3.Size = new System.Drawing.Size(205, 200);
            this.b_test3.TabIndex = 2;
            this.b_test3.Text = "Test 3";
            this.b_test3.UseVisualStyleBackColor = true;
            this.b_test3.Click += new System.EventHandler(this.b_test3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(91, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "wynik Test 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(323, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "wynik Test 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(557, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "wynik Test 3";
            // 
            // chart_wyniki
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_wyniki.ChartAreas.Add(chartArea1);
            this.chart_wyniki.Location = new System.Drawing.Point(86, 331);
            this.chart_wyniki.Name = "chart_wyniki";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Wyniki";
            this.chart_wyniki.Series.Add(series1);
            this.chart_wyniki.Size = new System.Drawing.Size(584, 189);
            this.chart_wyniki.TabIndex = 6;
            this.chart_wyniki.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Wyniki";
            this.chart_wyniki.Titles.Add(title1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(86, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "pokaż wyniki graficznie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart_wyniki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_test3);
            this.Controls.Add(this.b_test2);
            this.Controls.Add(this.b_test1);
            this.Name = "Form1";
            this.Text = "Test psychomotoryczny";
            ((System.ComponentModel.ISupportInitialize)(this.chart_wyniki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_test1;
        private System.Windows.Forms.Button b_test2;
        private System.Windows.Forms.Button b_test3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_wyniki;
        private System.Windows.Forms.Button button1;
    }
}

