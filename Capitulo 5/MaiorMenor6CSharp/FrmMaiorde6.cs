namespace MaiorMenor6CSharp
{
    public partial class FrmMaiorde6 : Form
    {

        int n1, n2, n3, n4, n5, n6, maior = 0;
        string mensagem = "";        
        public FrmMaiorde6()
        {
            InitializeComponent();
        }
        #region "Entrada de Dados"        
        private void btVerifica_Click(object sender, EventArgs e)
        {

            try
            {

                n1 = int.Parse(txtn1.Text);
                n2 = int.Parse(txtn2.Text);
                n3 = int.Parse(txtn3.Text);
                n4 = int.Parse(txtn4.Text);
                n5 = int.Parse(txtn5.Text);
                n6 = int.Parse(txtn6.Text);
                Testar();
                lblResultado.Text = mensagem;
                

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message + "\n Sequência de entrada não está no formato correto ...\nTente novamente...",
                    "***** ERRO *****",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    Cancelar();

            }

        }
        #endregion
        #region "Procedimento Testar"
        public void Testar()
        {

            if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5 && n1 > n6)
            {

                maior = n1;
                mensagem = "O maior número é "+ maior.ToString();

            }
            else if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5 && n2 > n6)
            {

                maior = n2;
                mensagem = "O maior número é " + maior.ToString();

            }
            else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5 && n3 > n6)
            {

                maior = n3;
                mensagem = "O maior número é " + maior.ToString();

            }
            else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5 && n4 > n6)
            {

                maior = n4;
                mensagem = "O maior número é " + maior.ToString();

            }
            else if (n5 > n1 && n5 > n2 && n5 > n3 && n5 > n4 && n5 > n6)
            {

                maior = n5;
                mensagem = "O maior número é " + maior.ToString();

            }
            else if (n6 > n1 && n6 > n2 && n6 > n3 && n6 > n4 && n6 > n5)
            {

                maior = n1;
                mensagem = "O maior número é " + maior.ToString();

            }
            else if (n1 == n2 && n3 == n4 && n5 == n6)
            {
                                
                mensagem = " Todos os números são iguais";

            } 
            else if (n1 == n2 || n3 == n4 || n5 == n6)
            {

                mensagem = "Existem números iguais na sequência.";

            }

        }
        #endregion
        #region "Procedimento Cancelar"
        public void Cancelar()
        {

            txtn1.Clear();
            txtn2.Clear();
            txtn3.Clear();
            txtn4.Clear();
            txtn5.Clear();
            txtn6.Clear();
            lblResultado.Text = "";
            txtn1.Focus();

        }

        private void btCancela_Click(object sender, EventArgs e)
        {

            Cancelar();

        }

        private void btSair_Click(object sender, EventArgs e)
        {

            Saida final = new Saida();
            final.fim();

        }
        #endregion
        #region "Rotina de Tecla <ENTER>"
        private void txtn1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {

                txtn2.Focus();

            }

        }
        private void txtn2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {

                txtn3.Focus();

            }
        }
        private void txtn3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {

                txtn4.Focus();

            }
        }
        private void txtn4_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {

                txtn5.Focus();

            }

        }
        private void txtn5_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {

                txtn6.Focus();

            }

        }
        private void txtn6_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {

                btVerifica.Focus();

            }

        }
        #endregion
    }
}