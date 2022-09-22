namespace Pi
{
    partial class FrmClasseMath
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
            this.lblPI = new System.Windows.Forms.Label();
            this.textPI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPI
            // 
            this.lblPI.AutoSize = true;
            this.lblPI.Location = new System.Drawing.Point(40, 20);
            this.lblPI.Name = "lblPI";
            this.lblPI.Size = new System.Drawing.Size(106, 16);
            this.lblPI.TabIndex = 0;
            this.lblPI.Text = "O Valor de PI:";
            // 
            // textPI
            // 
            this.textPI.Location = new System.Drawing.Point(150, 13);
            this.textPI.Name = "textPI";
            this.textPI.Size = new System.Drawing.Size(200, 23);
            this.textPI.TabIndex = 1;
            this.textPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmClasseMath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 57);
            this.Controls.Add(this.textPI);
            this.Controls.Add(this.lblPI);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "FrmClasseMath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplos com Classe Math";
            this.Load += new System.EventHandler(this.FrmClasseMath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPI;
        private System.Windows.Forms.TextBox textPI;
    }
}

