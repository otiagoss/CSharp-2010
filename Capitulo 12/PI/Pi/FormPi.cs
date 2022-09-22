using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pi
{
    public partial class FrmClasseMath : Form
    {
        public FrmClasseMath()
        {
            InitializeComponent();
        }

        private void FrmClasseMath_Load(object sender, EventArgs e)
        {
              
            textPI.Text = Math.Round(Math.PI,4).ToString();

        }
    }
}
