namespace tpFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConcesionaria_Click(object sender, EventArgs e)
        {
            FormEmpresa empresa = new FormEmpresa();
            empresa.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            FormConcecionaria concecionaria = new FormConcecionaria();
            concecionaria.Show();
        }
    }
}