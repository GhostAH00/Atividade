using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtividadeClasse;
using Microsoft.Win32;

namespace AtividadeDesk
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        // Quando o formulário carregar, atualizar o DataGridView
        private void FrmRegistro_Load(object sender, EventArgs e)
        {

            BuscarDataGridView();
        }

        //Método para buscar os registros no banco e preencher o DataGrid
        private void BuscarDataGridView()
        {
            List<RegistroAcesso> registros = RegistroAcesso.ObterUltimosAcessos();
            DgvRegistro.Rows.Clear(); // Limpa apenas as linhas sem apagar as colunas

            foreach (var registro in registros)
            {
                DgvRegistro.Rows.Add(registro.Id,
                    registro.NomeUsuario,
                    // Exibe horário apenas se for "Entrada"
                    registro.TipoOperacao == "Entrada" ?
                    registro.DataHora.ToString() : "",
                    // Exibe horário apenas se for "Saída"
                    registro.TipoOperacao == "Saída" ?
                    registro.DataHora.ToString() : "",
                    registro.TipoOperacao,
                    registro.DataHora);
            }
        }
        private void DgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                DataGridViewRow linhaSelecionada = DgvRegistro.Rows[e.RowIndex];
                // Captura os valores das células da linha clicada
                int idRegistro = Convert.ToInt32(linhaSelecionada.Cells["Id"].Value);
                string nomeUsuario = linhaSelecionada.Cells["NomeUsuario"].Value.ToString();
                DateTime dataHora = Convert.ToDateTime(linhaSelecionada.Cells["DataHora"].Value);
                string tipoOperacao = linhaSelecionada.Cells["Operação"].Value.ToString();

                MessageBox.Show($"Registro ID: {idRegistro}\nUsuário: {nomeUsuario}\nData: {dataHora}\nOperação: {tipoOperacao}",
                        "Detalhes do Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        
        // Método que atualiza o DataGridView
        private void AtualizarDataGridView(List<RegistroAcesso> registros)
        {
            DgvRegistro.Rows.Clear();

            foreach (var registro in registros)
            {
                DgvRegistro.Rows.Add(
                    registro.Id,
                    registro.NomeUsuario,
                    registro.TipoOperacao == "Entrada" ? registro.DataHora.ToString() : "",
                    registro.TipoOperacao == "Saída" ? registro.DataHora.ToString() : "",
                    registro.TipoOperacao,
                    registro.DataHora);
            }
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarRegistro();
        }

        private void FiltrarRegistro()
        {
            string nomeBuscado = txtNomeFiltro.Text.Trim();
            bool dataSelecionadaAtivada = dtpDataFiltro.Checked;
            DateTime dataSelecionada = dtpDataFiltro.Value.Date;

            // Obtém todos os registros do banco
            List<RegistroAcesso> registrosOriginais = RegistroAcesso.ObterUltimosAcessos();

            // Se nenhum filtro for preenchido, exibe todos os registros
            if (string.IsNullOrEmpty(nomeBuscado) && !dataSelecionadaAtivada)
            {
                AtualizarDataGridView(registrosOriginais);
                return;
            }

            // Inicializa lista filtrada com todos os registros
            IEnumerable<RegistroAcesso> registrosFiltrados = registrosOriginais;

            // Filtra **primeiro pelo Nome**, mostrando Entrada e Saída
            if (!string.IsNullOrEmpty(nomeBuscado))
            {
                registrosFiltrados = registrosFiltrados.Where(r => r.NomeUsuario.Contains(nomeBuscado, StringComparison.OrdinalIgnoreCase));
            }

            // Se o usuário também quiser filtrar pela Data, aplica essa filtragem opcional
            if (dataSelecionadaAtivada)
            {
                registrosFiltrados = registrosFiltrados.Where(r => r.DataHora.Date == dataSelecionada);
            }

            // Exibe os registros filtrados
            AtualizarDataGridView(registrosFiltrados.ToList());
        }    


        private void dtpDataFiltro_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
