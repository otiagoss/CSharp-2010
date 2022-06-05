namespace Imagem
{
    partial class FrmImagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImagem));
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.brAbrir = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.dgAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagem
            // 
            resources.ApplyResources(this.picImagem, "picImagem");
            this.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImagem.Name = "picImagem";
            this.picImagem.TabStop = false;
            // 
            // brAbrir
            // 
            resources.ApplyResources(this.brAbrir, "brAbrir");
            this.brAbrir.Name = "brAbrir";
            this.brAbrir.UseVisualStyleBackColor = true;
            this.brAbrir.Click += new System.EventHandler(this.brAbrir_Click);
            // 
            // btSair
            // 
            resources.ApplyResources(this.btSair, "btSair");
            this.btSair.Name = "btSair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // dgAbrir
            // 
            resources.ApplyResources(this.dgAbrir, "dgAbrir");
            this.dgAbrir.InitialDirectory = "\\Users\\Public\\Pictures\\";
            // 
            // FrmImagem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.brAbrir);
            this.Controls.Add(this.picImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImagem";
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picImagem;
        private Button brAbrir;
        private Button btSair;
        private OpenFileDialog dgAbrir;
    }
}