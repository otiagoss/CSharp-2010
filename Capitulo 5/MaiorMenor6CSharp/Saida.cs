using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MaiorMenor6CSharp
{
    internal class Saida
    {

        public void fim()
        {

            string texto = "Deseja saior do Programa de Verificação dos Números?";
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

    }
}
