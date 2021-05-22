using Entities;
using System;

namespace Controller
{
    //Calculadora de Câmbio

    /*Documentação do script:
    
     * A funcão ConverterValor pega a moeda de origem, a moeda de destino e o valor a ser convertido, o valor de conversao da moeda cadastrada é obtida através
     * do nome da moeda, o valor de conversão da moeda de origem é dividido pelo valor de conversão da moeda de destino, e ao final, é multiplicado pelo valor a ser convertido, 
     * com duas casas decimais

    */

    // Teste unitário deste script está no projeto Controller.Testes.CalculadoraTeste

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