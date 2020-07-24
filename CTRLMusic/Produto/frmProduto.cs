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
    public partial class frmProduto : MetroForm
    {
        public frmProduto()
        {
            InitializeComponent();

            this.Icon = CTRLMusic.Properties.Resources._6_ICONE_product;
        }

        #region Evento para fechar Form
  
        private void btnRetonar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
