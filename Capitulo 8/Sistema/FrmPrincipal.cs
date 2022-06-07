namespace Sistema
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Item de Menu Cálculo da Média
        private void calculoDaMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CalculodaMedia.FrmCalcMedia item1 = new CalculodaMedia.FrmCalcMedia();
            item1.MdiParent = this;
            item1.Show();

        }
        #endregion
        #region Item de Menu Classificar nomes
        private void classificarNomesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OrdenarNomes.FrmOrdenarNomes item2 = new OrdenarNomes.FrmOrdenarNomes();
            item2.MdiParent = this;
            item2.Show();

        }
        #endregion
        #region Item de Menu Lista de Nomes
        private void listaDeNomesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ListaNomes.FrmListadeNomes item3 = new ListaNomes.FrmListadeNomes();
            item3.MdiParent = this;
            item3.Show();

        }
        #endregion
        #region Item de Menu Visualizar Imagem
        private void visualizarImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Imagem.FrmImagem item4 = new Imagem.FrmImagem();
            item4.MdiParent = this;
            item4.Show();

        }
        #endregion
        #region Item de Menu Movimentar Imagem
        private void movimentarImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MoviTeclas.FrmMoviTeclas item5 = new MoviTeclas.FrmMoviTeclas();
            item5.MdiParent = this;
            item5.Show();
            item5.Text += " (Pressione a tecla Ctrl + setas)";

        }
        #endregion
        #region Item de Menu Relogio
        private void relogioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Relogio.FrmRelogio item6 = new Relogio.FrmRelogio();
            item6.MdiParent = this;
            item6.Show();

        }
        #endregion
        #region Item de Menu Sair do Programa
        private void sairDoProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string texto = "Deseja Sair do Programa ?";
            string titulo = "+++++++++++ FINALIZANDO ++++++++++";
            if (MessageBox.Show(texto,
                                titulo,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                Application.Exit();

            }

        }
        #endregion
        #region Item de PopUP Menu Cálculo da Média
        private void cálculoDaMédiaToolStripMenuItem4_Click(object sender, EventArgs e)
        {

            CalculodaMedia.FrmCalcMedia item1 = new CalculodaMedia.FrmCalcMedia();
            item1.MdiParent = this;
            item1.Show();

        }
        #endregion
        #region Item de PopUp Menu Classificar Nomes
        private void classificarNomesToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            OrdenarNomes.FrmOrdenarNomes item2 = new OrdenarNomes.FrmOrdenarNomes();
            item2.MdiParent = this;
            item2.Show();

        }
        #endregion
        #region Item de PopUp Menu Lista de Nomes
        private void listaDeNomesToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            ListaNomes.FrmListadeNomes item3 = new ListaNomes.FrmListadeNomes();
            item3.MdiParent = this;
            item3.Show();

        }
        #endregion
        #region Item de PopUp Menu Movimentar Imagem
        private void movimentarImagemToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            MoviTeclas.FrmMoviTeclas item5 = new MoviTeclas.FrmMoviTeclas();
            item5.MdiParent = this;
            item5.Show();
            

        }
        #endregion
        #region Item de PopUp Menu Visualizar Imagem
        private void visualizarImagemToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Imagem.FrmImagem item4 = new Imagem.FrmImagem();
            item4.MdiParent = this;
            item4.Show();

        }
        #endregion
        #region Item de PopUp Menu Relogio
        private void relógioToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Relogio.FrmRelogio item6 = new Relogio.FrmRelogio();
            item6.MdiParent = this;
            item6.Show();

        }
        #endregion
        #region Item de PopUp Menu Sair do Programa
        private void sairDoProgramaToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            string texto = "Deseja Sair do Programa ?";
            string titulo = "+++++++++++ FINALIZANDO ++++++++++";
            if (MessageBox.Show(texto,
                                titulo,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                Application.Exit();

            }

        }
        #endregion
        #region Código da Barra de Status
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            string dataCompleta = DateTime.Now.ToLongDateString();
            string Semana = dataCompleta.Substring(0, 1).ToUpper() + dataCompleta.Substring(1, dataCompleta.Length - 1);
            toolStripStatusData.Text = Semana;
            Timer1.Enabled = true;
        }
        #endregion
        #region Código de Timer
        private void Timer1_Tick(object sender, EventArgs e)
        {

            toolStripStatusHora.Text = DateTime.Now.ToLongTimeString();

        }
        #endregion

    }

}