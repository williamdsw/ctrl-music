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
    public partial class frmAbaVender : MetroForm
    {
        #region Instanciamento de classes

        Som som = new Som();

        #endregion

        public frmAbaVender()
        {
            InitializeComponent();
        }

        #region Eventos para abrirem telas de venda (Click)

        private void btnAcessorios_Click(object sender, EventArgs e)
        {
            try
            {
                frmVenda fva = new frmVenda();

                fva.codvenda = "ace";

                som.Chimes();

                fva.Show();
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
                frmVenda fva = new frmVenda();

                fva.codvenda = "ins";

                som.Chimes();

                fva.Show();
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
                frmVenda fva = new frmVenda();

                fva.codvenda = "mid";

                som.Chimes();

                fva.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
