using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CTRLMusic
{
    public partial class frmSplashScreen : Form
    {
        private delegate void ProgressDelegate(int progress);

        private ProgressDelegate del;

        public frmSplashScreen()
        {
            InitializeComponent();

            del = this.UpdateProgressInternal;

            this.pgsSpinner.Maximum = 100;

            this.TransparencyKey = this.BackColor;

            pgsSpinner.BackColor = this.TransparencyKey;
        }

        public void UpdateProgressInternal(int progress)
        {
            if (this.Handle == null)
            {
                return;
            }

            this.pgsSpinner.Value = progress;
        }

        public void UpdateProgress(int progress)
        {
            this.Invoke(del, progress);
        }
    }
}
