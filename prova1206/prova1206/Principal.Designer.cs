namespace prova1206
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastroProd = new Button();
            btnCadastroPedidos = new Button();
            btnCadastroUsuarios = new Button();
            btnCadastroCliente = new Button();
            btnConsultarPedidos = new Button();
            SuspendLayout();
            // 
            // btnCadastroProd
            // 
            btnCadastroProd.Location = new Point(80, 69);
            btnCadastroProd.Name = "btnCadastroProd";
            btnCadastroProd.Size = new Size(121, 23);
            btnCadastroProd.TabIndex = 0;
            btnCadastroProd.Text = "Cadastro Produtos";
            btnCadastroProd.UseVisualStyleBackColor = true;
            // 
            // btnCadastroPedidos
            // 
            btnCadastroPedidos.Location = new Point(80, 109);
            btnCadastroPedidos.Name = "btnCadastroPedidos";
            btnCadastroPedidos.Size = new Size(121, 23);
            btnCadastroPedidos.TabIndex = 1;
            btnCadastroPedidos.Text = "Cadastro Pedidos";
            btnCadastroPedidos.UseVisualStyleBackColor = true;
            // 
            // btnCadastroUsuarios
            // 
            btnCadastroUsuarios.Location = new Point(80, 152);
            btnCadastroUsuarios.Name = "btnCadastroUsuarios";
            btnCadastroUsuarios.Size = new Size(121, 23);
            btnCadastroUsuarios.TabIndex = 2;
            btnCadastroUsuarios.Text = "Cadastro Usuário";
            btnCadastroUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.Location = new Point(80, 28);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(121, 23);
            btnCadastroCliente.TabIndex = 3;
            btnCadastroCliente.Text = "Cadastro Cliente";
            btnCadastroCliente.UseVisualStyleBackColor = true;
            // 
            // btnConsultarPedidos
            // 
            btnConsultarPedidos.Location = new Point(80, 195);
            btnConsultarPedidos.Name = "btnConsultarPedidos";
            btnConsultarPedidos.Size = new Size(121, 23);
            btnConsultarPedidos.TabIndex = 4;
            btnConsultarPedidos.Text = "Consultar Pedidos";
            btnConsultarPedidos.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsultarPedidos);
            Controls.Add(btnCadastroCliente);
            Controls.Add(btnCadastroUsuarios);
            Controls.Add(btnCadastroPedidos);
            Controls.Add(btnCadastroProd);
            Name = "Principal";
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastroProd;
        private Button btnCadastroPedidos;
        private Button btnCadastroUsuarios;
        private Button btnCadastroCliente;
        private Button btnConsultarPedidos;
    }
}