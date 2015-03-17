namespace Racional
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
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
            this.numerador1 = new System.Windows.Forms.TextBox();
            this.denominador1 = new System.Windows.Forms.TextBox();
            this.numerador2 = new System.Windows.Forms.TextBox();
            this.denominador2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.multi = new System.Windows.Forms.Button();
            this.divid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.equivalente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numerador1
            // 
            this.numerador1.Location = new System.Drawing.Point(128, 93);
            this.numerador1.Name = "numerador1";
            this.numerador1.Size = new System.Drawing.Size(100, 21);
            this.numerador1.TabIndex = 0;
            // 
            // denominador1
            // 
            this.denominador1.Location = new System.Drawing.Point(128, 165);
            this.denominador1.Name = "denominador1";
            this.denominador1.Size = new System.Drawing.Size(100, 21);
            this.denominador1.TabIndex = 1;
            // 
            // numerador2
            // 
            this.numerador2.Location = new System.Drawing.Point(301, 93);
            this.numerador2.Name = "numerador2";
            this.numerador2.Size = new System.Drawing.Size(100, 21);
            this.numerador2.TabIndex = 2;
            // 
            // denominador2
            // 
            this.denominador2.Location = new System.Drawing.Point(301, 165);
            this.denominador2.Name = "denominador2";
            this.denominador2.Size = new System.Drawing.Size(100, 21);
            this.denominador2.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(623, 93);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(623, 165);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 5;
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(469, 66);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(75, 27);
            this.multi.TabIndex = 9;
            this.multi.Text = "multiplicar";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // divid
            // 
            this.divid.Location = new System.Drawing.Point(469, 122);
            this.divid.Name = "divid";
            this.divid.Size = new System.Drawing.Size(75, 27);
            this.divid.TabIndex = 10;
            this.divid.Text = "dividir";
            this.divid.UseVisualStyleBackColor = true;
            this.divid.Click += new System.EventHandler(this.divid_Click_1);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(631, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nom/Den 2";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nom/Den 1";
            // 
            // equivalente
            // 
            this.equivalente.Location = new System.Drawing.Point(469, 180);
            this.equivalente.Name = "equivalente";
            this.equivalente.Size = new System.Drawing.Size(75, 27);
            this.equivalente.TabIndex = 18;
            this.equivalente.Text = "equivalente";
            this.equivalente.UseVisualStyleBackColor = true;
            this.equivalente.Click += new System.EventHandler(this.equivalente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.equivalente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divid);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.denominador2);
            this.Controls.Add(this.numerador2);
            this.Controls.Add(this.denominador1);
            this.Controls.Add(this.numerador1);
            this.Font = new System.Drawing.Font("Minion Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numerador1;
        private System.Windows.Forms.TextBox denominador1;
        private System.Windows.Forms.TextBox numerador2;
        private System.Windows.Forms.TextBox denominador2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button divid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button equivalente;
    }
}

