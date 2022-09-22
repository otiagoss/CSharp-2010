using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String
{
    public partial class FrmClassString : Form
    {
        public FrmClassString()
        {
            InitializeComponent();
        }

        private void FrmClassString_Load(object sender, EventArgs e)
        {

            string texto = "Estudo de classes em C# 2010 Express";
            int tamaho = texto.Length;
            label4.Text = texto;
            label5.Text = tamaho.ToString();
            label6.Text = texto.Substring(10,1).ToUpper()+texto.Substring(11,12);

        }

    }

}
