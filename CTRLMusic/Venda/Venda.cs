using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CTRLMusic
{
    class Venda
    {
        #region Atributos

        string nome;
        decimal valor_unidade, desconto, valor_pago, valor_total, troco;
        int cod_produto, qtd_produto, qtd_venda;
        DateTime data_venda;

        #endregion

        #region Instanciamento de classes

        Banco bd = new Banco();

        #endregion

        #region Método construtor

        public Venda(string pnome, decimal pvuni, decimal pdes, decimal ppago, decimal ptotal,
                     decimal ptroco, int pcod, int pqtp, int pqtv, DateTime pdv)
        {
            nome = pnome;
            valor_unidade = pvuni;
            desconto = pdes;
            valor_pago = ppago;
            valor_total = ptotal;
            troco = ptroco;
            cod_produto = pcod;
            qtd_produto = pqtp;
            qtd_venda = pqtv;
            data_venda = pdv;
        }

        #endregion

        #region Método de inserção

        public string insere(string pnome, decimal pvuni, decimal pdes, decimal ppago, decimal ptotal,
                             decimal ptroco, int pcod, int pqtp, int pqtv, DateTime pdv)
        {
            try
            {
                string sql = "INSERT INTO VENDA (COD_PRODUTO, NOME_PRODUTO, QTD_PRODUTO, " +
                                                "VALOR_UNIDADE, DESCONTO, QTD_VENDA, VALOR_PAGO, DATA_VENDA, " +
                                                "VALOR_TOTAL, VALOR_TROCO)" + "\n" +
                             " VALUES (@COD_PRODUTO, @NOME_PRODUTO, @QTD_PRODUTO, " +
                                     "@VALOR_UNIDADE, @DESCONTO, @QTD_VENDA, @VALOR_PAGO, @DATA_VENDA, " +
                                     "@VALOR_TOTAL, @VALOR_TROCO)";

                SqlCommand cmd = new SqlCommand(sql, bd.conecta());

                cmd.Parameters.AddWithValue("@COD_PRODUTO", pcod);
                cmd.Parameters.AddWithValue("@NOME_PRODUTO", pnome);
                cmd.Parameters.AddWithValue("@QTD_PRODUTO", pqtp);
                cmd.Parameters.AddWithValue("@VALOR_UNIDADE", pvuni);
                cmd.Parameters.AddWithValue("@DESCONTO", pdes);
                cmd.Parameters.AddWithValue("@QTD_VENDA", pqtv);
                cmd.Parameters.AddWithValue("@VALOR_PAGO", ppago);
                cmd.Parameters.AddWithValue("@DATA_VENDA", pdv);
                cmd.Parameters.AddWithValue("@VALOR_TOTAL", ptotal);
                cmd.Parameters.AddWithValue("@VALOR_TROCO", ptroco);

                cmd.ExecuteNonQuery();

                bd.desconecta(cmd.Connection);

                return "Venda inserida com sucesso!";
            }
            catch (Exception ex)
            {
                return "Erro ao inserir venda! \n\n" + ex.Message;
            }
        }

        #endregion

        #region Sobrecarga de método

        public Venda()
        { }

        #endregion

        #region Método de consulta

        public DataTable consulta()
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = "SELECT COD_VENDA, COD_PRODUTO, NOME_PRODUTO, VALOR_TOTAL, VALOR_TROCO, VALOR_PAGO, " +
                             "VALOR_UNIDADE, DESCONTO, QTD_PRODUTO, QTD_VENDA, DATA_VENDA FROM VENDA";

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
    }
} 