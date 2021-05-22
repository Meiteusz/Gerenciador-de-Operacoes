using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace Model.Testes
{
    [TestClass]
    public class ConexaoTeste
    {
        [TestMethod]
        public void Conectar_QuandoConectar_RetornaConexaoAberta()
        {
            // Arange
            Conexao conexao = new Conexao();

            // Act
            ConnectionState ResultadoRetornado = conexao.Conectar().State;

            // Assert
            Assert.AreEqual(ConnectionState.Open, ResultadoRetornado);
            conexao.Desconectar();
        }
    }
}
