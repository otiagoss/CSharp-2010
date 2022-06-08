using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class FormAgenda : Form
    {
        public FormAgenda()
        {
            InitializeComponent();
        }

        private void tabCadastroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabCadastroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroDataSet.TabCadastro' table. You can move, or remove it, as needed.
            this.tabCadastroTableAdapter.Fill(this.cadastroDataSet.TabCadastro);

        }
    }
}
