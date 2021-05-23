using Entities;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class DalMoedas
    {
        Conexao conexao = new Conexao();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter;

        public Response Insert(Moeda p_moeda)
        {
            Response resposta = new Response();
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@TipoMoeda", p_moeda.TipoMoeda);
            command.Parameters.AddWithValue("@Simbolo", p_moeda.Simbolo);
            command.Parameters.AddWithValue("@ValorConversao", p_moeda.ValorConversao);

            command.CommandText = "insert into Moedas values(@TipoMoeda, @Simbolo, @ValorConversao)";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                resposta.Sucesso = true;
                resposta.Mensagem = "Moeda cadastrada com sucesso!";
            }
            catch (SqlException ex)
            {
                resposta.Sucesso = false;
                if (ex.Number.Equals(2627))
                    resposta.Mensagem = "Esta moeda já está cadastrada";
                else
                    resposta.Mensagem = "Erro com o Banco de Dados\n" + ex.Message;
            }
            finally
            {
                conexao.Desconectar();
            }
            return resposta;
        }

        public Response Update(Moeda p_moeda)
        {
            Response resposta = new Response();
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Id", p_moeda.Id);
            command.Parameters.AddWithValue("@Simbolo", p_moeda.Simbolo);
            command.Parameters.AddWithValue("@ValorConversao", p_moeda.ValorConversao);

            command.CommandText = "update Moedas set Valor_Conversao = @ValorConversao, Simbolo = @Simbolo from Moedas where Id = @Id";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                resposta.Sucesso = true;
                resposta.Mensagem = "Valor de conversão alterado com sucesso!";
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

        public DataTable PegarTodasMoedas()
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("select m.id, m.Moeda, m.Simbolo, FORMAT(m.Valor_Conversao, 'c', 'pt-br') as Valor_Conversao from Moedas m", conexao.Conectar());
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }

        // Pega os valores de uma moeda especifica pelo nome(Unique) ou Id
        public Moeda PegarValorMoeda(Moeda p_moeda)
        {
            Moeda moeda = new Moeda();
            SqlCommand command = new SqlCommand("select * from Moedas where Id = @IdMoeda or Moeda = @TipoMoeda", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdMoeda", p_moeda.Id);
            command.Parameters.AddWithValue("@TipoMoeda", p_moeda.TipoMoeda);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                moeda.Id = (int)reader["Id"];
                moeda.TipoMoeda = reader["Moeda"].ToString();
                moeda.Simbolo = reader["Simbolo"].ToString();
                moeda.ValorConversao = Convert.ToDouble(reader["Valor_Conversao"]);
            }
            conexao.Desconectar();
            return moeda;
        }

        public ArrayList ListarMoedasCadastradas()
        {
            ArrayList ListaMoedas = new ArrayList();
            SqlCommand command = new SqlCommand("select Moeda from Moedas", conexao.Conectar());
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListaMoedas.Add(reader["Moeda"].ToString());
            }
            conexao.Desconectar();
            return ListaMoedas;
        }

        public bool VerificarQuantidadeMoedasCadastradas()
        {
            int QtdMoedasCadastradas = 0;
            SqlCommand command = new SqlCommand("select * from Moedas", conexao.Conectar());
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                QtdMoedasCadastradas++;
            }
            if (QtdMoedasCadastradas < 2)
            {
                return false;
            }
            return true;
        }
    }
}
