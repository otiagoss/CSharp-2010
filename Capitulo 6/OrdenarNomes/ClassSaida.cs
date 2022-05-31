using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarNomes
{
    internal class ClassSaida
    {
        public void final()
        {

            string texto = "Deseja finalizar o Programa";
            string titulo = "*****  FIM DO PROGRAMA *****";
            if (MessageBox.Show(texto,titulo,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                Application.Exit();

            }


        }

    }

}
