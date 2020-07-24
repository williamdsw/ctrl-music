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

namespace CTRLMusic
{
    public partial class frmPrincipal : MetroForm
    {
        #region Variáveis

        public string user;

        #endregion

        #region Instanciamento de classes

        Som som = new Som();

        #endregion

        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region Evento que carrega valores de itens (Load)

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                lblBemVindo.Text = "Bem vindo, " + user + "!";
                lblData.Text = DateTime.Today.Date.ToLongDateString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para abrir aba de cadastro (Click)

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAbaCadastrar f = new frmAbaCadastrar();
                f.Show();

                som.Chimes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para abrir aba de consulta (Click)

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAbaConsultar fac = new frmAbaConsultar();
                fac.Show();

                som.Chimes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para abrir aba de vendas (Click)

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                frmAbaVender fav = new frmAbaVender();
                fav.Show();

                som.Chimes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para abrir Manual do Usuário (Click)

        private void btnManual_Click(object sender, EventArgs e)
        {
            try
            {
                String openPDFFile = @".\CTRLMusic_documentação.pdf";
                System.IO.File.WriteAllBytes(openPDFFile, CTRLMusic.Properties.Resources.CTRLMusic_documentação);
                System.Diagnostics.Process.Start(openPDFFile);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para fechar form (Click)

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
