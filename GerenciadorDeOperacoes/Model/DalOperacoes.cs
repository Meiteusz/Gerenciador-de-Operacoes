using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

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

        public Valores PegarValorTotalOperacoesTaxas(string p_TipoMoeda, DateTime p_DataInicio, DateTime p_DataFinal)
        {
            Valores valores = new Valores();
            SqlCommand command = new SqlCommand("select SUM(Valor_Original) as Total_Operacoes, SUM(Taxa_Cobrada) as Total_Taxas from Operacoes as Valor_Total where " +
                "Moeda_Origem = @TipoMoeda and Convert(date, Data_Operacao) between @DataInicio and @DataFinal", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@TipoMoeda", p_TipoMoeda);
            command.Parameters.AddWithValue("@DataInicio", p_DataInicio);
            command.Parameters.AddWithValue("@DataFinal", p_DataFinal);
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

        // Pega os valores de uma operacao especifica pelo Id
        public OperacaoCambio PegarValoresOperacao(int p_idOperacao)
        {
            OperacaoCambio operacao = new OperacaoCambio();
            SqlCommand command = new SqlCommand("select * from Operacoes where Id = @IdOperacao", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdOperacao", p_idOperacao);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                operacao.Id = (int)reader["Id"];
                operacao.NomeCliente = reader["Cliente_Nome"].ToString();
                operacao.MoedaOrigem = reader["Moeda_Origem"].ToString();
                operacao.MoedaDestino = reader["Moeda_Destino"].ToString();
                operacao.DataOperacao = Convert.ToDateTime(reader["Data_Operacao"]);
                operacao.ValorOriginal = Convert.ToDouble(reader["Valor_Original"]);
                operacao.ValorConvertido = Convert.ToDouble(reader["Valor_Convertido"]);
                operacao.TaxaCobrada = Convert.ToDouble(reader["Taxa_Cobrada"]);
            }
            conexao.Desconectar();
            return operacao;
        }

        public DataView FiltrarOperacoes(string p_NomeCliente, DateTime p_DataInicio, DateTime p_DataTermino)
        {
            DataTable dt = new DataTable();
            command = new SqlCommand("select Id, Cliente_Nome, Moeda_Origem, Moeda_Destino, Data_Operacao, FORMAT(Valor_Original, 'N2') as Valor_Original, " +
                   "FORMAT(Valor_Convertido, 'N2') as Valor_Convertido, FORMAT(Taxa_Cobrada , 'N2') as Taxa from Operacoes", conexao.Conectar());
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Cliente_Nome  Like '{0}%' and Data_Operacao >= '{1}' and Data_Operacao <= '{2}'", p_NomeCliente, p_DataInicio, p_DataTermino.AddDays(1)); //RowFilter não suporta between (addDays para compensar o between)
            conexao.Desconectar();
            return dv;
        }
    }
}
