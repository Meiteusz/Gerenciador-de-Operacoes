using Entities;
using Model;
using System.Collections;
using System.Data;

namespace Controller
{
    public class MoedasBLL
    {
        DalMoedas dalmoedas = new DalMoedas();

        public Response CadastrarMoeda(Moeda moeda)
        {
            if (moeda.ValorConversao.Equals(0))
            {
                Response resposta = new Response
                {
                    Sucesso = false,
                    Mensagem = "Valor inválido!"
                };
                return resposta;
            }
            return dalmoedas.Insert(moeda);
        }

        public Response AlterarValorMoeda(Moeda moeda)
        {
            return dalmoedas.Update(moeda);
        }

        public Moeda PegarValorMoeda(Moeda moeda)
        {
            return dalmoedas.PegarValorMoeda(moeda);
        }

        public DataTable MostrarMoedas()
        {
            return dalmoedas.PegarTodasMoedas();
        }

        public ArrayList ListarMoedasCadastradas()
        {
            return dalmoedas.ListarMoedasCadastradas();
        }
    }
}
