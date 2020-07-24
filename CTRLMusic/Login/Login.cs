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
    class Login
    {
        #region Atributos

        string usuario, senha;

        #endregion

        #region Instanciamento de classes

        Banco bd = new Banco();

        #endregion

        #region Método construtor

        public Login(string puser, string psenha)
        {
            usuario = puser;
            senha = psenha;
        }

        #endregion

        #region Método booleano de verficação de usuário

        public bool ExecutaLogin(string puser, string psenha)
        {
            try
            {
                string sql = "SELECT USUARIO FROM USUARIO WHERE USUARIO = @USUARIO AND SENHA = @SENHA";

                SqlCommand cmd = new SqlCommand(sql, bd.conecta());

                cmd.Parameters.AddWithValue("@USUARIO", puser);
                cmd.Parameters.AddWithValue("@SENHA", psenha);

                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter();

                DataTable dt = new DataTable();

                da.SelectCommand = cmd;
                da.Fill(dt);
                da.Dispose();

                bd.desconecta(cmd.Connection);

                if (dt.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }

        #endregion
    }
}
