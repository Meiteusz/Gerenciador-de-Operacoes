using Entities;
using Model;
using System;
using System.Data;

namespace Controller
{
    public class OperacoesBLL
    {
        Validator validator = new Validator();
        DalOperacoes dalOperacoes = new DalOperacoes();

        public Response CadastrarOperacao(OperacaoCambio operacao)
        {
            Response resposta = new Response();
            string mensagem = ValidarOperacao(operacao);

            if (!mensagem.Equals(string.Empty))
            {
                resposta.Sucesso = false;
                resposta.Mensagem = mensagem;
            }
            else
                resposta = dalOperacoes.Insert(operacao);
            return resposta;
        }

        public Valores PegarValorTotalOperacoesTaxas(string TipoMoeda, DateTime DataInicio, DateTime DataFinal)
        {
            return dalOperacoes.PegarValorTotalOperacoesTaxas(TipoMoeda, DataInicio, DataFinal);
        }

        public OperacaoCambio PegarValoresOperacao(int idOperacao)
        {
            return dalOperacoes.PegarValoresOperacao(idOperacao);
        }

        public DataView FiltrarOperacoes(string NomeCliente, DateTime DataInicio, DateTime DataTermino)
        {
            return dalOperacoes.FiltrarOperacoes(NomeCliente, DataInicio, DataTermino);
        }

        public string ValidarOperacao(OperacaoCambio operacao)
        {
            string mensagem = validator.ValidarNomeCliente(operacao.NomeCliente) + validator.ValidarDataOperacao(operacao.DataOperacao) + validator.ValidarValores(operacao.ValorOriginal);

            if (mensagem.Equals(string.Empty))
                return string.Empty;
            else
                return mensagem;
        }
    }
}
