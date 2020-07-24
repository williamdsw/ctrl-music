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
    class Instrumento
    {
        #region Atributos

        string nome, marca, distribuidor, cor, modelo, altura, largura, profundidade, peso, tipo, instrumento, estado, caminho;
        decimal preco;
        int quantidade;

        #endregion

        #region Instanciamento de classes

        Banco bd = new Banco();

        #endregion

        #region Método construtor
        public Instrumento(string pnome, string pmarca, string pdis, string pcor, string pmod,
                           string palt, string plar, string pprof, string ppeso, string ptipo,
                           string pins, string pest, string pcam, decimal ppre, int pqtd)
        {
            //Parâmetros
            nome = pnome;
            marca = pmarca;
            distribuidor = pdis;
            cor = pcor;
            modelo = pmod;
            altura = palt;
            largura = plar;
            profundidade = pprof;
            peso = ppeso;
            tipo = ptipo;
            instrumento = pins;
            estado = pest;
            preco = ppre;
            quantidade = pqtd;
            caminho = pcam;
        }

        #endregion

        #region Método de inserção de dados

        public string insere(string pnome, string pmarca, string pdis, string pcor, string pmod,
                           string palt, string plar, string pprof, string ppeso, string ptipo,
                           string pins, string pest, string pcam, decimal ppre, int pqtd)
        {
            try
            {
                //Comando DML
                string sql = "INSERT INTO INSTRUMENTO (NOME, MARCA, DISTRIBUIDOR, COR, MODELO,  " +
                             "ALTURA, LARGURA, PROFUNDIDADE, PESO, TIPO, INSTRUMENTO, ESTADO, " +
                             "PRECO, QUANTIDADE, IMGCAM) " +
                             "VALUES (@NOME, @MARCA, @DISTRIBUIDOR, @COR, @MODELO,  " +
                             "@ALTURA, @LARGURA, @PROFUNDIDADE, @PESO, @TIPO, @INSTRUMENTO, @ESTADO, " +
                             "@PRECO, @QUANTIDADE, @IMGCAM) ";

                //Instanciando os métodos SQL
                SqlCommand cmd = new SqlCommand(sql, bd.conecta());

                cmd.Parameters.AddWithValue("@NOME", pnome);
                cmd.Parameters.AddWithValue("@MARCA", pmarca);
                cmd.Parameters.AddWithValue("@DISTRIBUIDOR", pdis);
                cmd.Parameters.AddWithValue("@COR", pcor);
                cmd.Parameters.AddWithValue("@MODELO", pmod);
                cmd.Parameters.AddWithValue("@ALTURA", palt);
                cmd.Parameters.AddWithValue("@LARGURA", plar);
                cmd.Parameters.AddWithValue("@PROFUNDIDADE", pprof);
                cmd.Parameters.AddWithValue("@PESO", ppeso);
                cmd.Parameters.AddWithValue("@TIPO", ptipo);
                cmd.Parameters.AddWithValue("@INSTRUMENTO", pins);
                cmd.Parameters.AddWithValue("@ESTADO", pest);
                cmd.Parameters.AddWithValue("@PRECO", ppre);
                cmd.Parameters.AddWithValue("@QUANTIDADE", pqtd);
                cmd.Parameters.AddWithValue("@IMGCAM", pcam);

                cmd.ExecuteNonQuery();

                bd.desconecta(cmd.Connection);

                return "Instrumento inserido com sucesso.";
            }
            catch (Exception ex)
            {
                return "Erro ao cadastrar o instrumento  \n\n" + ex.Message;
            }
        }

        #endregion

        #region Sobrecarga de métodos

        public Instrumento()
        {}

        #endregion

        #region Método de consulta

        public DataTable consulta()
        {
            try
            {
                DataTable dt = new DataTable();

                //Comando DQL
                string sql = "SELECT COD_INSTRUMENTO, NOME, MARCA, DISTRIBUIDOR, COR, MODELO,  " +
                             "ALTURA, LARGURA, PROFUNDIDADE, PESO, TIPO, INSTRUMENTO, ESTADO, " +
                             "PRECO, QUANTIDADE, IMGCAM FROM INSTRUMENTO";

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

        public string alterar(string pcins, string pnome, string pmarca, string pdis, 
                              string pcor, string pmod, string palt, string plar, 
                              string pprof, string ppeso, string ptipo,
                              string pins, string pest, string pcam, decimal ppre, int pqtd)
        {
            try
            {
                //Comando DML
                string sql = "UPDATE INSTRUMENTO " + 
                             " SET NOME  = @NOME" + 
                             ", MARCA  = @MARCA" + 
                             ", DISTRIBUIDOR = @DISTRIBUIDOR" + 
                             ", COR = @COR" + 
                             ", MODELO = @MODELO" + 
                             ", ALTURA = @ALTURA" + 
                             ", LARGURA = @LARGURA" + 
                             ", PROFUNDIDADE = @PROFUNDIDADE" + 
                             ", PESO = @PESO" + 
                             ", TIPO = @TIPO" + 
                             ", INSTRUMENTO = @INSTRUMENTO" + 
                             ", ESTADO = @ESTADO" + 
                             ", PRECO = @PRECO" + 
                             ", QUANTIDADE = @QUANTIDADE" +
                             ", IMGCAM = @IMGCAM" + 
                             " WHERE COD_INSTRUMENTO = " + pcins;

                
                SqlCommand cmd = new SqlCommand(sql, bd.conecta());

                cmd.Parameters.AddWithValue("@NOME", pnome);
                cmd.Parameters.AddWithValue("@MARCA", pmarca);
                cmd.Parameters.AddWithValue("@DISTRIBUIDOR", pdis);
                cmd.Parameters.AddWithValue("@COR", pcor);
                cmd.Parameters.AddWithValue("@MODELO", pmod);
                cmd.Parameters.AddWithValue("@ALTURA", palt);
                cmd.Parameters.AddWithValue("@LARGURA", plar);
                cmd.Parameters.AddWithValue("@PROFUNDIDADE", pprof);
                cmd.Parameters.AddWithValue("@PESO", ppeso);
                cmd.Parameters.AddWithValue("@TIPO", ptipo);
                cmd.Parameters.AddWithValue("@INSTRUMENTO", pins);
                cmd.Parameters.AddWithValue("@ESTADO", pest);
                cmd.Parameters.AddWithValue("@PRECO", ppre);
                cmd.Parameters.AddWithValue("@QUANTIDADE", pqtd);
                cmd.Parameters.AddWithValue("@IMGCAM", pcam);

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