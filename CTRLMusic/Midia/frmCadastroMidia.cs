using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Resources;
using System.Collections;

namespace CTRLMusic
{
    public partial class frmCadastroMidia : MetroForm
    {
        #region Variáveis

        public string cod = null;

        string linha, caminhoImagem, nomeImagem, pasta;

        int i;

        #endregion

        #region Instanciamento de classes

        Som som = new Som();

        #endregion

        public frmCadastroMidia()
        {
            InitializeComponent();
        }

        #region Evento para carregar itens (Load)

        private void frmCadastroMidia_Load(object sender, EventArgs e)
        {
            try
            {
                pgbLoad.Visible = false;

                this.Icon = CTRLMusic.Properties.Resources._6_ICONE_midia;

                //Carregar dados no cmbGenero
                StringReader rd = new StringReader(CTRLMusic.Properties.Resources._9_TXT_generos); //instanciando o texto

                do                                              //faça
                {
                    linha = rd.ReadLine();                       //line = rd.readline

                    if (linha != null)                           //se line não for null
                    {
                        cmbGenero.Items.Add(linha);       //add "line"
                    }
                } while (linha != null);                         //enquanto line não for null

                //Carregar dados no cmbTipo

                rd = new StringReader(CTRLMusic.Properties.Resources._9_TXT_tipos); //instanciando o texto

                do                                              //faça
                {
                    linha = rd.ReadLine();                       //line = rd.readline

                    if (linha != null)                           //se line não for null
                    {
                        cmbTipo.Items.Add(linha);       //add "line"
                    }
                } while (linha != null);                         //enquanto line não for null

                //Carregar dados no cmbEstado

                rd = new StringReader(CTRLMusic.Properties.Resources._9_TXT_estados); //instanciando o texto

                do                                              //faça
                {
                    linha = rd.ReadLine();                       //line = rd.readline

                    if (linha != null)                           //se line não for null
                    {
                        cmbEstado.Items.Add(linha);       //add "line"
                    }
                } while (linha != null);                         //enquanto line não for null
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para cadastrar (Click)

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbTipo.Text))
                {
                    MessageBox.Show("Informe o tipo da mídia!");
                }

                if (string.IsNullOrEmpty(cmbEstado.Text))
                {
                    MessageBox.Show("Informe o estado da mídia!");
                }

                if (string.IsNullOrEmpty(cmbGenero.Text))
                {
                    MessageBox.Show("Informe o gênero do artista");
                }

                pasta = @"C:\CTRLMusic Imagens";

                string caminho = pasta + "\\" + nomeImagem;

                if (!Directory.Exists(pasta))
                {
                    Directory.CreateDirectory(pasta);
                }

                if (File.Exists(caminho))
                {
                    File.Delete(caminho);

                    File.Copy(ofdAbrir.FileName, caminho);
                }
                else
                {
                    File.Copy(ofdAbrir.FileName, caminho);
                }

                //Instanciando o banco
                Banco bd = new Banco();

                if (cod == null)
                {
                    //Instanciando a classe 'Midia'
                    Midia mid = new Midia(Convert.ToInt16(txtAno.Text),
                                          Convert.ToInt16(txtQuantidade.Text),
                                          txtTitulo.Text, cmbGenero.Text,
                                          txtArtista.Text, txtDuracao.Text,
                                          txtIdioma.Text, txtProfundidade.Text,
                                          cmbEstado.SelectedItem.ToString(), txtAltura.Text, txtPeso.Text,
                                          txtLargura.Text, cmbTipo.SelectedItem.ToString(), txtMarca.Text, caminho,
                                          Convert.ToDecimal(txtPreco.Text));


                    pgbLoad.Visible = true;

                    for (i = 1; i < 100; i++)
                    {
                        pgbLoad.Increment(i);
                    }

                    som.Tada();

                    //Inserindo dados na tabela 'Midia'          
                    MessageBox.Show(mid.insere(Convert.ToInt16(txtAno.Text),
                                               Convert.ToInt16(txtQuantidade.Text),
                                               txtTitulo.Text, cmbGenero.Text,
                                               txtArtista.Text, txtDuracao.Text,
                                               txtIdioma.Text, txtProfundidade.Text,
                                               cmbEstado.SelectedItem.ToString(), txtAltura.Text, txtPeso.Text,
                                               txtLargura.Text, cmbTipo.SelectedItem.ToString(), txtMarca.Text, caminho,
                                               Convert.ToDecimal(txtPreco.Text)));

                    pgbLoad.Visible = false;

                    som.Notify();

                    //Opção de cadastrar outras mídias ou não

                    var opcao = MessageBox.Show("Cadastrar outra mídia?", "",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (opcao == DialogResult.Yes)
                    {
                        pgbLoad.ResetText();
                    }
                    else
                        if (opcao == DialogResult.No)
                        {
                            //Fechar esse form e abrir o form 'Consultas'
                            Close();

                            frmConsultas cls = new frmConsultas();
                            cls.consulta = "mid";
                            cls.Show();

                            som.Chimes();
                        }
                }
                else
                {
                    Midia mid = new Midia();

                    som.Tada();

                    MessageBox.Show(mid.alterar(cod, txtTitulo.Text, txtArtista.Text,
                                                Convert.ToDecimal(txtPreco.Text), Convert.ToInt16(txtAno.Text),
                                                cmbGenero.SelectedItem.ToString(), txtDuracao.Text,
                                                Convert.ToInt16(txtQuantidade.Text), txtIdioma.Text, cmbTipo.SelectedItem.ToString(),
                                                cmbEstado.SelectedItem.ToString(),
                                                txtMarca.Text, txtProfundidade.Text, txtAltura.Text, txtPeso.Text,
                                                txtLargura.Text, caminho));

                    //Fechar esse form e abrir o form 'Consultas'
                    Close();

                    frmConsultas cls = new frmConsultas();
                    cls.consulta = "mid";
                    cls.Show();

                    som.Chimes();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para fechar o Form (Click)

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Evento para limpar TextBoxes (Click)

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                txtTitulo.Text = ""; txtArtista.Text = ""; txtPreco.Text = "";
                txtMarca.Text = ""; txtAno.Text = ""; txtDuracao.Text = "";
                txtQuantidade.Text = "";
                txtIdioma.Text = ""; txtProfundidade.Text = ""; txtAltura.Text = "";
                txtPeso.Text = ""; txtLargura.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para carregar imagens no PictureBox (Click)

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAbrir.Filter = "Arquivos de imagem(*.jpg;*.bmp;*.gif;*.png;)|*.jpg;*.bmp;*.gif;*.png;";

                if (ofdAbrir.ShowDialog() == DialogResult.OK)
                {
                    caminhoImagem = ofdAbrir.FileName;

                    nomeImagem = Path.GetFileName(ofdAbrir.FileName);

                    Bitmap imagem = new Bitmap(caminhoImagem);

                    ptbImagem.SizeMode = PictureBoxSizeMode.StretchImage;

                    ptbImagem.Image = imagem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para resetar a imagem do PictureBox (Click)

        private void btnResetar_Click(object sender, EventArgs e)
        {
            if (cod == null)
            {
                ptbImagem.BackgroundImage = null;
            }
        }

        #endregion

        #region Eventos para delimitar de caracteres (KeyPress)

        private void txtIdioma_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Delimitando só letras no txtIdioma
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Delimitando só dígitos no txtAno
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Delimitando só dígitos no txtQuantidade
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        #endregion
    }
}
