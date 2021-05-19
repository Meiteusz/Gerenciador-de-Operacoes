using Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Model
{
    public class DalOperacoes
    {
        Conexao conexao = new Conexao();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter;

        public Response Insert(OperacaoCambio p_operacao)
        {
            Response resposta = new Response();
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@NomeCliente", p_operacao.NomeCliente);
            command.Parameters.AddWithValue("@MoedaOrigem", p_operacao.MoedaOrigem);
            command.Parameters.AddWithValue("@MoedaDestino", p_operacao.MoedaDestino);
            command.Parameters.AddWithValue("@DataOperacao", p_operacao.DataOperacao);
            command.Parameters.AddWithValue("@ValorOriginal", p_operacao.ValorOriginal);
            command.Parameters.AddWithValue("@ValorConvertido", p_operacao.ValorConvertido);
            command.Parameters.AddWithValue("@TaxaCobrada", p_operacao.TaxaCobrada);

            command.CommandText = "insert into Operacoes values (@NomeCliente, @MoedaOrigem, @MoedaDestino, @DataOperacao, @ValorOriginal, @ValorConvertido, @TaxaCobrada)";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                resposta.Sucesso = true;
                resposta.Mensagem = "Operação cadastrada com sucesso!";
            }
            catch (SqlException ex)
            {
                resposta.Sucesso = false;
                resposta.Mensagem = "Erro com o Banco de Dados\n" + ex.Message;
            }
            finally
            {
                conexao.Desconectar();
            }
            return resposta;
        }

        public Valores PegarValorTotalOperacoesTaxas(string p_TipoMoeda)
        {
            Valores valores = new Valores();
            SqlCommand command = new SqlCommand("select SUM(Valor_Original) as Total_Operacoes, SUM(Taxa_Cobrada) as Total_Taxas from Operacoes as Valor_Total where Moeda_Origem = @TipoMoeda", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@TipoMoeda", p_TipoMoeda);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var Total_Operacoes = reader["Total_Operacoes"];
                var Valor_Taxas = reader["Total_Taxas"];
                if (Total_Operacoes.Equals(DBNull.Value))
                {
                    valores.TotalOperacoes = 0;
                    valores.TotalTaxas = 0;
                }
                else
                {
                    valores.TotalOperacoes = Convert.ToDouble(Total_Operacoes);
                    valores.TotalTaxas = Convert.ToDouble(Valor_Taxas);
                }
            }
            conexao.Desconectar();
            return valores;
        }

        public DataTable MostrarOperacoes()
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("select Id, Cliente_Nome, Moeda_Origem, Moeda_Destino, FORMAT(Data_Operacao, 'dd/MM/yyyy') as Data_Operacao, " +
                "Valor_Original, Valor_Convertido, Taxa_Cobrada as Taxa from Operacoes", conexao.Conectar());
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }

        public DataTable FiltrarOperacoes(string p_NomeCliente, DateTime p_DataInicio, DateTime p_DataTermino)
        {
            DataTable dt = new DataTable();
            command = new SqlCommand("select Id, Cliente_Nome, Moeda_Origem, Moeda_Destino, FORMAT(Data_Operacao, 'dd/MM/yyyy') as Data_Operacao, Valor_Original, " +
                "Valor_Convertido, FORMAT(Taxa_Cobrada,  'c', 'pt-br') as Taxa_BRL from Operacoes where Cliente_Nome = @NomeCliente or " +
                "Convert(date, Data_Operacao) between @DataInicio and @DataTermino", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@NomeCliente", p_NomeCliente);
            command.Parameters.AddWithValue("@DataInicio", p_DataInicio);
            command.Parameters.AddWithValue("@DataTermino", p_DataTermino);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }

        public AutoCompleteStringCollection ListarNomesClientes()
        {
            AutoCompleteStringCollection AutoComplete = new AutoCompleteStringCollection();
            SqlCommand command = new SqlCommand("select Cliente_Nome from Operacoes", conexao.Conectar());
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                AutoComplete.Add(reader["Cliente_Nome"].ToString());
            }
            conexao.Desconectar();
            return AutoComplete;
        }
    }
}
