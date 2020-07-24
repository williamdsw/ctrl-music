using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace CTRLMusic
{
    class Banco
    {
        #region Atributos

        protected string dataSource = "(LocalDB)\\v11.0";                                              //versão do banco
        protected string attachDbFilename = "E:\\CTRLMusic\\CTRLMusic 2.0\\CTRLMusic\\CTRLMusic.mdf";   //local do banco
        protected string integratedSecurity = "True";

        #endregion

        #region Método construtor

        public Banco()
        {}

        #endregion

        #region Método que organiza a string de conexão

        private string montaString()
        {
            return "Data Source=" + dataSource + ";" + "AttachDbFilename=" + attachDbFilename + ";" +
                   "Integrated Security=" + integratedSecurity;
        }

        #endregion

        #region Método para conectar ao banco

        public SqlConnection conecta()
        {
            SqlConnection con = new SqlConnection(montaString());        //define a string de conexão

            con.Open();             //abre conexão

            return con;             //retorna a conexão
        }

        #endregion

        #region Metódo para desconectar do banco

        public void desconecta(SqlConnection pcon)
        {
            pcon.Dispose();         //encerra a conexão
        }

        #endregion

        #region Método para apagar registro

        public string apaga(string ptbl, string pcampo, string pcod)
        {
            try                 //tratamento de excessão
            {
                string sql = "DELETE FROM " + ptbl + " WHERE " + pcampo + "=" + pcod;       //comando SQL

                SqlCommand cmd = new SqlCommand(sql, conecta());          //comando

                cmd.ExecuteNonQuery();                                          //comando que não retorna dados

                return "Registro excluído com sucesso!";                        //retorna o sucesso do registro excluído
            }
            catch (Exception ex)    //excessão
            {
                return "Não foi possível excluir o registro \n\n" + ex.Message;     //retorna o erro
            }
        }

        #endregion

        #region Método para alterar quantidade no estoque

        public string altqtd(string ptbl, string pcampo, 
                             string pcod, int pqtd)
        {
            try                        //tratamento de excessão
            {
                //comando SQL
                string sql = "UPDATE " + ptbl +
                             " SET QUANTIDADE " + " = " + pqtd +
                             " WHERE " + pcampo + " = " + pcod;

                SqlCommand cmd = new SqlCommand(sql, conecta());      //comando

                cmd.ExecuteNonQuery();                                      //executa um comando que não retorna dado
          
                return "Venda concluída!";                                  //retorna o sucesso
            }
            catch (Exception ex)                //excessão
            {
                return "Erro ao vender! \n\n" + ex.Message;                 //retorna o erro
            }
        }

        #endregion

        #region Método para fazer a filtragem da tabela

        public DataTable filtra(string ptab, string ppar, string ppal)
        {
            try
            {
                SqlConnection con = conecta();

                string cmd = "SELECT * FROM " + ptab + " WHERE " + ppar + " = " + "'" + ppal + "'";

                SqlDataAdapter adapt = new SqlDataAdapter(cmd, con);

                DataTable dt = new DataTable();

                adapt.Fill(dt);

                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
        }

        #endregion

        #region Método pra pegar nomes das tabelas

        public SqlDataReader tabelas(string ptbl)
        {
            try
            {
                SqlConnection con = conecta();

                string sql = "SELECT * FROM " + ptbl;

                SqlCommand cmd;

                SqlDataReader dr;

                cmd = new SqlCommand(sql, con);

                dr = cmd.ExecuteReader();

                return dr;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
        }

        #endregion
    }
}


