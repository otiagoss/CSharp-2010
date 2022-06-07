namespace Sistema
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDaMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificarNomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeNomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentarImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relogioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairDoProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PopMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cálculoDaMédiaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.classificarNomesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeNomesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentarImagemToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarImagemToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.relógioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairDoProgramaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.PopMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(914, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculoDaMediaToolStripMenuItem,
            this.classificarNomesToolStripMenuItem,
            this.listaDeNomesToolStripMenuItem,
            this.movimentarImagemToolStripMenuItem,
            this.visualizarImagemToolStripMenuItem,
            this.relogioToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairDoProgramaToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "&Opções";
            // 
            // calculoDaMediaToolStripMenuItem
            // 
            this.calculoDaMediaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculoDaMediaToolStripMenuItem.Image = global::Sistema.Properties.Resources.Imagem1;
            this.calculoDaMediaToolStripMenuItem.Name = "calculoDaMediaToolStripMenuItem";
            this.calculoDaMediaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.calculoDaMediaToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.calculoDaMediaToolStripMenuItem.Text = "Cálculo da Média";
            this.calculoDaMediaToolStripMenuItem.Click += new System.EventHandler(this.calculoDaMediaToolStripMenuItem_Click);
            // 
            // classificarNomesToolStripMenuItem
            // 
            this.classificarNomesToolStripMenuItem.Image = global::Sistema.Properties.Resources.Imagem2;
            this.classificarNomesToolStripMenuItem.Name = "classificarNomesToolStripMenuItem";
            this.classificarNomesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.classificarNomesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.classificarNomesToolStripMenuItem.Text = "Classificar Nomes";
            this.classificarNomesToolStripMenuItem.Click += new System.EventHandler(this.classificarNomesToolStripMenuItem_Click);
            // 
            // listaDeNomesToolStripMenuItem
            // 
            this.listaDeNomesToolStripMenuItem.Image = global::Sistema.Properties.Resources.Imagem3;
            this.listaDeNomesToolStripMenuItem.Name = "listaDeNomesToolStripMenuItem";
            this.listaDeNomesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listaDeNomesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.listaDeNomesToolStripMenuItem.Text = "Lista de Nomes";
            this.listaDeNomesToolStripMenuItem.Click += new System.EventHandler(this.listaDeNomesToolStripMenuItem_Click);
            // 
            // movimentarImagemToolStripMenuItem
            // 
            this.movimentarImagemToolStripMenuItem.Image = global::Sistema.Properties.Resources.Imagem4;
            this.movimentarImagemToolStripMenuItem.Name = "movimentarImagemToolStripMenuItem";
            this.movimentarImagemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.movimentarImagemToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.movimentarImagemToolStripMenuItem.Text = "Movimentar Imagem";
            this.movimentarImagemToolStripMenuItem.Click += new System.EventHandler(this.movimentarImagemToolStripMenuItem_Click);
            // 
            // visualizarImagemToolStripMenuItem
            // 
            this.visualizarImagemToolStripMenuItem.Image = global::Sistema.Properties.Resources.Imagem5;
            this.visualizarImagemToolStripMenuItem.Name = "visualizarImagemToolStripMenuItem";
            this.visualizarImagemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.visualizarImagemToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.visualizarImagemToolStripMenuItem.Text = "Visualizar Imagem";
            this.visualizarImagemToolStripMenuItem.Click += new System.EventHandler(this.visualizarImagemToolStripMenuItem_Click);
            // 
            // relogioToolStripMenuItem
            // 
            this.relogioToolStripMenuItem.Image = global::Sistema.Properties.Resources.Imagem6;
            this.relogioToolStripMenuItem.Name = "relogioToolStripMenuItem";
            this.relogioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.relogioToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.relogioToolStripMenuItem.Text = "Relógio";
            this.relogioToolStripMenuItem.Click += new System.EventHandler(this.relogioToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // sairDoProgramaToolStripMenuItem
            // 
            this.sairDoProgramaToolStripMenuItem.Image = global::Sistema.Properties.Resources.Imagem7;
            this.sairDoProgramaToolStripMenuItem.Name = "sairDoProgramaToolStripMenuItem";
            this.sairDoProgramaToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.sairDoProgramaToolStripMenuItem.Text = "Sair do Programa";
            this.sairDoProgramaToolStripMenuItem.Click += new System.EventHandler(this.sairDoProgramaToolStripMenuItem_Click);
            // 
            // PopMenu
            // 
            this.PopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cálculoDaMédiaToolStripMenuItem4,
            this.classificarNomesToolStripMenuItem3,
            this.listaDeNomesToolStripMenuItem2,
            this.movimentarImagemToolStripMenuItem2,
            this.visualizarImagemToolStripMenuItem2,
            this.relógioToolStripMenuItem2,
            this.toolStripSeparator2,
            this.sairDoProgramaToolStripMenuItem2});
            this.PopMenu.Name = "PopMenu";
            this.PopMenu.Size = new System.Drawing.Size(187, 164);
            // 
            // cálculoDaMédiaToolStripMenuItem4
            // 
            this.cálculoDaMédiaToolStripMenuItem4.Image = global::Sistema.Properties.Resources.Imagem1;
            this.cálculoDaMédiaToolStripMenuItem4.Name = "cálculoDaMédiaToolStripMenuItem4";
            this.cálculoDaMédiaToolStripMenuItem4.Size = new System.Drawing.Size(186, 22);
            this.cálculoDaMédiaToolStripMenuItem4.Text = "Cálculo da Média";
            this.cálculoDaMédiaToolStripMenuItem4.Click += new System.EventHandler(this.cálculoDaMédiaToolStripMenuItem4_Click);
            // 
            // classificarNomesToolStripMenuItem3
            // 
            this.classificarNomesToolStripMenuItem3.Image = global::Sistema.Properties.Resources.Imagem2;
            this.classificarNomesToolStripMenuItem3.Name = "classificarNomesToolStripMenuItem3";
            this.classificarNomesToolStripMenuItem3.Size = new System.Drawing.Size(186, 22);
            this.classificarNomesToolStripMenuItem3.Text = "Classificar Nomes";
            this.classificarNomesToolStripMenuItem3.Click += new System.EventHandler(this.classificarNomesToolStripMenuItem3_Click);
            // 
            // listaDeNomesToolStripMenuItem2
            // 
            this.listaDeNomesToolStripMenuItem2.Image = global::Sistema.Properties.Resources.Imagem3;
            this.listaDeNomesToolStripMenuItem2.Name = "listaDeNomesToolStripMenuItem2";
            this.listaDeNomesToolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.listaDeNomesToolStripMenuItem2.Text = "Lista de Nomes";
            this.listaDeNomesToolStripMenuItem2.Click += new System.EventHandler(this.listaDeNomesToolStripMenuItem2_Click);
            // 
            // movimentarImagemToolStripMenuItem2
            // 
            this.movimentarImagemToolStripMenuItem2.Image = global::Sistema.Properties.Resources.Imagem4;
            this.movimentarImagemToolStripMenuItem2.Name = "movimentarImagemToolStripMenuItem2";
            this.movimentarImagemToolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.movimentarImagemToolStripMenuItem2.Text = "Movimentar Imagem";
            this.movimentarImagemToolStripMenuItem2.Click += new System.EventHandler(this.movimentarImagemToolStripMenuItem2_Click);
            // 
            // visualizarImagemToolStripMenuItem2
            // 
            this.visualizarImagemToolStripMenuItem2.Image = global::Sistema.Properties.Resources.Imagem5;
            this.visualizarImagemToolStripMenuItem2.Name = "visualizarImagemToolStripMenuItem2";
            this.visualizarImagemToolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.visualizarImagemToolStripMenuItem2.Text = "Visualizar Imagem";
            this.visualizarImagemToolStripMenuItem2.Click += new System.EventHandler(this.visualizarImagemToolStripMenuItem2_Click);
            // 
            // relógioToolStripMenuItem2
            // 
            this.relógioToolStripMenuItem2.Image = global::Sistema.Properties.Resources.Imagem6;
            this.relógioToolStripMenuItem2.Name = "relógioToolStripMenuItem2";
            this.relógioToolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.relógioToolStripMenuItem2.Text = "Relógio";
            this.relógioToolStripMenuItem2.Click += new System.EventHandler(this.relógioToolStripMenuItem2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // sairDoProgramaToolStripMenuItem2
            // 
            this.sairDoProgramaToolStripMenuItem2.Image = global::Sistema.Properties.Resources.Imagem7;
            this.sairDoProgramaToolStripMenuItem2.Name = "sairDoProgramaToolStripMenuItem2";
            this.sairDoProgramaToolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.sairDoProgramaToolStripMenuItem2.Text = "Sair do Programa";
            this.sairDoProgramaToolStripMenuItem2.Click += new System.EventHandler(this.sairDoProgramaToolStripMenuItem2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusData,
            this.toolStripStatusHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = " - ";
            // 
            // toolStripStatusData
            // 
            this.toolStripStatusData.Name = "toolStripStatusData";
            this.toolStripStatusData.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusData.Text = "Data";
            // 
            // toolStripStatusHora
            // 
            this.toolStripStatusHora.Name = "toolStripStatusHora";
            this.toolStripStatusHora.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusHora.Text = "Hora";
            // 
            // Timer1
            // 
            this.Timer1.Interval = 10;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 420);
            this.ContextMenuStrip = this.PopMenu;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPrincipal";
            this.Text = "Programa em Visual C# 2010 Express";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.PopMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem calculoDaMediaToolStripMenuItem;
        private ToolStripMenuItem classificarNomesToolStripMenuItem;
        private ToolStripMenuItem listaDeNomesToolStripMenuItem;
        private ToolStripMenuItem movimentarImagemToolStripMenuItem;
        private ToolStripMenuItem visualizarImagemToolStripMenuItem;
        private ToolStripMenuItem relogioToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem sairDoProgramaToolStripMenuItem;
        private ContextMenuStrip PopMenu;
        private ToolStripMenuItem cálculoDaMédiaToolStripMenuItem4;
        private ToolStripMenuItem classificarNomesToolStripMenuItem3;
        private ToolStripMenuItem listaDeNomesToolStripMenuItem2;
        private ToolStripMenuItem movimentarImagemToolStripMenuItem2;
        private ToolStripMenuItem visualizarImagemToolStripMenuItem2;
        private ToolStripMenuItem relógioToolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sairDoProgramaToolStripMenuItem2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusData;
        private ToolStripStatusLabel toolStripStatusHora;
        private System.Windows.Forms.Timer Timer1;
    }
}