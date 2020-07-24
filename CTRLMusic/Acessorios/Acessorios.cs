using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;

namespace CTRLMusic
{
    class Acessorio
    {
        #region Atributos

        string nome, distribuidor, marca, cor, modelo, tipo, instrumento, altura, largura, profundidade, peso, caminho;
        decimal preco;
        int quantidade;

        #endregion

        Banco bd = new Banco();    //Instanciando o banco

        #region Método construtor

        public Acessorio(string pnome, string pmarca, string pdis, string pmod, string pcor, 
                         string ptipo, string pins, string palt, string plar, string pprof,
                         string ppeso, string pcam, decimal ppre, int pqtd)
        {
            //Parâmetros
            nome = pnome;
            marca = pmarca;
            distribuidor = pdis;
            modelo = pmod;
            cor = pcor;
            tipo = ptipo;
            instrumento = pins;
            altura = palt;
            largura = plar;
            profundidade = pprof;
            peso = ppeso;
            preco = ppre;
            quantidade = pqtd;
            caminho = pcam;
        }

        #endregion

        #region Método de inserção de dados

        public string insere(string pnome, string pmarca, string pdis, string pmod, string pcor,
                             string ptipo, string pins, string palt, string plar, string pprof,
                             string ppeso, string pcam, decimal ppre, int pqtd)
        {
            try                     //Tratamento de exceção
            {
                //Comando DML
                string sql = "INSERT INTO ACESSORIO (NOME, MARCA, DISTRIBUIDOR, MODELO, " +
                                                    "COR, TIPO, INSTRUMENTO, ALTURA, LARGURA, " +
                                                    "PROFUNDIDADE, PESO, PRECO, QUANTIDADE, IMGCAM) " +
                             "VALUES (@NOME, @MARCA, @DISTRIBUIDOR, @MODELO, " +
                                     "@COR, @TIPO, @INSTRUMENTO, @ALTURA, @LARGURA, " +
                                     "@PROFUNDIDADE, @PESO, @PRECO, @QUANTIDADE, @IMGCAM)";

                SqlCommand cmd = new SqlCommand(sql, bd.conecta());       //Instanciando os métodos SQL

                //Adiciona valor ao parametro
                cmd.Parameters.AddWithValue("@NOME", pnome);
                cmd.Parameters.AddWithValue("@MARCA", pmarca);
                cmd.Parameters.AddWithValue("@DISTRIBUIDOR", pdis);
                cmd.Parameters.AddWithValue("@MODELO", pmod);
                cmd.Parameters.AddWithValue("@COR", pcor);
                cmd.Parameters.AddWithValue("@TIPO", ptipo);
                cmd.Parameters.AddWithValue("@INSTRUMENTO", pins);
                cmd.Parameters.AddWithValue("@ALTURA", palt);
                cmd.Parameters.AddWithValue("@LARGURA", plar);
                cmd.Parameters.AddWithValue("@PROFUNDIDADE", pprof);
                cmd.Parameters.AddWithValue("@PESO", ppeso);
                cmd.Parameters.AddWithValue("@PRECO", ppre);
                cmd.Parameters.AddWithValue("@QUANTIDADE", pqtd);
                cmd.Parameters.AddWithValue("@IMGCAM", pcam);
                
                cmd.ExecuteNonQuery();      //Executa os comandos que não retornam dados

                bd.desconecta(cmd.Connection);      //Desconecta do banco
                
                return "Acessório registrado com sucesso!";         //retorna o sucesso do cadastro
            }
            catch (Exception ex)           //Excessão
            {
                return "Erro ao inserir acessório! \n\n" + ex.Message;      //retonar a causa do erro
            }
        }

        #endregion

        #region Sobrecarga de métodos

        public Acessorio()
        {}

        #endregion

        #region Método de consulta 

        public DataTable consulta()
        {
            DataTable dt = new DataTable();     //instancia um DataTable

            //Comando DQL
            string sql = "SELECT COD_ACESSORIO, NOME, MARCA, DISTRIBUIDOR, MODELO, " +
                         "COR, TIPO, INSTRUMENTO, ALTURA, LARGURA, " +
                         "PROFUNDIDADE, PESO, PRECO, QUANTIDADE, IMGCAM FROM ACESSORIO";

            SqlConnection cnn = bd.conecta();       //define conexão do banco

            SqlCommand cmd = new SqlCommand(sql, cnn);    //conecta ao banco

            SqlDataAdapter da = new SqlDataAdapter();     //instancia um DataAdapter
            da.SelectCommand = cmd;                             //define o comando a ser executado
            da.Fill(dt);                                        //Preenche o DataTable

            bd.desconecta(cnn);                                 //desconecta do banco

            return dt;                                          //retorna o DataTable
        }

        #endregion

        #region Método para alteração

        public string alterar(string pace, string pnome, string pmarca, string pdis, string pmod, string pcor,
                              string ptipo, string pins, string palt, string plar, string pprof,
                              string ppeso, string pcam, decimal ppre, int pqtd)                    
        {
            try                 //Tratamento de excessão
            {  
                //Comando SQL
                string sql = "UPDATE ACESSORIO " +  
                             "SET NOME = @NOME" +
                             ", MARCA = @MARCA" + 
                             ", DISTRIBUIDOR = @DISTRIBUIDOR" + 
                             ", MODELO = @MODELO" + 
                             ", COR = @COR" + 
                             ", TIPO = @TIPO" + 
                             ", INSTRUMENTO = @INSTRUMENTO" + 
                             ", ALTURA = @ALTURA" + 
                             ", LARGURA = @LARGURA" + 
                             ", PROFUNDIDADE = @PROFUNDIDADE" + 
                             ", PESO = @PESO" + 
                             ", QUANTIDADE = @QUANTIDADE" + 
                             ", PRECO = @PRECO" +
                             ", IMGCAM = @IMGCAM" + 
                             " WHERE COD_ACESSORIO = " + pace;

                SqlCommand cmd = new SqlCommand(sql, bd.conecta());       //Instancia os métodos sql

                //Adiciona valor ao parâmetro
                cmd.Parameters.AddWithValue("@NOME", pnome);
                cmd.Parameters.AddWithValue("@MARCA", pmarca);
                cmd.Parameters.AddWithValue("@DISTRIBUIDOR", pdis);
                cmd.Parameters.AddWithValue("@MODELO", pmod);
                cmd.Parameters.AddWithValue("@COR", pcor);
                cmd.Parameters.AddWithValue("@TIPO", ptipo);
                cmd.Parameters.AddWithValue("@INSTRUMENTO", pins);
                cmd.Parameters.AddWithValue("@ALTURA", palt);
                cmd.Parameters.AddWithValue("@LARGURA", plar);
                cmd.Parameters.AddWithValue("@PROFUNDIDADE", pprof);
                cmd.Parameters.AddWithValue("@PESO", ppeso);
                cmd.Parameters.AddWithValue("@PRECO", ppre);
                cmd.Parameters.AddWithValue("@QUANTIDADE", pqtd);
                cmd.Parameters.AddWithValue("@IMGCAM", pcam);

                cmd.ExecuteNonQuery();      //Executa os comandos que não retornam dados

                bd.desconecta(cmd.Connection);      //Desconecta do banco

                return "Registro alterado com sucesso!";        //Retorna o sucesso do cadastro
            }
            catch(Exception ex)             //Excessão
            {
               return "Não foi possível alterar o registro \n\n" + ex.Message;      //Retorna o erro
            }
        }

        #endregion
    }
}




     
