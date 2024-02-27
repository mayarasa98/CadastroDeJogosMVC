using System;
using System.Data;
using System.Data.SqlClient;

namespace Cadastro_de_jogos_MVC_16._1_Mayara.DAO
{
    public class HelperDAO
    {
        //Vamos criar o objeto ExecutaSQL, que utiliza o bloco “using” que faz o “dispose” dos objetos, garantindo assim que o mesmo
        //seja destruído, fazendo às vezes do bloco try-finally. Além disso, a conexão com o banco de dados já é feita aqui tbm.
        public static void ExecutaSQL(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }
            }
        }

        internal static SqlDbType NullAsDbNull(double? valorLocacao)
        {
            throw new NotImplementedException();
        }

        public static DataTable ExecutaSelect(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);

                    DataTable tabelaTemp = new DataTable();
                    adapter.Fill(tabelaTemp);
                    return tabelaTemp;
                }
            }
        }
    }
}
