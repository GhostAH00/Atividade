using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasse
{
    public class Usuario
    {
        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string TipoUsuario { get; set; }
        public string Senha { get; set; }

        // construtores
        public Usuario() { }

        public Usuario(int id, string nome, string cpf, string tipoUsuario, string senha)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipoUsuario;
            Senha = senha;
        }
        public Usuario(string nome, string cpf, string tipoUsuario, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipoUsuario;
            Senha = senha;
        }

        public Usuario(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public Usuario(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        // Método para buscar um usuário no banco de dados pelo id
        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario = new(
                        dr.GetInt32(0),  // Id
                        dr.GetString(1), // Nome
                        dr.GetString(2), // CPF
                        dr.GetString(3), // Tipo de Usuário
                        dr.GetString(4)  // Senha
                    );
            }

            return usuario;
        }
        // Método para inserir um novo usuário no banco de dados
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into usuarios (nome, cpf, tipoUsuario, senha) " +
                  $"values ('{Nome}', '{Cpf}', '{TipoUsuario}', md5('{Senha}'))";
            cmd.ExecuteNonQuery(); // Executa
            cmd.CommandText = "select last_insert_id()";
            Id = Convert.ToInt32(cmd.ExecuteScalar()); // Atualiza        

        }
        // Método para validar login verificando nome e senha no banco de dados
        public static Usuario ValidarLogin(string nome, string senha)
        {          
            Usuario usuario = null; // para evitar erro
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT id, nome FROM usuarios WHERE nome = @nome AND senha = MD5(@senha)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);

            var dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                usuario = new Usuario
                {
                    Id = dr.GetInt32(0),
                    Nome = dr.GetString(1)
                };
            }

            dr.Close(); // Fechar o DataReader para evitar problemas de conexão
            return usuario; // Retorna NULL corretamente caso não encontre o usuário
        }


    }
}

