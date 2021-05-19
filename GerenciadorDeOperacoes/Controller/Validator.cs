using System;
using System.Text.RegularExpressions;

namespace Controller
{
    class Validator
    {
        Regex regexNome = new Regex(@"[A-Z][a-z].* [A-Z][a-z].*");
        
        public string ValidarNomeCliente(string NomeCliente)
        {
            if (NomeCliente.Length < 3 || NomeCliente.Length > 250 && !regexNome.IsMatch(NomeCliente))
            {
                return "Nome inválido\n";
            }
            return string.Empty;
        }

        public string ValidarDataOperacao(DateTime DataOperacao)
        {
            if (DataOperacao < DateTime.Today)
            {
                return "Data inválida\n";
            }
            return string.Empty;
        }

        public string ValidarValores(double Valor)
        {
            if (Valor <= 0)
            {
                return "Valor original inválido";
            }
            return string.Empty;
        }
    }
}
