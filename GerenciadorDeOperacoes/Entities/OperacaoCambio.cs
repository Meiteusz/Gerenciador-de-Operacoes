using System;

namespace Entities
{
    public class OperacaoCambio
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string MoedaOrigem { get; set; }
        public string MoedaDestino { get; set; }
        public DateTime DataOperacao { get; set; }
        public double ValorOriginal { get; set; }
        public double ValorConvertido { get; set; }
        public double TaxaCobrada { get; set; }

        public OperacaoCambio() { }

        public OperacaoCambio(string p_NomeCliente, string p_MoedaOrigem, string p_MoedaDestino, DateTime p_DataOperacao, double p_ValorOriginal,
            double p_ValorConvertido, double p_TaxaCobrada)
        {
            NomeCliente = p_NomeCliente;
            MoedaOrigem = p_MoedaOrigem;
            MoedaDestino = p_MoedaDestino;
            DataOperacao = p_DataOperacao;
            ValorOriginal = (double)p_ValorOriginal;
            ValorConvertido = p_ValorConvertido;
            TaxaCobrada = p_TaxaCobrada;
        }
    }
}
