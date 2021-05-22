using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Controller.Testes
{
    [TestClass]
    public class CalculadoraTeste
    {
        Calculadora calculadora = new Calculadora();

        [TestMethod]
        public void ConverterValor_QuandoConvertido_DaValorParaValorConvertido()
        {
            string MoedaOrigem = "Real";
            string MoedaDestino = "Real";
            double Valor = 1;
            
            // Arange
            double ResultadoEsperado = 1;


            // Act
            calculadora.ConverterValor(MoedaOrigem, MoedaDestino, Valor);
            double ResultadoRetornado = calculadora.ValorConvertido;


            // Assert
            Assert.AreEqual(ResultadoEsperado, ResultadoRetornado);
        }
    }
}
