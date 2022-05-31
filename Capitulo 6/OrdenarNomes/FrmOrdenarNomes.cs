namespace OrdenarNomes
{
    public partial class FrmOrdenarNomes : Form
    {
        public FrmOrdenarNomes()
        {
            InitializeComponent();
        }
        #region Classificar nomes
        private void btClassificar_Click(object sender, EventArgs e)
        {

            string[] nomes = new string[5];
            string aux;
            nomes[0] = txtNome1.Text;
            nomes[1] = txtNome2.Text;
            nomes[2] = txtNome3.Text;
            nomes[3] = txtNome4.Text;
            nomes[4] = txtNome5.Text;

            for (int j = 0; j <= 4; j++)
            {

                if (nomes[j].Length >= 15)
                {

                    label7.Font = new Font("Arial Narrow", 10, System.Drawing.FontStyle.Bold);

                }

            }
            //ordena lista
            for (int i = 0; i <= 4;i++)
            {

                for (int j = i + 1; j <= 4; j++)
                {

                    if (String.CompareOrdinal(nomes[i], nomes[j]) > 0)
                    {

                        aux = nomes[i];
                        nomes[i] = nomes[j];
                        nomes[j] = aux;

                    }

                }

            }
                       
            //exibir a lista no rótulo de saída
            groupBox2.Visible = true;
            for (int x = 0; x <= 4; x++)
            {
               
                label7.Text += "\n" + nomes[x] + "\n";

            }            
            
        }
        #endregion
        #region Código do Botão Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {

            Cancelar();

        }
        #endregion
        #region Código do Procedimento Cancelar()
        public void Cancelar()
        {

            txtNome1.Clear();
            txtNome2.Clear();
            txtNome3.Clear();
            txtNome4.Clear();
            txtNome5.Clear();
            txtNome1.Focus();
            label7.Text = " ";
            groupBox2.Visible = false;
            label7.Font = new Font("Verdana",9,System.Drawing.FontStyle.Bold);


        }
        #endregion
        #region Código do Botão Sair
        private void btFechar_Click(object sender, EventArgs e)
        {

            ClassSaida saida = new ClassSaida();
            saida.final();

        }
        #endregion
        #region Simulando a tecla TAB pelo <ENTER>
        private void txtNome1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {

                txtNome2.Focus();

            }

        }      
        private void txtNome2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {

                txtNome3.Focus();

            }

        }
        private void txtNome3_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {

                txtNome4.Focus();

            }

        }
        private void txtNome4_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {

                txtNome5.Focus();

            }

        }
        #endregion
        private void txtNome5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {

                btClassificar.Focus();

            }
        }
        #region Código de Entrada
        private void FrmOrdenarNomes_Activated(object sender, EventArgs e)
        {

            groupBox2.Visible = false;
            txtNome1.Focus();            

        }
        #endregion
    }

}