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
    class Midia
    {
        #region Atributos

        int ano_lancamento, quantidade;
        string nome, genero, artista, duracao, idioma, profundidade, estado, altura, peso, largura, tipo, marca, caminho;
        decimal preco;

        #endregion

        #region Instanciamento de classes

        Banco bd = new Banco();

        #endregion

        #region Método construtor

        public Midia(int pano, int pqtd, string pnome, string pgen, string part,
                     string pdur, string pidi, string pprof, string pest, string palt,
                     string ppeso, string plar, string ptipo, string pmarca, string pcam, decimal ppre)
        {
            //Parâmetros
            ano_lancamento = pano;
            quantidade = pqtd;
            nome = pnome;
            genero = pgen;
            artista = part;
            duracao = pdur;
            idioma = pidi;
            profundidade = pprof;
            estado = pest;
            altura = palt;
            peso = ppeso;
            largura = plar;
            tipo = ptipo;
            preco = ppre;
            marca = pmarca;
            caminho = pcam;
        }

        #endregion

        #region Método de inserção de dados

        public string insere(int pano, int pqtd, string pnome, string pgen, string part,
                             string pdur, string pidi, string pprof, string pest, string palt,
                             string ppeso, string plar, string ptipo, string pmarca, string pcam, decimal ppre)
        {
            try
            {
                //Comando DML
                string sql = "INSERT INTO MIDIA (NOME, GENERO, ANO_LANCAMENTO, ARTISTA, QUANTIDADE, " +
                                                "DURACAO, PRECO, IDIOMA, PROFUNDIDADE, ALTURA, PESO, " +
                                                " LARGURA, TIPO, ESTADO, MARCA, IMGCAM)" +
                             "VALUES (@NOME, @GENERO, @ANO_LANCAMENTO, @ARTISTA, " +
                                     "@QUANTIDADE, @DURACAO, @PRECO, @IDIOMA, @PROFUNDIDADE, " +
                                     "@ALTURA, @PESO, @LARGURA, @TIPO, @ESTADO, @MARCA, @IMGCAM)";

                //Instanciando os métodos SQL
                SqlCommand cmd = new SqlCommand(sql, bd.conecta());

                cmd.Parameters.AddWithValue("@NOME", pnome);
                cmd.Parameters.AddWithValue("@GENERO", pgen);
                cmd.Parameters.AddWithValue("@ANO_LANCAMENTO", pano);
                cmd.Parameters.AddWithValue("@ARTISTA", part);
                cmd.Parameters.AddWithValue("@QUANTIDADE", pqtd);
                cmd.Parameters.AddWithValue("@DURACAO", pdur);
                cmd.Parameters.AddWithValue("@PRECO", ppre);
                cmd.Parameters.AddWithValue("@IDIOMA", pidi);
                cmd.Parameters.AddWithValue("@PROFUNDIDADE", pprof);
                cmd.Parameters.AddWithValue("@ALTURA", palt);
                cmd.Parameters.AddWithValue("@PESO", ppeso);
                cmd.Parameters.AddWithValue("@LARGURA", plar);
                cmd.Parameters.AddWithValue("@TIPO", ptipo);                      //Comandos SQL
                cmd.Parameters.AddWithValue("@ESTADO", pest);
                cmd.Parameters.AddWithValue("@MARCA", pmarca);
                cmd.Parameters.AddWithValue("@IMGCAM", pcam);

                cmd.ExecuteNonQuery();

                bd.desconecta(cmd.Connection);

                return "Mídia inserida com sucesso.";
            }
            catch (Exception ex)
            {
                return "Erro ao cadastrar a mídia  \n\n" + ex.Message;
            }
        }

        #endregion

        #region Sobrecarga de métodos

        public Midia()
        { }

        #endregion

        #region Método de consulta

        public DataTable consulta()
        {
            try
            {
                DataTable dt = new DataTable();

                //Comando DQL
                string sql = "SELECT COD_MIDIA, NOME, ARTISTA, PRECO, " +
                             "ANO_LANCAMENTO, GENERO, DURACAO, QUANTIDADE, IDIOMA, TIPO, ESTADO, MARCA, " +
                             "PROFUNDIDADE, ALTURA, PESO, LARGURA, IMGCAM FROM MIDIA";

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

        #region Método de alteração

        public string alterar(string pcm, string pnome, string part, decimal ppre,
                              int pano, string pgen, string pdur, int pqtd, string pidi, 
                              string ptipo, string pest, string pmarca, string pprof,
                              string palt, string ppeso, string plar, string pcam)
        {
            try
            {
                //Comando DML
                string sql = "UPDATE MIDIA " + 
                             "SET NOME = @NOME" + 
                            ", ARTISTA = @ARTISTA" + 
                            ", ANO_LANCAMENTO = @ANO_LANCAMENTO" +
                            ", GENERO = @GENERO" + 
                            ", DURACAO = @DURACAO" + 
                            ", PRECO = @PRECO" + 
                            ", QUANTIDADE = @QUANTIDADE" +
                            ", IDIOMA = @IDIOMA" +
                            ", ESTADO = @ESTADO" + 
                            ", TIPO = @TIPO" +
                            ", PROFUNDIDADE = @PROFUNDIDADE" +
                            ", ALTURA = @ALTURA" +
                            ", PESO = @PESO" +
                            ", LARGURA = @LARGURA" +
                            ", MARCA = @MARCA" +
                            ", IMGCAM = @IMGCAM" + 
                            " WHERE COD_MIDIA = " + pcm;

                SqlCommand cmd = new SqlCommand(sql, bd.conecta());

                cmd.Parameters.AddWithValue("@NOME", pnome);
                cmd.Parameters.AddWithValue("@GENERO", pgen);
                cmd.Parameters.AddWithValue("@ANO_LANCAMENTO", pano);
                cmd.Parameters.AddWithValue("@ARTISTA", part);
                cmd.Parameters.AddWithValue("@QUANTIDADE", pqtd);
                cmd.Parameters.AddWithValue("@DURACAO", pdur);
                cmd.Parameters.AddWithValue("@PRECO", ppre);
                cmd.Parameters.AddWithValue("@IDIOMA", pidi);
                cmd.Parameters.AddWithValue("@PROFUNDIDADE", pprof);
                cmd.Parameters.AddWithValue("@ALTURA", palt);
                cmd.Parameters.AddWithValue("@PESO", ppeso);
                cmd.Parameters.AddWithValue("@LARGURA", plar);
                cmd.Parameters.AddWithValue("@TIPO", ptipo);                      //Comandos SQL
                cmd.Parameters.AddWithValue("@ESTADO", pest);
                cmd.Parameters.AddWithValue("@MARCA", pmarca);
                cmd.Parameters.AddWithValue("@IMGCAM", pcam);

                cmd.ExecuteNonQuery();

                return "Registro alterado com sucesso!";
            }
            catch (Exception ex)
            {
                return "Não foi possível alterar o registro\n" + ex.Message;
            }
        }

        #endregion
    }
}

