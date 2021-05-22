using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class Conexao
    {
        //Classe de conexao que facilita a conexao e a desconexao com o banco, sem a necessidade de repetir a ConnectionString

        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = "Data Source=.;Initial Catalog=GerenciadorDeOperacoes;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
