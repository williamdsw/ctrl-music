using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;


namespace CTRLMusic
{
    public partial class frmLogin : MetroForm
    {
        #region Instanciamento de Form

        frmPrincipal fpl = new frmPrincipal();

        #endregion

        #region Instanciamento de classes

        Som som = new Som();

        #endregion

        private frmSplashScreen splashScreen;
        private bool done = false;
 
        public frmLogin()
        {
            InitializeComponent();

            this.Load += new EventHandler(HandleLoginLoad);
            this.splashScreen = new frmSplashScreen();
        }

        #region Evento para carregar itens (Load)

        private void frmLogin_Load(object sender, EventArgs e)
        {
            fpl.FormClosed += new FormClosedEventHandler(fpl_FormClosed);

            this.Icon = CTRLMusic.Properties.Resources._6_ICONE_lock1;
        }

        #endregion

        #region Evento para entrar no sistema (Click)

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Instanciando a classe Login
                Login lg = new Login(txtUsuario.Text, txtSenha.Text);

                //Método de autenticação
                if (txtUsuario.Text != string.Empty && txtSenha.Text != string.Empty)
                {
                    if (lg.ExecutaLogin(txtUsuario.Text, txtSenha.Text))
                    {
                        som.LogOn();

                        MessageBox.Show("Bem vindo, " + txtUsuario.Text);
       
                        fpl.user = txtUsuario.Text;

                        fpl.Show();

                        som.Chimes();

                        this.Visible = false;
                    }
                    else
                    {
                        som.Chord();

                        MessageBox.Show("Usuário ou senha errada! \n\nTente de novo", "Erro ao entrar", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para abrir tela de cadastro de funcionário/usuário (Click)

        private void lklCadastrarUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario fcf = new frmCadastroFuncionario();

            fcf.Show();

            som.Chimes();
        }

        #endregion

        void fpl_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void HandleLoginLoad(object sender, EventArgs e)
        {
            this.Hide();

            Thread thread = new Thread(new ThreadStart(this.ShowSplashScreen));
            thread.Start();

            HardWorker worker = new HardWorker();

            worker.ProgressChanged += (o, ex) =>
            {
                this.splashScreen.UpdateProgress(ex.Progress);
            };

            worker.HardWorkDone += (o, ex) =>
            {
                done = true;
                this.Show();
            };

            worker.DoHardWork();
        }

        private void ShowSplashScreen()
        {
            splashScreen.Show();

            while (!done)
            {
                Application.DoEvents();
            }

            splashScreen.Close();
            this.splashScreen.Dispose();
        }
    }
}
            
