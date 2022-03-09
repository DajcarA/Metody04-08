namespace Metody04_08
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1Mocnina = new System.Windows.Forms.Button();
            this.button2Faktorial = new System.Windows.Forms.Button();
            this.button3CifLichSoucet = new System.Windows.Forms.Button();
            this.button4JePrvocislo = new System.Windows.Forms.Button();
            this.button5PocetDeliteluSud = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1Mocnina
            // 
            this.button1Mocnina.Location = new System.Drawing.Point(12, 76);
            this.button1Mocnina.Name = "button1Mocnina";
            this.button1Mocnina.Size = new System.Drawing.Size(75, 23);
            this.button1Mocnina.TabIndex = 0;
            this.button1Mocnina.Text = "Mocnina";
            this.button1Mocnina.UseVisualStyleBackColor = true;
            this.button1Mocnina.Click += new System.EventHandler(this.button1Mocnina_Click);
            // 
            // button2Faktorial
            // 
            this.button2Faktorial.Location = new System.Drawing.Point(198, 76);
            this.button2Faktorial.Name = "button2Faktorial";
            this.button2Faktorial.Size = new System.Drawing.Size(75, 23);
            this.button2Faktorial.TabIndex = 1;
            this.button2Faktorial.Text = "Faktorial";
            this.button2Faktorial.UseVisualStyleBackColor = true;
            this.button2Faktorial.Click += new System.EventHandler(this.button2Faktorial_Click);
            // 
            // button3CifLichSoucet
            // 
            this.button3CifLichSoucet.Location = new System.Drawing.Point(394, 76);
            this.button3CifLichSoucet.Name = "button3CifLichSoucet";
            this.button3CifLichSoucet.Size = new System.Drawing.Size(84, 23);
            this.button3CifLichSoucet.TabIndex = 2;
            this.button3CifLichSoucet.Text = "CifLichSoucet";
            this.button3CifLichSoucet.UseVisualStyleBackColor = true;
            this.button3CifLichSoucet.Click += new System.EventHandler(this.button3CifLichSoucet_Click);
            // 
            // button4JePrvocislo
            // 
            this.button4JePrvocislo.Location = new System.Drawing.Point(594, 76);
            this.button4JePrvocislo.Name = "button4JePrvocislo";
            this.button4JePrvocislo.Size = new System.Drawing.Size(75, 23);
            this.button4JePrvocislo.TabIndex = 3;
            this.button4JePrvocislo.Text = "JePrvocislo";
            this.button4JePrvocislo.UseVisualStyleBackColor = true;
            // 
            // button5PocetDeliteluSud
            // 
            this.button5PocetDeliteluSud.Location = new System.Drawing.Point(12, 228);
            this.button5PocetDeliteluSud.Name = "button5PocetDeliteluSud";
            this.button5PocetDeliteluSud.Size = new System.Drawing.Size(100, 23);
            this.button5PocetDeliteluSud.TabIndex = 4;
            this.button5PocetDeliteluSud.Text = "PocetDeliteluSud";
            this.button5PocetDeliteluSud.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Základ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Exponent";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(198, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(95, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Parametr faktorialu";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(394, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(594, 21);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 186);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5PocetDeliteluSud);
            this.Controls.Add(this.button4JePrvocislo);
            this.Controls.Add(this.button3CifLichSoucet);
            this.Controls.Add(this.button2Faktorial);
            this.Controls.Add(this.button1Mocnina);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Mocnina;
        private System.Windows.Forms.Button button2Faktorial;
        private System.Windows.Forms.Button button3CifLichSoucet;
        private System.Windows.Forms.Button button4JePrvocislo;
        private System.Windows.Forms.Button button5PocetDeliteluSud;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}

