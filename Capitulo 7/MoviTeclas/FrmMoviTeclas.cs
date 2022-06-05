namespace MoviTeclas
{
    public partial class FrmMoviTeclas : Form
    {
        public FrmMoviTeclas()
        {
            InitializeComponent();
        }

        private void FrmMoviTeclas_KeyDown(object sender, KeyEventArgs e)
        {
            #region Mover para esquerda
            if (e.KeyCode == Keys.Left)
            {

                if ( ImgLogo.Location.X > -99)
                {

                    ImgLogo.Left -= 10;

                }
                else
                {

                    ImgLogo.Left = 615;

                }

            }
            #endregion
            #region Mover para cima
            if (e.KeyCode == Keys.Up)
            {

                if (ImgLogo.Location.Y > -94)
                {

                    ImgLogo.Top -= 10;

                }
                else
                {

                    ImgLogo.Top = 514;

                }

            }
            #endregion
            #region Mover para direita
            if (e.KeyCode == Keys.Right)
            {

                if (ImgLogo.Location.X < 615)
                {

                    ImgLogo.Left += 10;

                }
                else
                {

                    ImgLogo.Left = -99;

                }

            }
            #endregion
            #region Mover para baixo
            if (e.KeyCode == Keys.Down)
            {

                if (ImgLogo.Location.Y < 514)
                {

                    ImgLogo.Top += 10;

                }
                else
                {

                    ImgLogo.Top = -94;

                }

            }
            #endregion
        }
    }
}