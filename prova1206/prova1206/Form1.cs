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

            if (txtUsuario.Text == admin && txtSenha.Text == senha)
            {
                MessageBox.Show($"Boas Vindas,{admin}!");
                Principal princ = new Principal();
                this.Hide();
                princ.Show();
            }
            else
            {
                string[] linhas = File.ReadAllLines( caminhoCsv );
                foreach(string linha in linhas) 
                {
                    string[] dados = linha.Split(';');

                    string usuario = dados[0].Trim();
                    string senhaUsuario = dados[0].Trim();
                    if(txtUsuario.Text == usuario && txtSenha.Text ==senhaUsuario)
                    {
                        MessageBox.Show($"Boas Vindas{usuario}!");
                        Principal princ = new Principal();
                        this.Hide();
                        princ.Show();
                    }

                }
                    
            }
        }
    }
}
