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
    public partial class frmAbaConsultar : MetroForm
    {
        #region Instanciamento de classes

        Som som = new Som();

        #endregion

        public frmAbaConsultar()
        {
            InitializeComponent();
        }

        #region Eventos para abrirem telas de consultas (Click)

        private void btnAcessorios_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultas cls = new frmConsultas();

                cls.consulta = "ace";
                cls.Show();

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
                frmConsultaFuncionario cfc = new frmConsultaFuncionario();

                cfc.Show();

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
                frmConsultas cls = new frmConsultas();

                cls.consulta = "ins";
                cls.Show();

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
                frmConsultas cls = new frmConsultas();

                cls.consulta = "mid";
                cls.Show();

                som.Chimes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaUsuario csu = new frmConsultaUsuario();

                csu.Show();

                som.Chimes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultas cls = new frmConsultas();

                cls.consulta = "vda";
                cls.Show();

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