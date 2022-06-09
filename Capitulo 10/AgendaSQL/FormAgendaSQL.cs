using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class FrmAgendaSQL : Form
    {
        public FrmAgendaSQL()
        {
            InitializeComponent();
        }

        private void tabAgendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabAgendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroAgendaSQLDataSet);

        }

        private void FrmAgendaSQL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroAgendaSQLDataSet.TabAgenda' table. You can move, or remove it, as needed.
            this.tabAgendaTableAdapter.Fill(this.cadastroAgendaSQLDataSet.TabAgenda);

        }

        private void tabAgendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
