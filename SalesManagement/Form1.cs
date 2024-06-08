namespace SalesManagement
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormInicial formInicial = new FormInicial();
            formInicial.Show();

            this.Hide();
        }
    }
}
