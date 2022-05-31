namespace CalculodaMedia
{
    public partial class FrmCalcMedia : Form
    {
                
        public FrmCalcMedia()
        {
            InitializeComponent();
        }
        #region Código do botão calcular
        private void btCalcular_Click(object sender, EventArgs e)
        {
            ClassCalculo valores = new ClassCalculo();
            double a = new double();
            double b = new double();
            double c = new double();
            double d = new double();
            double valor = new double();
            #region Entrada de dados
            try
            {

                string v1 = txtN1.Text;
                v1 = v1.Replace('.',',');
                a = double.Parse(v1);

                string v2 = txtN2.Text;
                v2 = v2.Replace('.', ',');
                b = double.Parse(v2);

                string v3 = txtN3.Text;
                v3 = v3.Replace('.', ',');
                c = double.Parse(v3);

                string v4 = txtN4.Text;
                v4 = v4.Replace('.', ',');
                d = double.Parse(v4);

                if(a < 0 || a > 10 || b < 0 || b > 10 || c < 0 || c > 10 || d < 0 || d > 10)
                {

                    MessageBox.Show("Entrada de notas inválidas\nDigite as notas novamente!!!",
                        "***** NOTAS INVÁLIDAS *****",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    limpar();

                }
                else
                {

                    valor = valores.Processar(a, b, c, d);
                    lblMedia.Text = "As média das notas :" + valor.ToString();

                }

            }
            catch (FormatException erro)
            {

                string mens = erro.Message;
                MessageBox.Show(mens + "\n A Entrada dos dados não esté em um formato correto!!!\nTente novamente...",
                    "***** ERRO *****",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                limpar();

            }
            #endregion
        }
        #endregion
        #region Código do Botão Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {

            limpar();

        }
        #endregion
        #region Procedimento para limpar os controles
        public void limpar()
        {

            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
            lblMedia.Text = " ";
            txtN1.Focus();


        }
        #endregion
        #region Còdigo do Botão Sair
        private void btSair_Click(object sender, EventArgs e)
        {

            ClassSair saida = new ClassSair();
            saida.fim();

        }
        #endregion
        #region Rotina da tecla <ENTER>
        private void txtN1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {

                txtN2.Focus();

            }

        }       

        private void txtN2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {

                txtN3.Focus();

            }

        }      

        private void txtN3_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {

                txtN4.Focus();

            }
            
        }        

        private void txtN4_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {

                btCalcular.Focus();

            }

        }
        #endregion
    }

}