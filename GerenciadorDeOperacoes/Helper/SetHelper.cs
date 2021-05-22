using Controller;
using Entities;

namespace Helper
{
    public static class SetHelper
    {
        //Classe feita para Setar uma Moeda ou Operacao específica para uso dos dados dos mesmos

        public static OperacaoCambio OperacaoSelecionada { get; private set; }
        public static Moeda MoedaSelecionada { get; private set; }

        public static void SetarMoeda(Moeda moeda)
        {
            MoedasBLL moedasBLL = new MoedasBLL();
            MoedaSelecionada = moedasBLL.PegarValorMoeda(moeda);
        }

        public static void SetarOperacao(OperacaoCambio operacao)
        {
            OperacoesBLL operacoesBLL = new OperacoesBLL();
            OperacaoSelecionada = operacoesBLL.PegarValoresOperacao(operacao.Id);
        }
    }
}
