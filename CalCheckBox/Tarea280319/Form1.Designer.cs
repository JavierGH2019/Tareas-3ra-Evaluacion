namespace Tarea280319
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkSuma = new System.Windows.Forms.CheckBox();
            this.checkResta = new System.Windows.Forms.CheckBox();
            this.checkMultiplicacion = new System.Windows.Forms.CheckBox();
            this.checkDivision = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Operar = new System.Windows.Forms.Button();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labResultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkSuma
            // 
            this.checkSuma.AutoSize = true;
            this.checkSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSuma.ForeColor = System.Drawing.Color.Chartreuse;
            this.checkSuma.Location = new System.Drawing.Point(30, 33);
            this.checkSuma.Name = "checkSuma";
            this.checkSuma.Size = new System.Drawing.Size(70, 24);
            this.checkSuma.TabIndex = 0;
            this.checkSuma.Text = "Suma";
            this.checkSuma.UseVisualStyleBackColor = true;
            this.checkSuma.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkResta
            // 
            this.checkResta.AutoSize = true;
            this.checkResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkResta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkResta.Location = new System.Drawing.Point(29, 75);
            this.checkResta.Name = "checkResta";
            this.checkResta.Size = new System.Drawing.Size(71, 24);
            this.checkResta.TabIndex = 1;
            this.checkResta.Text = "Resta";
            this.checkResta.UseVisualStyleBackColor = true;
            // 
            // checkMultiplicacion
            // 
            this.checkMultiplicacion.AutoSize = true;
            this.checkMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMultiplicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkMultiplicacion.Location = new System.Drawing.Point(29, 125);
            this.checkMultiplicacion.Name = "checkMultiplicacion";
            this.checkMultiplicacion.Size = new System.Drawing.Size(122, 24);
            this.checkMultiplicacion.TabIndex = 2;
            this.checkMultiplicacion.Text = "Multiplicacion";
            this.checkMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // checkDivision
            // 
            this.checkDivision.AutoSize = true;
            this.checkDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDivision.ForeColor = System.Drawing.Color.Coral;
            this.checkDivision.Location = new System.Drawing.Point(30, 170);
            this.checkDivision.Name = "checkDivision";
            this.checkDivision.Size = new System.Drawing.Size(82, 24);
            this.checkDivision.TabIndex = 3;
            this.checkDivision.Text = "Division";
            this.checkDivision.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(344, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(344, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor 2";
            // 
            // Operar
            // 
            this.Operar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Operar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Operar.Location = new System.Drawing.Point(67, 259);
            this.Operar.Name = "Operar";
            this.Operar.Size = new System.Drawing.Size(99, 23);
            this.Operar.TabIndex = 6;
            this.Operar.Text = "Operar";
            this.Operar.UseVisualStyleBackColor = false;
            this.Operar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(309, 74);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(116, 20);
            this.textNum1.TabIndex = 7;
            this.textNum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(309, 166);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(116, 20);
            this.textNum2.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkDivision);
            this.groupBox1.Controls.Add(this.checkMultiplicacion);
            this.groupBox1.Controls.Add(this.checkResta);
            this.groupBox1.Controls.Add(this.checkSuma);
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 211);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // labResultado
            // 
            this.labResultado.AutoSize = true;
            this.labResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResultado.Location = new System.Drawing.Point(227, 259);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(79, 16);
            this.labResultado.TabIndex = 10;
            this.labResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 294);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.Operar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkResta;
        private System.Windows.Forms.CheckBox checkMultiplicacion;
        private System.Windows.Forms.CheckBox checkDivision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Operar;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labResultado;
        private System.Windows.Forms.CheckBox checkSuma;
    }
}

