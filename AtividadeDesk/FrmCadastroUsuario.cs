using AtividadeClasse;

namespace AtividadeDesk
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        // Validação e Cadastro do Usuário
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // string.IsNullOrEmpty(nome) -> Verifica apenas se é nulo ou vazio,
            // mas não detecta espaços em branco.

            // Verificar se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(maskedTxtCPF.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                CmbBoxTipo.SelectedIndex == -1)
            {
                // MessageBoxIcon.Warning -> Ele é utilizado para avisar o usuário sobre algo importante, como um erro ou ação crítica.
                // MessageBoxButtons.OK -> exibir apenas um botão "OK" na caixa de diálogo
                MessageBox.Show("Por favor, preencha todos os campos antes de confirmar o cadastro!",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return; // Se algum campo estiver vazio, a execução para (return;) e exibe uma mensagem de alerta
            }

            // Validar o CPF
            if (maskedTxtCPF.Text.Replace(".", "").Replace("-", "").Length < 11)
            {
                MessageBox.Show("CPF incompleto! Por favor, insira um CPF válido.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Criar um objeto do usuário com os dados preenchidos
            Usuario usuario = new(txtNome.Text, maskedTxtCPF.Text, CmbBoxTipo.Text, txtSenha.Text);
            usuario.Inserir();

            // MessageBoxIcon.Information -> ele adiciona um ícone azul com um i
            MessageBox.Show($"Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmCadastroUsuario_Load(sender, e); // limpar os campos após o cadastro bem-sucedido.

        }

        // Os campos ao Abrir o Formulário
        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            // Os campos fiquem vazios quando o formulário for carregado
            txtNome.Text = "";
            maskedTxtCPF.Text = "";
            CmbBoxTipo.SelectedIndex = -1;
            txtSenha.Text = "";

        }

        private void crownLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
