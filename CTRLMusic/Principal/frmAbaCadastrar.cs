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
    public partial class frmAbaCadastrar : MetroForm
    {
        #region Instanciamento de classes

        Som som = new Som();

        #endregion

        public frmAbaCadastrar()
        {
            InitializeComponent();
        }

        #region Eventos para abrirem telas de cadastros (Click)

        private void btnAcessorios_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroAcessorios f = new frmCadastroAcessorios();
                f.Show();

                som.Chimes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroFuncionario f = new frmCadastroFuncionario();
                f.Show();

                som.Chimes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInstrumento_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroInstrumento f = new frmCadastroInstrumento();
                f.Show();

                som.Chimes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMidia_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroMidia f = new frmCadastroMidia();
                f.Show();

                som.Chimes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
        
        
      
