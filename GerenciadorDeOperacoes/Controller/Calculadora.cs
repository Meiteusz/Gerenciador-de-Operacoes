using Entities;
using System;

namespace Controller
{
    //Calculadora de Câmbio
    public class Calculadora
    {
        public double ValorConvertido { get; private set; }
        MoedasBLL moedasBLL = new MoedasBLL();

        public void ConverterValor(string MoedaOrigem, string MoedaDestino, double Valor)
        {
            Moeda moeda = new Moeda();

            moeda.TipoMoeda = MoedaOrigem;
            double ValorConversaoMoedaOrigem = moedasBLL.PegarValorMoeda(moeda).ValorConversao;

            moeda.TipoMoeda = MoedaDestino;
            double ValorConversaoMoedaDestino = moedasBLL.PegarValorMoeda(moeda).ValorConversao;

            ValorConvertido = Math.Round((ValorConversaoMoedaOrigem / ValorConversaoMoedaDestino) * Valor, 2);
        }
    }
}