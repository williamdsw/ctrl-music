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


namespace CTRLMusic
{
    public partial class frmCadastroFuncionario : MetroForm
    {
        #region Variáveis

        public string cod = null;

        int i;

        string linha, caminhoImagem, nomeImagem, pasta;

        #endregion

        #region Instanciamento de classes

        Som som = new Som();

        #endregion

        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        #region Evento para carregar itens (Load)

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
                pgbLoad.Visible = false;

                this.Icon = CTRLMusic.Properties.Resources._6_ICONE_worker;

                StringReader rd = new StringReader(CTRLMusic.Properties.Resources._9_TXT_uf); //instanciando o texto

                do                                              //faça
                {
                    linha = rd.ReadLine();                       //line = rd.readline

                    if (linha != null)                           //se line não for null
                    {
                        cmbUF.Items.Add(linha);       //add "line"
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
                if (cmbCargo.Text == null)
                {
                    MessageBox.Show("Informe o cargo do funcionário!");
                }

                if (cmbGenero.Text == null)
                {
                    MessageBox.Show("Informe o gênero do funcionário");
                }

                if (cmbTurno.Text == null)
                {
                    MessageBox.Show("Informe o turno do funcionário!");
                }

                if (cmbUF.Text == null)
                {
                    MessageBox.Show("Informe a sigla UF do funcionário!");
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

                if (cod == null)
                {
                   
                    //Instanciando o banco
                    Banco bd = new Banco();

                    //instanciando a classe 'Funcionario'
                    Funcionario fun = new Funcionario(txtNome.Text, cmbTurno.SelectedItem.ToString(), mskRG.Text,
                                                      mskCPF.Text, mskResidencial.Text, mskCelular.Text,
                                                      cmbGenero.SelectedItem.ToString(), txtEmail.Text,
                                                      cmbCargo.SelectedItem.ToString(), txtEndereco.Text, txtBairro.Text,
                                                      txtCidade.Text, cmbUF.SelectedItem.ToString(), mskCEP.Text, caminho,
                                                      Convert.ToDateTime(mskDataNascimento.Text), DateTime.Today);
                                                      
                    pgbLoad.Visible = true;

                    for (i = 1; i < 100; i++)
                    {
                        pgbLoad.Increment(i);
                    }

                    som.Tada();

                    
                    //inserindo dados no tabela 'Funcionario'
                    MessageBox.Show(fun.insere(txtNome.Text, cmbTurno.SelectedItem.ToString(), mskRG.Text,
                                               mskCPF.Text, mskResidencial.Text, mskCelular.Text,
                                               cmbGenero.SelectedItem.ToString(), txtEmail.Text,
                                               cmbCargo.SelectedItem.ToString(), txtEndereco.Text, txtBairro.Text,
                                               txtCidade.Text, cmbUF.SelectedItem.ToString(), mskCEP.Text, caminho,
                                               Convert.ToDateTime(mskDataNascimento.Text), DateTime.Today));
                                               


                    //Depois de cadastrar um funcionário, irá abrir a tela de cadastrar um novo usuário
                    frmNovoUsuario fnu = new frmNovoUsuario();

                    fnu.nome = txtNome.Text;

                    fnu.Show();

                    som.Chimes();

                    Close();
                }
                else
                {
                     if (File.Exists(caminho))
                    {
                        File.Delete(caminho);

                        File.Copy(ofdAbrir.FileName, caminho);
                    }
                    else
                    {
                        File.Copy(ofdAbrir.FileName, caminho);
                    }

                    Funcionario fun = new Funcionario();

                    som.Tada();

                    MessageBox.Show(fun.alterar(cod, txtNome.Text, cmbTurno.SelectedItem.ToString(), mskRG.Text,
                                               mskCPF.Text, mskResidencial.Text, mskCelular.Text,
                                               cmbGenero.SelectedItem.ToString(), txtEmail.Text,
                                               cmbCargo.SelectedItem.ToString(), txtEndereco.Text, txtBairro.Text,
                                               txtCidade.Text, cmbUF.SelectedItem.ToString(), mskCEP.Text, caminho,
                                               Convert.ToDateTime(mskDataNascimento.Text)));
              
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para fechar o form (Click)

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Evento para limpar TextBoxes e MaskedTextBoxes (Click)

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNome.Text = ""; mskRG.Text = ""; mskCPF.Text = ""; txtEmail.Text = "";
                mskDataNascimento.Text = ""; txtEndereco.Text = ""; txtBairro.Text = ""; mskResidencial.Text = "";
                mskCEP.Text = ""; mskCelular.Text = ""; txtCidade.Text = ""; 
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
            if (cod == null)
            {
                ptbImagem.BackgroundImage = null;
            }
        }

        #endregion

        #region Evento para delimitar caracteres (KeyPress)

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Delimitando só letras no txtNome
                e.Handled = !(char.IsLetter(e.KeyChar)) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
