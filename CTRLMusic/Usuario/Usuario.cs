using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CTRLMusic
{
    class Usuario
    {
        #region Atributos

        string usuario, usenha, csenha;                                
        int cod_fun;
        bool administrador;

        #endregion

        #region Instanciamento de classes

        Banco bd = new Banco();

        #endregion

        #region Método Construtor

        public Usuario(string puser, string pus, string pcs,                          
                       int pcf, bool padm)
        {
            //Parâmetros
            usuario = puser; 
            usenha = pus; 
            csenha = pcs;                                     
            cod_fun = pcf;
            administrador = padm;
        }

        #endregion

        #region Método de inserção de dados

        public string insere(string puser, string pus, string pcs,                        
                             int pcf, bool padm)
        {
            try
            {
                //Comando DML
                string sql = "INSERT INTO USUARIO (COD_FUNCIONARIO, USUARIO, SENHA, CSENHA, ADMINISTRADOR)" +
                             "VALUES (@COD_FUNCIONARIO, @USUARIO, @SENHA, @CSENHA, @ADMINISTRADOR)";

                //Instanciando os métodos SQL
                SqlCommand cmd = new SqlCommand(sql, bd.conecta());

                cmd.Parameters.AddWithValue("@COD_FUNCIONARIO", pcf);
                cmd.Parameters.AddWithValue("@USUARIO", puser);
                cmd.Parameters.AddWithValue("@SENHA", pus);
                cmd.Parameters.AddWithValue("@CSENHA", pcs);
                cmd.Parameters.AddWithValue("@ADMINISTRADOR", padm);

                cmd.ExecuteNonQuery();

                bd.desconecta(cmd.Connection);

                return "Usuário cadastrado com sucesso";
            }
            catch (Exception ex)
            {
                return "Erro ao cadastrar usuário \n\n" + ex.Message;
            }
        }

        #endregion

        #region Sobrecarga de método

        public Usuario()
        { }

        #endregion

        #region Método de consulta

        public DataTable consulta()
        {
            try
            {
                DataTable dt = new DataTable();

                //Comando DQL
                string sql = "SELECT COD_USUARIO, USUARIO, ADMINISTRADOR, COD_FUNCIONARIO " +
                             "FROM USUARIO";

                SqlConnection cnn = bd.conecta();

                SqlCommand cmd = new SqlCommand(sql, cnn);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);

                bd.desconecta(cnn);

                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
        }

        #endregion

        #region Método de alteração de dados

        public string alterar(string pcampo, string pcuser,
                              string puser, string psenha, string pcsenha,
                              bool padm)
        {
            try
            {
                //Comando DML
                string sql = "UPDATE USUARIO SET USUARIO " + " = " + "'" + puser + "'" +
                             "," + " SENHA " + " = " + "'" + psenha + "'" +
                             "," + " CSENHA " + " = " + "'" + pcsenha + "'" +
                             "," + " ADMINISTRADOR " + " = " + padm + 
                             " WHERE " + pcampo + " = " + pcuser;

                SqlCommand cmd = new SqlCommand(sql, bd.conecta());

                cmd.ExecuteNonQuery();

                return "Registro alterado com sucesso!";

            }
            catch (Exception ex)
            {
                return "Não foi possível alterar o registro" + ex.Message;
            }
        }

        #endregion
    }
}

