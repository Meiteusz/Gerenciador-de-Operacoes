using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Data;

namespace Controller.Testes
{
    [TestClass]
    public class MoedasTestes
    {
        MoedasBLL moedaBLL = new MoedasBLL();

        [TestMethod]
        public void CadastrarMoeda_QuandoInseridaNoBanco_RetornaTrue()
        {
            string TipoMoeda = "Real";
            string Simbolo = "R$";
            double ValorConversao = 1;

            // Arange
            Moeda moeda = new Moeda(TipoMoeda, Simbolo, ValorConversao);


            // Act
            Response ResultadoRetornado = moedaBLL.CadastrarMoeda(moeda);


            // Assert
            Assert.IsTrue(ResultadoRetornado.Sucesso);
        }

        [TestMethod]
        public void AlterarValorMoeda_QuandoAlteradoNoBanco_RetornaTrue()
        {
            string TipoMoeda = "Real";
            string Simbolo = "R$";
            double ValorConversao = 1;

            // Arange
            Moeda moeda = new Moeda(TipoMoeda, Simbolo, ValorConversao);


            // Act
            Response ResultadoRetornado = moedaBLL.AlterarValorMoeda(moeda);


            // Assert
            Assert.IsTrue(ResultadoRetornado.Sucesso);
        }

        [TestMethod]
        public void PegarValorMoeda_QuandoValoresForemPegos_RetornaMoedaIdentificada()
        {
            // Arange
            Moeda ResultadoEsperado = new Moeda();
            ResultadoEsperado.TipoMoeda = "Real";
            ResultadoEsperado.Simbolo = "R$";
            ResultadoEsperado.ValorConversao = 1;


            // Act
            Moeda ResultadoRetornado = moedaBLL.PegarValorMoeda(new Moeda(){ Id = 1, TipoMoeda = string.Empty});


            // Assert
            Assert.AreEqual(ResultadoEsperado.TipoMoeda, ResultadoRetornado.TipoMoeda);
            Assert.AreEqual(ResultadoEsperado.Simbolo, ResultadoRetornado.Simbolo);
            Assert.AreEqual(ResultadoEsperado.ValorConversao, ResultadoRetornado.ValorConversao);
        }

        [TestMethod]
        public void MostrarMoedas_QuandoLerUmaOuMaisLinhas_RetornaTrue()
        {
            // Arange
            int NumLinhas = 1;


            // Act
            DataTable ResultadoRetornado = moedaBLL.MostrarMoedas();


            // Assert
            Assert.IsTrue(ResultadoRetornado.Rows.Count >= NumLinhas);
        }

        [TestMethod]
        public void ListarMoedasCadastradas_QuandoMoedasInseridasNaLista_RetornaListaDeMoedasJaCadastradas()
        {
            // Arange
            ArrayList ResultadoEsperado = new ArrayList();
            ResultadoEsperado.Add("Real");


            // Act
            ArrayList ResultadoRetornado = moedaBLL.ListarMoedasCadastradas();


            // Assert
            Assert.AreEqual(ResultadoEsperado.Count, ResultadoRetornado.Count);
        }
    }
}
