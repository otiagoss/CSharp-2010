namespace CalculodaMedia
{
    partial class FrmCalcMedia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbOpcao = new System.Windows.Forms.GroupBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.lblN4 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.gbOpcao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTitulo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.Location = new System.Drawing.Point(150, 30);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(260, 50);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "CÁLCULO DA MÉDIA";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitulo.UseWaitCursor = true;
            // 
            // gbOpcao
            // 
            this.gbOpcao.Controls.Add(this.lblMedia);
            this.gbOpcao.Controls.Add(this.btSair);
            this.gbOpcao.Controls.Add(this.btCancelar);
            this.gbOpcao.Controls.Add(this.btCalcular);
            this.gbOpcao.Controls.Add(this.txtN4);
            this.gbOpcao.Controls.Add(this.txtN2);
            this.gbOpcao.Controls.Add(this.txtN3);
            this.gbOpcao.Controls.Add(this.txtN1);
            this.gbOpcao.Controls.Add(this.lblN4);
            this.gbOpcao.Controls.Add(this.lblN3);
            this.gbOpcao.Controls.Add(this.lblN2);
            this.gbOpcao.Controls.Add(this.lblN1);
            this.gbOpcao.Location = new System.Drawing.Point(40, 100);
            this.gbOpcao.Name = "gbOpcao";
            this.gbOpcao.Size = new System.Drawing.Size(460, 200);
            this.gbOpcao.TabIndex = 1;
            this.gbOpcao.TabStop = false;
            this.gbOpcao.UseWaitCursor = true;
            // 
            // lblMedia
            // 
            this.lblMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMedia.Location = new System.Drawing.Point(50, 110);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(370, 26);
            this.lblMedia.TabIndex = 11;
            this.lblMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMedia.UseWaitCursor = true;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(311, 150);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 30);
            this.btSair.TabIndex = 10;
            this.btSair.Text = "&Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.UseWaitCursor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(160, 150);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(130, 30);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.UseWaitCursor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(20, 150);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(110, 30);
            this.btCalcular.TabIndex = 8;
            this.btCalcular.Text = "&Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.UseWaitCursor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(330, 80);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(100, 23);
            this.txtN4.TabIndex = 7;
            this.txtN4.UseWaitCursor = true;
            this.txtN4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN4_KeyDown);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(100, 80);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 23);
            this.txtN2.TabIndex = 6;
            this.txtN2.UseWaitCursor = true;
            this.txtN2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN2_KeyDown);
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(330, 40);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(100, 23);
            this.txtN3.TabIndex = 5;
            this.txtN3.UseWaitCursor = true;
            this.txtN3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN3_KeyDown);
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(100, 40);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 23);
            this.txtN1.TabIndex = 4;
            this.txtN1.UseWaitCursor = true;
            this.txtN1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN1_KeyDown);
            // 
            // lblN4
            // 
            this.lblN4.AutoSize = true;
            this.lblN4.Location = new System.Drawing.Point(245, 80);
            this.lblN4.Name = "lblN4";
            this.lblN4.Size = new System.Drawing.Size(62, 16);
            this.lblN4.TabIndex = 3;
            this.lblN4.Text = "4ª Nota";
            this.lblN4.UseWaitCursor = true;
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Location = new System.Drawing.Point(245, 45);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(62, 16);
            this.lblN3.TabIndex = 2;
            this.lblN3.Text = "3ª Nota";
            this.lblN3.UseWaitCursor = true;
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(15, 80);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(62, 16);
            this.lblN2.TabIndex = 1;
            this.lblN2.Text = "2ª Nota";
            this.lblN2.UseWaitCursor = true;
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(15, 45);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(62, 16);
            this.lblN1.TabIndex = 0;
            this.lblN1.Text = "1ª Nota";
            this.lblN1.UseWaitCursor = true;
            // 
            // FrmCalcMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 327);
            this.Controls.Add(this.gbOpcao);
            this.Controls.Add(this.lbTitulo);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmCalcMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cáculo da média";
            this.UseWaitCursor = true;
            this.gbOpcao.ResumeLayout(false);
            this.gbOpcao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbTitulo;
        private GroupBox gbOpcao;
        private Label lblN4;
        private Label lblN3;
        private Label lblN2;
        private Label lblN1;
        private TextBox txtN4;
        private TextBox txtN2;
        private TextBox txtN3;
        private TextBox txtN1;
        private Button btSair;
        private Button btCancelar;
        private Button btCalcular;
        private Label lblMedia;
    }
}