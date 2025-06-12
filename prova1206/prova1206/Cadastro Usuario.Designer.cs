namespace prova1206
{
    partial class Cadastro_Usuario
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
            label1 = new Label();
            label2 = new Label();
            txtUsuario2 = new TextBox();
            txtSenha2 = new TextBox();
            btnCadastrar2 = new Button();
            label3 = new Label();
            label4 = new Label();
            txtNovaSenha = new TextBox();
            btnNovaSenha = new Button();
            btnExcluirUsuario = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 38);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 38);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // txtUsuario2
            // 
            txtUsuario2.Location = new Point(34, 56);
            txtUsuario2.Name = "txtUsuario2";
            txtUsuario2.Size = new Size(100, 23);
            txtUsuario2.TabIndex = 2;
            // 
            // txtSenha2
            // 
            txtSenha2.Location = new Point(151, 56);
            txtSenha2.Name = "txtSenha2";
            txtSenha2.Size = new Size(100, 23);
            txtSenha2.TabIndex = 3;
            // 
            // btnCadastrar2
            // 
            btnCadastrar2.Location = new Point(34, 85);
            btnCadastrar2.Name = "btnCadastrar2";
            btnCadastrar2.Size = new Size(217, 23);
            btnCadastrar2.TabIndex = 4;
            btnCadastrar2.Text = "Cadastrar";
            btnCadastrar2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 118);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Editar Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 144);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Nova Senha";
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(34, 162);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(100, 23);
            txtNovaSenha.TabIndex = 7;
            // 
            // btnNovaSenha
            // 
            btnNovaSenha.Location = new Point(34, 195);
            btnNovaSenha.Name = "btnNovaSenha";
            btnNovaSenha.Size = new Size(99, 23);
            btnNovaSenha.TabIndex = 8;
            btnNovaSenha.Text = "Atualizar";
            btnNovaSenha.UseVisualStyleBackColor = true;
            // 
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.Location = new Point(152, 195);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.Size = new Size(99, 23);
            btnExcluirUsuario.TabIndex = 12;
            btnExcluirUsuario.Text = "Excluir Usuário";
            btnExcluirUsuario.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 144);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 10;
            label5.Text = "Usuário";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 118);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 9;
            label6.Text = "Editar Usuário";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(320, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(314, 162);
            dataGridView1.TabIndex = 13;
            // 
            // Cadastro_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnExcluirUsuario);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(btnNovaSenha);
            Controls.Add(txtNovaSenha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCadastrar2);
            Controls.Add(txtSenha2);
            Controls.Add(txtUsuario2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro_Usuario";
            Text = "Cadastro_Usuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario2;
        private TextBox txtSenha2;
        private Button btnCadastrar2;
        private Label label3;
        private Label label4;
        private TextBox txtNovaSenha;
        private Button btnNovaSenha;
        private Button btnExcluirUsuario;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
    }
}