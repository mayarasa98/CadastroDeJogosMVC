using Cadastro_de_jogos_MVC_16._1_Mayara.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Cadastro_de_jogos_MVC_16._1_Mayara.DAO
{
    public class JogoDAO
    {
        private SqlParameter[] CriaParametros(JogoViewModel jogo)
        {
            SqlParameter[] parametros = new SqlParameter[5];

            parametros[0] = new SqlParameter("id", jogo.Id);
            parametros[1] = new SqlParameter("descricao", jogo.Descricao);
            parametros[2] = new SqlParameter("valor_locacao", HelperDAO.NullAsDbNull(jogo.ValorLocacao));
            parametros[3] = new SqlParameter("data_aquisicao", jogo.DataAquisicao);
            parametros[4] = new SqlParameter("categoriaID", jogo.CategoriaId);
            return parametros;

            /*if (jogo.ValorLocacao == null)
                parametros[2] = new SqlParameter("valor_locacao", DBNull.Value);
            else
                parametros[2] = new SqlParameter("valor_locacao", jogo.ValorLocacao);*/

        }

        #region Método Inserir
        public void Inserir(JogoViewModel jogo)
        {
            string sql =
                "insert into jogos(id, descricao, valor_locacao, data_aquisicao, categoriaId)" +
                "values (@id, @descricao, @valor_locacao, @data_aquisicao, @categoriaId)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(jogo));
        }
        #endregion

        #region Método Alterar
        public void Alterar(JogoViewModel jogo)
        {
            string sql =
                "update jogos set descricao=@descricao, valor_locacao=@valor_locacao, data_aquisicao=@data_aquisicao, " +
                "categoriaId=@catgoriaId where id=@id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(jogo));
        }
        #endregion

        #region Método Excluir
        public void Excluir(int id)
        {
            string sql =
                "delete jogos where id=" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }
        #endregion

        #region Método Consulta
        public JogoViewModel Consulta(int id)
        {
            string sql = "select * from jogos where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return PreencheJogo(tabela.Rows[0]);
        }
        #endregion

        #region Método Preenche Jogo
        public static JogoViewModel PreencheJogo(DataRow registro)
        {
            JogoViewModel jogo = new JogoViewModel();

            if (registro["valor_locacao"] != DBNull.Value)
                jogo.ValorLocacao = Convert.ToDouble(registro["valor_locacao"]);

            jogo.Id = Convert.ToInt32(registro["id"]);
            jogo.Descricao = registro["descricao"].ToString();
            if (registro["valor_locacao"] != DBNull.Value)
                jogo.ValorLocacao = Convert.ToDouble(registro["valor_locacao"]);
           // jogo.ValorLocacao = Convert.ToDouble(registro["valor_locacao"]);
            jogo.DataAquisicao = Convert.ToDateTime(registro["data_aquisicao"]);
            jogo.CategoriaId = Convert.ToInt32(registro["categoriaID"]);

            return jogo;
        }
        #endregion

        #region Método Listar
        public List<JogoViewModel> Lista()
        {
            string sql = "select * from jogos order by descricao";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            var lista = new List<JogoViewModel>();

            foreach (DataRow registro in tabela.Rows)
            {
                lista.Add(PreencheJogo(registro));
            }
            return lista;
        }
        #endregion

        #region Método Próximo Id
        public int ProximoId()
        {
            string sql = "select isnull(max(id) +1, 1) as 'MAIOR' from jogos";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null );
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]);
        }
        #endregion
    }
}
