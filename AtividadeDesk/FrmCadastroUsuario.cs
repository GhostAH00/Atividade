using AtividadeClasse;

namespace AtividadeDesk
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        // Valida��o e Cadastro do Usu�rio
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // string.IsNullOrEmpty(nome) -> Verifica apenas se � nulo ou vazio,
            // mas n�o detecta espa�os em branco.

            // Verificar se os campos est�o preenchidos
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(maskedTxtCPF.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                CmbBoxTipo.SelectedIndex == -1)
            {
                // MessageBoxIcon.Warning -> Ele � utilizado para avisar o usu�rio sobre algo importante, como um erro ou a��o cr�tica.
                // MessageBoxButtons.OK -> exibir apenas um bot�o "OK" na caixa de di�logo
                MessageBox.Show("Por favor, preencha todos os campos antes de confirmar o cadastro!",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return; // Se algum campo estiver vazio, a execu��o para (return;) e exibe uma mensagem de alerta
            }

            // Validar o CPF
            if (maskedTxtCPF.Text.Replace(".", "").Replace("-", "").Length < 11)
            {
                MessageBox.Show("CPF incompleto! Por favor, insira um CPF v�lido.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Criar um objeto do usu�rio com os dados preenchidos
            Usuario usuario = new(txtNome.Text, maskedTxtCPF.Text, CmbBoxTipo.Text, txtSenha.Text);
            usuario.Inserir();

            // MessageBoxIcon.Information -> ele adiciona um �cone azul com um i
            MessageBox.Show($"Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmCadastroUsuario_Load(sender, e); // limpar os campos ap�s o cadastro bem-sucedido.

        }

        // Os campos ao Abrir o Formul�rio
        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            // Os campos fiquem vazios quando o formul�rio for carregado
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
