namespace prueba_ejecicio_con_GitHub
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
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(439, 105);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(108, 47);
            this.btnSumar.TabIndex = 0;
            this.btnSumar.Text = "SUMA";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(439, 178);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(108, 47);
            this.btnRestar.TabIndex = 1;
            this.btnRestar.Text = "RESTA";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(281, 118);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 26);
            this.txtnum1.TabIndex = 2;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(281, 178);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 26);
            this.txtnum2.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(281, 267);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 26);
            this.txtResultado.TabIndex = 4;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(151, 118);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(78, 20);
            this.lblNum1.TabIndex = 5;
            this.lblNum1.Text = "Numero 1";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(151, 273);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(90, 20);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado: ";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(151, 184);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(78, 20);
            this.lblNum2.TabIndex = 8;
            this.lblNum2.Text = "Numero 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblNum2;
    }
}

