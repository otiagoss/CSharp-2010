namespace Relogio
{
    public partial class FrmRelogio : Form
    {
        public FrmRelogio()
        {
            InitializeComponent();
        }

        private void FrmRelogio_Load(object sender, EventArgs e)
        {

            lblData.Text = DateTime.Now.ToLongDateString();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            lblRelogio.Text = DateTime.Now.ToLongTimeString();

        }
    }
}