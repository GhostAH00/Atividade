using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasse
{
    //Registro de entrada/saída
    public class RegistroAcesso
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string NomeUsuario { get; set; } 
        public DateTime DataHora { get; set; }
        public string TipoOperacao { get; set; } // Entrada ou Saída

        // Construtor 
        public RegistroAcesso() { }
        public RegistroAcesso(int usuarioId, string tipoOperacao)
        {
            UsuarioId = usuarioId;
            TipoOperacao = tipoOperacao;
            DataHora = DateTime.Now; // Horário automático
        }

        // Inserir novo registro no banco
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO registro_acesso (id_usuario, DataHora, TipoOperacao) VALUES (@usuarioId, @dataHora, @tipoOperacao)";
            cmd.Parameters.AddWithValue("@usuarioId", UsuarioId);
            cmd.Parameters.AddWithValue("@dataHora", DataHora);
            cmd.Parameters.AddWithValue("@tipoOperacao", TipoOperacao);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        // Obter últimos registros de acesso
        public static List<RegistroAcesso> ObterUltimosAcessos()
        {
            List<RegistroAcesso> lista = new List<RegistroAcesso>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select ra.id, u.nome, ra.DataHora, ra.TipoOperacao " +
                      "from registroAcesso ra " +
                      "join usuarios u on ra.id_usuario = u.id " +
                      "order by ra.DataHora desc limit 10";

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new RegistroAcesso
                {
                    Id = dr.GetInt32(0),
                    NomeUsuario = dr.GetString(1),
                    DataHora = dr.GetDateTime(2),
                    TipoOperacao = dr.GetString(3)
                });
            }
            dr.Close();
            cmd.Dispose();
            return lista;
        }
    }
}