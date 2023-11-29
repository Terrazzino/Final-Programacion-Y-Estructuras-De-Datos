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
            FormConcesionaria concecionaria = new FormConcesionaria();
            concecionaria.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            FormConcecionaria empresa = new FormConcecionaria();
            empresa.Show();
        }
    }
}