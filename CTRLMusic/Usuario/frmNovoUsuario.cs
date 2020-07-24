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
using System.Timers;

namespace CTRLMusic
{
    public partial class frmNovoUsuario : MetroForm
    {
        #region Variáveis

        public string nome;

        int i;

        public string cod = null;

        #endregion

        #region Instanciamento de classes

        Som som = new Som();

        Funcionario fun = new Funcionario();

        #endregion

        public frmNovoUsuario()
        {
            InitializeComponent();
        }

        #region Evento para carregar itens (Load)

        private void frmNovoUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                txtCodFuncionario.Text = fun.codigo(nome);

                lblValida.Visible = false;

                txtCodFuncionario.Enabled = false;

                pgbLoad.Visible = false;

                this.Icon = CTRLMusic.Properties.Resources._6_ICONE_user;
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
                //Instanciando o banco
                Banco bd = new Banco();

                if (cod == null)
                {
                    //Se a senha for igual à senha confirmada, vai ser cadastrado o usuário
                    if (txtConSenha.Text == txtSenha.Text)
                    {
                        //instanciando a classe 'Usuario'
                        Usuario user = new Usuario(txtUsuario.Text,
                                                 txtSenha.Text,
                                                 txtConSenha.Text,
                                                 Convert.ToInt16(txtCodFuncionario.Text),
                                                 chkAdministrador.Checked);

                        pgbLoad.Visible = true;

                        for (i = 1; i < 100; i++)
                        {
                            pgbLoad.Increment(i);
                        }

                        som.Tada();

                        //Inserindo dados na tabela 'Usuario'
                        MessageBox.Show(user.insere(txtUsuario.Text,
                                                 txtSenha.Text,
                                                 txtConSenha.Text,
                                                 Convert.ToInt16(txtCodFuncionario.Text),
                                                 chkAdministrador.Checked));

                        pgbLoad.Visible = false;

                        Close();
                    }
                    else
                    {
                        pgbLoad.Visible = false;

                        som.Chord();

                        MessageBox.Show("Senha inválida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    
                    Usuario user = new Usuario();

                    som.Tada();

                    MessageBox.Show(user.alterar("COD_USUARIO", cod, txtUsuario.Text, txtSenha.Text,
                                                 txtConSenha.Text, chkAdministrador.Checked));
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

        #region Evento para validar senha (TextChanged)

        private void txtConSenha_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblValida.Visible = true;

                if (txtConSenha.Text == txtSenha.Text)
                {
                    lblValida.Text = "Senha válida";
                }
                else
                {
                    lblValida.Text = "Senha inválida";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
