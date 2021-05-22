using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Controller.Testes
{
    [TestClass]
    public class ValidatorTestes
    {
        Validator validator = new Validator();

        [TestMethod]
        public void ValidarNomeCliente_QuandoNomeValidado_RetornaStringVazia()
        {
            // Arrange
            string NomeCliente = "Cliente Teste";
            string ResultadoEsperado = string.Empty;


            // Act
            string ResultadoRetornado = validator.ValidarNomeCliente(NomeCliente);


            // Assert
            Assert.AreEqual(ResultadoEsperado, ResultadoRetornado);
        }

        [TestMethod]
        public void ValidarDataOperacao_QuandoDataValidada_RetornaStringVazia()
        {
            // Arrange
            DateTime DataOperacao = DateTime.Now;
            string ResultadoEsperado = string.Empty;


            // Act
            string ResultadoRetornado = validator.ValidarDataOperacao(DataOperacao);


            // Assert
            Assert.AreEqual(ResultadoEsperado, ResultadoRetornado);
        }

        [TestMethod]
        public void ValidarValores_QuandoValoresValidados_RetornaStringVazia()
        {
            // Arrange
            double Valor = 1;
            string ResultadoEsperado = string.Empty;


            // Act
            string ResultadoRetornado = validator.ValidarValores(Valor);


            // Assert
            Assert.AreEqual(ResultadoEsperado, ResultadoRetornado);
        }
    }
}
