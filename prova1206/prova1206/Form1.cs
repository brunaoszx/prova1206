using System.Security.Permissions;

namespace prova1206
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string caminhoCsv = "C:\\Users\\arolc\\source\\repos\\prova1206\\dadosCsv";

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string admin = "ADMIN";
            string senha = "123";

            if(txtUsuario.Text == admin && txtSenha.Text == senha) 
            {
                MessageBox.Show($"Boas Vindas,{admin}!");
                Principal princ = new Principal();
                this.Hide();
                princ();
            }
        }
    }
}
