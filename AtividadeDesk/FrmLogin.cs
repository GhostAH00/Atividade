using AtividadeClasse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeDesk
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Capturar os dados digitados pelo usuário
            string nome = txtNome.Text;
            string senha = txtSenha.Text;


            // Verificar se os campos estão preenchidos        
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos antes de entrar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chamar método para validar login
            Usuario usuario = Usuario.ValidarLogin(nome, senha);
            if (usuario != null)
            {
                MessageBox.Show($"Bem-vindo, {usuario.Nome}!", "Login bem-sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aqui você pode abrir a tela principal do sistema, por exemplo:
                FrmRegistro frm = new FrmRegistro();
                frm.Show();
                this.Hide(); // Esconde a tela de login após sucesso
            }
            else
            {
                MessageBox.Show("Nome ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

       
    }
}
