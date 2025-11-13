namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = OpenFileDialog1.FileName;
                FileStream fs = null;
                try
                {
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    miEmpresa.ImportarTransporte(fs);
                }
                catch (Exception ex) { }
                finally { }
            }
        }
    }
}