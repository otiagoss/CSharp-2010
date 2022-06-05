namespace ListaNomes
{
    public partial class FrmListadeNomes : Form
    {
        public FrmListadeNomes()
        {
            InitializeComponent();
        }           

        private void btAdiciona_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            lsNome.Items.Add(txtNome.Text);
            txtNome.Clear();
            txtNome.Focus();

        }

        private void btRemove_Click(object sender, EventArgs e)
        {

            int valor = lsNome.SelectedIndex;
            if (valor == -1)
            {

                MessageBox.Show("Para excluir um item da lista \né necessário primeiro selecionalo, OK!",
                                "***** Excluindo item da lista *****",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                btRemove.Enabled = false;
                txtNome.Focus();

            }
            else
            {

                lsNome.Items.RemoveAt(valor);

            }

        }

        private void btRemoveTudo_Click(object sender, EventArgs e)
        {

            if (lsNome.Items.Count == 0)
            {

                MessageBox.Show("A lista está vazia !!!\nAdicione primeiro o item \ne depois selecione para removê-lo",
                                "***** Excluindo item da lista *****",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtNome.Focus();

            }
            else
            {

                btRemove.Enabled = false;
                lsNome.Items.Clear();
                txtNome.Focus();

            }


        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

            txtNome.Clear();
            txtNome.Focus();

        }

        private void btSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja sair do programa ?",
                                "***** Finalizando Programa *****",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();

            }
            else
            {

                txtNome.Clear();
                txtNome.Focus();

            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

            btRemove.Enabled = true;

        }

        private void FrmListadeNomes_Load(object sender, EventArgs e)
        {

            btRemove.Enabled = false;

        }

        private void lsNome_SelectedIndexChanged(object sender, EventArgs e)
        {

            btRemove.Enabled = true;

        }
    }

}