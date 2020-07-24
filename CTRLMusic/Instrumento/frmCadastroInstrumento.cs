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

namespace CTRLMusic
{
    public partial class frmCadastroInstrumento : MetroFramework.Forms.MetroForm
    {
        #region Variáveis

        public string cod = null;

        string linha, caminhoImagem, nomeImagem, pasta;

        int i;

        #endregion

        #region Instanciamento de classes

        Som som = new Som();

        #endregion

        public frmCadastroInstrumento()
        {
            InitializeComponent();
        }

        #region Evento para carregar itens (Load)

        private void frmCadastroInstrumento_Load(object sender, EventArgs e)
        {
            try
            {
                cmbTipo.SelectedValueChanged += cmbTipo_SelectedValueChanged;

                pgbLoad.Visible = false;

                this.Icon = CTRLMusic.Properties.Resources._6_ICONE_drums;

                AddTipo();

                StringReader rd = new StringReader(CTRLMusic.Properties.Resources._9_TXT_estados); //instanciando o texto

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
                    MessageBox.Show("Informe o nome do tipo do instrumento!");
                }

                if (string.IsNullOrEmpty(cmbInstrumento.Text))
                {
                    MessageBox.Show("Informe o nome do instrumento!");
                }

                if (string.IsNullOrEmpty(cmbEstado.Text))
                {
                    MessageBox.Show("Informe o estado do instrumento!");
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
                    //Instanciando a classe 'Instrumento'
                    Instrumento ins = new Instrumento(txtNome.Text, txtMarca.Text, txtDistribuidor.Text,
                                                      txtCor.Text, txtModelo.Text, txtAltura.Text, txtLargura.Text,
                                                      txtProfundidade.Text, txtPeso.Text, cmbTipo.SelectedItem.ToString(),
                                                      cmbInstrumento.SelectedItem.ToString(), cmbEstado.SelectedItem.ToString(),
                                                      caminho, Convert.ToDecimal(txtPreco.Text),
                                                      Convert.ToInt16(txtQuantidade.Text));

                    pgbLoad.Visible = true;

                    for (i = 1; i < 100; i++)
                    {
                        pgbLoad.Increment(i);
                    }

                    som.Tada();

                    //Inserindo dados na tabela 'Instrumento'
                    MessageBox.Show(ins.insere(txtNome.Text, txtMarca.Text, txtDistribuidor.Text,
                                               txtCor.Text, txtModelo.Text, txtAltura.Text, txtLargura.Text,
                                               txtProfundidade.Text, txtPeso.Text, cmbTipo.SelectedItem.ToString(),
                                               cmbInstrumento.SelectedItem.ToString(), cmbEstado.SelectedItem.ToString(),
                                               caminho, Convert.ToDecimal(txtPreco.Text),
                                               Convert.ToInt16(txtQuantidade.Text)));


                    som.Notify();

                    //Opção de cadastrar outros instrumentos
                    var opcao = MessageBox.Show("Cadastrar outro instrumento?", "", MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    if (opcao == DialogResult.Yes)
                    {
                        pgbLoad.Visible = false;
                        pgbLoad.ResetText();

                        btnLimpar.Highlight = true;
                        btnLimpar.Refresh();
                    }
                    else
                        if (opcao == DialogResult.No)
                        {
                            //Fechar esse form e abrir o form 'Consultas'
                            Close();

                            frmConsultas cls = new frmConsultas();
                            cls.consulta = "ins";
                            cls.Show();
                        }
                }
                else
                {
                    Instrumento ins = new Instrumento();

                    som.Tada();

                    MessageBox.Show(ins.alterar(cod, txtNome.Text, txtMarca.Text, txtDistribuidor.Text,
                                                txtCor.Text, txtModelo.Text, txtAltura.Text, txtLargura.Text,
                                                txtProfundidade.Text, txtPeso.Text, cmbTipo.SelectedItem.ToString(),
                                                cmbInstrumento.SelectedItem.ToString(), cmbEstado.SelectedItem.ToString(),
                                                caminho, Convert.ToDecimal(txtPreco.Text), Convert.ToInt16(txtQuantidade.Text)));

                    //Fechar esse form e abrir o form 'Consultas'
                    Close();

                    frmConsultas cls = new frmConsultas();
                    cls.consulta = "ins";
                    cls.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para fechar Form (Click)

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Evento para Limpar TextBoxes (Click)

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNome.Text = ""; txtMarca.Text = ""; txtDistribuidor.Text = "";
                txtPreco.Text = ""; txtQuantidade.Text = "";
                txtCor.Text = ""; txtModelo.Text = ""; txtAltura.Text = "";
                txtLargura.Text = ""; txtProfundidade.Text = ""; txtPeso.Text = "";

                btnLimpar.Highlight = false;

                btnLimpar.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para carregar imagem no PictureBox (Click)

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

                    ptbImagem.BackgroundImage = imagem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para resetar imagem do PictureBox (Click)

        private void btnResetar_Click(object sender, EventArgs e)
        {
            ptbImagem.BackgroundImage = null;
        }

        #endregion

        #region Evento para preencher ComboBox (SelectedValueChanged)

        void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbInstrumento.Items.Clear();

                switch (cmbTipo.SelectedItem.ToString())
                {
                    case "Percussão":

                        StringReader sr = new StringReader(CTRLMusic.Properties.Resources._9_TXT_percussão);

                        do
                        {
                            linha = sr.ReadLine();

                            if (linha != null)
                            {
                                cmbInstrumento.Items.Add(linha);
                            }

                        } while (linha != null);


                        try
                        {
                            if (cod == null)
                            {
                                ptbImagem.BackgroundImage = null;                                                  //Zera a imagem
                                ptbImagem.BackgroundImage = CTRLMusic.Properties.Resources._7_PNG_drumstick;      //Adiciona imagem
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);                //Mostra o erro
                        }

                        break;

                    case "Cordas":

                        cmbInstrumento.Items.Clear();               //Limpa os itens

                        sr = new StringReader(CTRLMusic.Properties.Resources._9_TXT_cordas);

                        do
                        {
                            linha = sr.ReadLine();

                            if (linha != null)
                            {
                                cmbInstrumento.Items.Add(linha);
                            }

                        } while (linha != null);

                        try
                        {
                            if (cod == null)
                            {
                                ptbImagem.BackgroundImage = null;                                           //Zera a imagem
                                ptbImagem.BackgroundImage = CTRLMusic.Properties.Resources._7_PNG_pick;     //Adiciona imagem
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);             //Mostra o erro
                        }

                        break;

                    case "Sopro":

                        cmbInstrumento.Items.Clear();                   //Limpa os itens

                        sr = new StringReader(CTRLMusic.Properties.Resources._9_TXT_sopro);

                        do
                        {
                            linha = sr.ReadLine();

                            if (linha != null)
                            {
                                cmbInstrumento.Items.Add(linha);
                            }

                        } while (linha != null);

                        try
                        {
                            if (cod == null)
                            {
                                ptbImagem.BackgroundImage = null;                                           //Zera imagem
                                ptbImagem.BackgroundImage = CTRLMusic.Properties.Resources._7_PNG_flute;    //Adiciona imagem
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);                //Mostra o erro
                        }

                        break;

                    case "Teclas":

                        cmbInstrumento.Items.Clear();               //Limpa os itens

                        sr = new StringReader(CTRLMusic.Properties.Resources._9_TXT_teclas);

                        do
                        {
                            linha = sr.ReadLine();

                            if (linha != null)
                            {
                                cmbInstrumento.Items.Add(linha);
                            }

                        } while (linha != null);

                        try
                        {
                            if (cod == null)
                            {
                                ptbImagem.BackgroundImage = null;                                           //Zera imagem
                                ptbImagem.BackgroundImage = CTRLMusic.Properties.Resources._7_PNG_piano; //Adiciona imagem
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);            //Mostra o erro
                        }

                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para delimitar de caracteres (KeyPress)

        private void txtCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Delimitando só letras no txtNome
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Delimitando só dígitos no txtQuantidade
                e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Métodos para adicionar valores aos ComboBoxes (Método)

        public void AddTipo()
        {
            try
            {
                cmbTipo.Items.Add("Percussão");
                cmbTipo.Items.Add("Cordas");
                cmbTipo.Items.Add("Sopro");
                cmbTipo.Items.Add("Teclas");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
