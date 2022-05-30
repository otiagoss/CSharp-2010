namespace VerificarNumeros
{
    public partial class FrmVerifica : Form
    {
        public FrmVerifica()
        {
            InitializeComponent();
        }

        private void btVerifica_Click(object sender, EventArgs e)
        {

            try
            {
                int n = 0;
                n = int.Parse(txtnum.Text);
                if (n % 2 == 0)
                {

                    lblresultado.Text = "O número " + n.ToString() + " é Par";

                }
                else
                {

                    lblresultado.Text = "O número " + n.ToString() + " é Impar";

                }

            }
            catch (FormatException erro)
            {

                string mensagem = erro.Message + "\nSequencia digitada não está no formato correto";
                MessageBox.Show(mensagem + "\nPor favor tente novamente!!!",
                                "##### ERRO #####",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Hand,
                                MessageBoxDefaultButton.Button1);
                txtnum.Clear();
                lblresultado.Text = "";
                txtnum.Focus();

            }

        }

        private void btCancela_Click(object sender, EventArgs e)
        {

            txtnum.Clear();
            lblresultado.Text = "";
            txtnum.Focus();

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do programa?",
                "***** FINALIZANDO *****",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                this.Close();

            }
            else
            {

                txtnum.Clear();
                lblresultado.Text = "";
                txtnum.Focus();

            }
        }
    }
}