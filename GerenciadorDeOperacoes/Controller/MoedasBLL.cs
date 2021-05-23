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
            if (moeda.ValorConversao.Equals(0) || moeda.Simbolo.Equals(string.Empty))
            {
                Response resposta = new Response
                {
                    Sucesso = false,
                    Mensagem = "Valor ou símbolo inválidos!"
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

        public bool isQuantidadeMoedasValido()
        {
            return dalmoedas.VerificarQuantidadeMoedasCadastradas();
        }
    }
}
