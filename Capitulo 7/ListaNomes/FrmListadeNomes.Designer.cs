namespace ListaNomes
{
    partial class FrmListadeNomes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lsNome = new System.Windows.Forms.ListBox();
            this.btAdiciona = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btRemoveTudo = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item para a Lista";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(146, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lsNome
            // 
            this.lsNome.FormattingEnabled = true;
            this.lsNome.ItemHeight = 14;
            this.lsNome.Location = new System.Drawing.Point(20, 73);
            this.lsNome.Name = "lsNome";
            this.lsNome.Size = new System.Drawing.Size(213, 270);
            this.lsNome.Sorted = true;
            this.lsNome.TabIndex = 2;
            this.lsNome.SelectedIndexChanged += new System.EventHandler(this.lsNome_SelectedIndexChanged);
            // 
            // btAdiciona
            // 
            this.btAdiciona.Location = new System.Drawing.Point(240, 70);
            this.btAdiciona.Name = "btAdiciona";
            this.btAdiciona.Size = new System.Drawing.Size(131, 32);
            this.btAdiciona.TabIndex = 3;
            this.btAdiciona.Text = "&Adicionar Item";
            this.btAdiciona.UseVisualStyleBackColor = true;
            this.btAdiciona.Click += new System.EventHandler(this.btAdiciona_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(240, 130);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(131, 32);
            this.btRemove.TabIndex = 4;
            this.btRemove.Text = "&Remover Item";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btRemoveTudo
            // 
            this.btRemoveTudo.Location = new System.Drawing.Point(240, 190);
            this.btRemoveTudo.Name = "btRemoveTudo";
            this.btRemoveTudo.Size = new System.Drawing.Size(131, 32);
            this.btRemoveTudo.TabIndex = 5;
            this.btRemoveTudo.Text = "Remover &Tudo";
            this.btRemoveTudo.UseVisualStyleBackColor = true;
            this.btRemoveTudo.Click += new System.EventHandler(this.btRemoveTudo_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(240, 250);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(131, 32);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "&Cancela";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(240, 310);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(131, 32);
            this.btSair.TabIndex = 7;
            this.btSair.Text = "&Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // FrmListadeNomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btRemoveTudo);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdiciona);
            this.Controls.Add(this.lsNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmListadeNomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Nomes";
            this.Load += new System.EventHandler(this.FrmListadeNomes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private ListBox lsNome;
        private Button btAdiciona;
        private Button btRemove;
        private Button btRemoveTudo;
        private Button btCancelar;
        private Button btSair;
    }
}