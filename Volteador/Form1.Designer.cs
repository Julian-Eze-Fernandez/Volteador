namespace Volteador
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
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.btnVoltear = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(13, 13);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(100, 20);
            this.txtOriginal.TabIndex = 0;
            // 
            // btnVoltear
            // 
            this.btnVoltear.Location = new System.Drawing.Point(128, 12);
            this.btnVoltear.Name = "btnVoltear";
            this.btnVoltear.Size = new System.Drawing.Size(75, 22);
            this.btnVoltear.TabIndex = 2;
            this.btnVoltear.Text = "Voltear";
            this.btnVoltear.UseVisualStyleBackColor = true;
            this.btnVoltear.Click += new System.EventHandler(this.btnVoltear_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(100, 50);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 87);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVoltear);
            this.Controls.Add(this.txtOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Button btnVoltear;
        private System.Windows.Forms.Label lblResultado;
    }
}

