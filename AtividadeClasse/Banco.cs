using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasse
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {

            MySqlCommand cmd = new();
            string strConn = @"server=127.0.0.1;database=atividade1;user=root;password=";

            MySqlConnection cn = new(strConn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cmd;
        }

    }
}
