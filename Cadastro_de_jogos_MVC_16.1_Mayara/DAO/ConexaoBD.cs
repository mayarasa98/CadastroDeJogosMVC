using System.Data.SqlClient;

namespace Cadastro_de_jogos_MVC_16._1_Mayara.DAO
{
    public class ConexaoBD
    {
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=LOCALHOST; Database=AULADB; user id=sa; password=123456";

            //string strCon = "Data Source=LOCALHOST; Initial Catalog=AULADB; integrated security=true";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }
    }
}
