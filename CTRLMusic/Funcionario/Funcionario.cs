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
    class Funcionario
    {
        #region Atributos

        string nome, turno, rg, cpf, residencial, celular, genero, email, cargo, endereco, bairro, cidade, uf, cep, caminho;
        DateTime data_nascimento, data_cadastro;

        #endregion

        #region Instanciando o banco

        Banco bd = new Banco();

        #endregion

        #region Método construtor

        public Funcionario(string pnome, string pturno, string prg, string pcpf,
                           string pres, string pcel, string pgen, string pemail,
                           string pcar, string pend, string pbai, string pcid,
                           string puf, string pcep, string pcam, DateTime pdn, DateTime pdc)
        {
            //Parâmetros
            nome = pnome;
            turno = pturno;
            rg = prg;
            cpf = pcpf;
            residencial = pres;
            celular = pcel;
            genero = pgen;
            email = pemail;
            cargo = pcar;
            endereco = pend;
            bairro = pbai;
            cidade = pcid;
            uf = puf;
            cep = pcep;
            data_nascimento = pdn;
            data_cadastro = pdc;
            caminho = pcam;
        }

        #endregion

        #region Método de inserção de dados

        public string insere(string pnome, string pturno, string prg, string pcpf,
                             string pres, string pcel, string pgen, string pemail,
                             string pcar, string pend, string pbai, string pcid,
                             string puf, string pcep, string pcam, DateTime pdn, DateTime pdc)
        {
            try
            {
                //Comando DML
                string sql = "INSERT INTO FUNCIONARIO (NOME, CPF, RG, DATA_NASCIMENTO, DATA_CADASTRO, " +
                             "TURNO, TEL_RESIDENCIAL, TEL_CELULAR, EMAIL, GENERO, CARGO, ENDERECO, " +
                             "BAIRRO, CIDADE, UF, CEP, IMGCAM)" +
                             "VALUES (@NOME, @CPF, @RG, @DATA_NASCIMENTO, @DATA_CADASTRO, " +
                             "@TURNO, @TEL_RESIDENCIAL, @TEL_CELULAR, @EMAIL, @GENERO, @CARGO, @ENDERECO, " +
                             "@BAIRRO, @CIDADE, @UF, @CEP, @IMGCAM)";

                //Instanciando os métodos SQL
                SqlCommand cmd = new SqlCommand(sql, bd.conecta());

                cmd.Parameters.AddWithValue("@NOME", pnome);
                cmd.Parameters.AddWithValue("@RG", prg);
                cmd.Parameters.AddWithValue("@CPF", pcpf);
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", pdn);
                cmd.Parameters.AddWithValue("@DATA_CADASTRO", pdc);
                cmd.Parameters.AddWithValue("@TURNO", pturno);
                cmd.Parameters.AddWithValue("@TEL_RESIDENCIAL", pres);
                cmd.Parameters.AddWithValue("@TEL_CELULAR", pcel);
                cmd.Parameters.AddWithValue("@EMAIL", pemail);
                cmd.Parameters.AddWithValue("@GENERO", pgen);
                cmd.Parameters.AddWithValue("@CARGO", pcar);
                cmd.Parameters.AddWithValue("@ENDERECO", pend);
                cmd.Parameters.AddWithValue("@BAIRRO", pbai);
                cmd.Parameters.AddWithValue("@CIDADE", pcid);
                cmd.Parameters.AddWithValue("@UF", puf);
                cmd.Parameters.AddWithValue("@CEP", pcep);
                cmd.Parameters.AddWithValue("@IMGCAM", pcam);

                cmd.ExecuteNonQuery();

                bd.desconecta(cmd.Connection);

                return "Funcionário cadastrado com sucesso";
            }
            catch (Exception ex)
            {
                return "Erro ao cadastrar o funcionário \n\n" + ex.Message;
            }
        }

        #endregion

        #region Sobrecarga de método

        public Funcionario()
        { }

        #endregion

        #region Método de consulta

        public DataTable consulta()
        {
            try
            {
                DataTable dt = new DataTable();

                //Comando DQL
                string sql = "SELECT COD_FUNCIONARIO, NOME, RG, CPF, TURNO, " +
                             "DATA_NASCIMENTO, DATA_CADASTRO, TEL_RESIDENCIAL, TEL_CELULAR, " +
                             "EMAIL, GENERO, CARGO, ENDERECO, BAIRRO, CIDADE, UF, CEP, IMGCAM " +
                             "FROM FUNCIONARIO";

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

        #region Método para obter código do funcionário

        public string codigo(string pnome)
        {
            try
            {
                int cod;

                //Comando DQL
                string sql = "SELECT COD_FUNCIONARIO FROM FUNCIONARIO " +
                             "WHERE NOME = " + "'" + pnome + "'";

                SqlConnection cnn = bd.conecta();

                SqlCommand cmd = new SqlCommand(sql, cnn);

                SqlDataReader dr = cmd.ExecuteReader();          //Retorna um valor do comando SELECT

                dr.Read();

                cod = Convert.ToInt16(dr["COD_FUNCIONARIO"]);

                bd.desconecta(cnn);

                return cod.ToString();
            }
            catch(Exception ex)
            {
                return "Erro!\n" + ex.Message;
            }
        }

        #endregion

        #region Método de alteração

        public string alterar(string pcfun, string pnome, string pturno, string prg, string pcpf,
                             string pres, string pcel, string pgen, string pemail,
                             string pcar, string pend, string pbai, string pcid,
                             string puf, string pcep, string pcam, DateTime pdn)                    
        {
            try
            {
                //Comando DML
                string sql = "UPDATE FUNCIONARIO " +
                             "SET NOME = @NOME" +
                             ", RG = @RG" +
                             ", CPF = @CPF" +
                             ", DATA_NASCIMENTO = @DATA_NASCIMENTO" +
                             ", TURNO = @TURNO" +
                             ", TEL_RESIDENCIAL = @TEL_RESIDENCIAL" +
                             ", TEL_CELULAR = @TEL_CELULAR" +
                             ", EMAIL = @EMAIL" + 
                             ", GENERO = @GENERO" +
                             ", CARGO = @CARGO" +
                             ", ENDERECO = @ENDERECO" +
                             ", BAIRRO = @BAIRRO" +
                             ", CIDADE = @CIDADE" +
                             ", UF = @UF" +
                             ", CEP = @CEP" +
                             ", IMGCAM = @IMGCAM" +
                             " WHERE COD_FUNCIONARIO = " + pcfun;

                SqlCommand cmd = new SqlCommand(sql, bd.conecta());

                cmd.Parameters.AddWithValue("@NOME", pnome);
                cmd.Parameters.AddWithValue("@RG", prg);
                cmd.Parameters.AddWithValue("@CPF", pcpf);
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", pdn);
                cmd.Parameters.AddWithValue("@TURNO", pturno);
                cmd.Parameters.AddWithValue("@TEL_RESIDENCIAL", pres);
                cmd.Parameters.AddWithValue("@TEL_CELULAR", pcel);
                cmd.Parameters.AddWithValue("@EMAIL", pemail);
                cmd.Parameters.AddWithValue("@GENERO", pgen);
                cmd.Parameters.AddWithValue("@CARGO", pcar);
                cmd.Parameters.AddWithValue("@ENDERECO", pend);
                cmd.Parameters.AddWithValue("@BAIRRO", pbai);
                cmd.Parameters.AddWithValue("@CIDADE", pcid);
                cmd.Parameters.AddWithValue("@UF", puf);
                cmd.Parameters.AddWithValue("@CEP", pcep);
                cmd.Parameters.AddWithValue("@IMGCAM", pcam);
                
                cmd.ExecuteNonQuery();

                bd.desconecta(cmd.Connection);

                return "Registro alterado com sucesso!";
            }
            catch (Exception ex)
            {
                return "Não foi possível alterar o registro \n\n" + ex.Message;
            }
        }

        #endregion
    }
}
