using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Controller.Testes
{
    [TestClass]
    public class OperacoesTestes
    {
        OperacoesBLL operacoesBLL = new OperacoesBLL();

        [TestMethod]
        public void CadastrarOperacao_QuandoInseridoNoBanco_RetornaTrue()
        {
            string NomeCliente = "Cliente Teste";
            string MoedaOrigem = "Moeda Origem";
            string MoedaDestino = "Moeda Destino";
            DateTime DataOperacao = DateTime.Today;
            double ValorOriginal = 100;
            double ValorConvertido = 200;
            double Taxa = 10;

            // Arange
            OperacaoCambio operacao = new OperacaoCambio(NomeCliente, MoedaOrigem, MoedaDestino, DataOperacao, ValorOriginal, ValorConvertido, Taxa);

            // Act
            Response ResultadoRetornado = operacoesBLL.CadastrarOperacao(operacao);

            // Assert
            Assert.IsTrue(ResultadoRetornado.Sucesso);
        }

        [TestMethod]
        public void PegarValorTotalOperacoesTaxas_QuandoValoresForemPegos_RetornaValoresIdentificados()
        {
            string TipoMoeda = "Moeda Origem";
            DateTime DataInicio = Convert.ToDateTime("2021/01/01");
            DateTime DataFinal = Convert.ToDateTime("2021/12/31");
            
            // Arange
            Valores ResultadoEsperado = new Valores();
            ResultadoEsperado.TotalOperacoes = 100;
            ResultadoEsperado.TotalTaxas = 10;

            // Act
            Valores ResultadoRetornado = operacoesBLL.PegarValorTotalOperacoesTaxas(TipoMoeda, DataInicio, DataFinal);

            // Assert
            Assert.AreEqual(ResultadoEsperado.TotalOperacoes, ResultadoRetornado.TotalOperacoes);
            Assert.AreEqual(ResultadoEsperado.TotalTaxas, ResultadoRetornado.TotalTaxas);
        }

        [TestMethod]
        public void PegarValorOperacao_QuandoValoresForemPegos_RetornaOperacaoIdentificada()
        {
            int IdOperacao = 1;

            // Arange
            OperacaoCambio ResultadoEsperado = new OperacaoCambio();
            ResultadoEsperado.NomeCliente = "Cliente Teste";
            ResultadoEsperado.MoedaOrigem = "Moeda Origem";
            ResultadoEsperado.MoedaDestino = "Moeda Destino";
            ResultadoEsperado.DataOperacao = DateTime.Today;
            ResultadoEsperado.ValorOriginal = 100;
            ResultadoEsperado.ValorConvertido = 200;
            ResultadoEsperado.TaxaCobrada = 10;

            // Act
            OperacaoCambio ResultadoRetornado = operacoesBLL.PegarValoresOperacao(IdOperacao);

            // Assert
            Assert.AreEqual(ResultadoEsperado.NomeCliente, ResultadoRetornado.NomeCliente);
            Assert.AreEqual(ResultadoEsperado.MoedaOrigem, ResultadoRetornado.MoedaOrigem);
            Assert.AreEqual(ResultadoEsperado.MoedaDestino, ResultadoRetornado.MoedaDestino);
            Assert.AreEqual(ResultadoEsperado.DataOperacao, ResultadoRetornado.DataOperacao);
            Assert.AreEqual(ResultadoEsperado.ValorOriginal, ResultadoRetornado.ValorOriginal);
            Assert.AreEqual(ResultadoEsperado.ValorConvertido, ResultadoRetornado.ValorConvertido);
            Assert.AreEqual(ResultadoEsperado.TaxaCobrada, ResultadoRetornado.TaxaCobrada);
        }

        [TestMethod]
        public void FiltrarOperacoes_QuandoLerUmaOuMaisLinhas_RetornaTrue()
        {
            int NumLinhas = 1;

            // Arange
            string NomeCliente = "";
            DateTime DataInicio = Convert.ToDateTime("01/01/2021");
            DateTime DataTermino = Convert.ToDateTime("12/31/2021");


            // Act
            DataView ResultadoRetornado = operacoesBLL.FiltrarOperacoes(NomeCliente, DataInicio, DataTermino);


            // Assert
            Assert.IsTrue(ResultadoRetornado.Count >= NumLinhas);
        }

        [TestMethod]
        public void ValidarOperacao_QuandoOperacaoValida_RetornaStringVazia()
        {
            string NomeCliente = "Cliente Teste";
            string MoedaOrigem = "Moeda Origem";
            string MoedaDestino = "Moeda Destino";
            DateTime DataOperacao = DateTime.Now;
            double ValorOriginal = 100;
            double ValorConvertido = 200;
            double Taxa = 10;

            // Arange
            OperacaoCambio operacao = new OperacaoCambio(NomeCliente, MoedaOrigem, MoedaDestino, DataOperacao, ValorOriginal, ValorConvertido, Taxa);

            // Act
            string ResultadoRetornado = operacoesBLL.ValidarOperacao(operacao);

            // Assert
            Assert.AreEqual(string.Empty, ResultadoRetornado);
        }
    }
}
