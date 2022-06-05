namespace Imagem
{
    public partial class FrmImagem : Form
    {
        public FrmImagem()
        {

            InitializeComponent();

        }        
        #region Abrir imagem
        private void brAbrir_Click(object sender, EventArgs e)
        {
            try
            {

                dgAbrir.ShowDialog();
                if (dgAbrir.FileName != "")
                {

                    picImagem.Load(dgAbrir.FileName);

                }

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message + "\nO arquivo selecionado não é um arquivo de imagem",
                                "***** ERRO DE ARQUIVO *****",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);

            }

        }
        #endregion
        #region Sair do aplicativo
        private void btSair_Click(object sender, EventArgs e)
        {

            string texto = "Deseja sair do programa ?";
            string cabec = "***** Finalizando o  aplicativo *****";
            bool resposta = MessageBox.Show(texto, 
                                            cabec, 
                                            MessageBoxButtons.YesNo, 
                                            MessageBoxIcon.Question, 
                                            MessageBoxDefaultButton.Button1) == DialogResult.Yes;
            if (resposta == true) 
            {

               this.Close();               

            }

        }
        #endregion
    }

}