using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasse
{
    public class Autenticador
    {
        public bool ValidarLogin(string Cpf, string Senha)
        {
            // Simulação de verificação
            if (Cpf == Cpf && Senha == Senha)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
