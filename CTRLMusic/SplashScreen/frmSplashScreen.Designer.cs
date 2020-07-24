namespace CTRLMusic
{
    partial class frmSplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pgsSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // pgsSpinner
            // 
            this.pgsSpinner.BackColor = System.Drawing.SystemColors.Control;
            this.pgsSpinner.Location = new System.Drawing.Point(12, 12);
            this.pgsSpinner.Maximum = 100;
            this.pgsSpinner.Name = "pgsSpinner";
            this.pgsSpinner.Size = new System.Drawing.Size(128, 128);
            this.pgsSpinner.Style = MetroFramework.MetroColorStyle.Red;
            this.pgsSpinner.TabIndex = 1;
            this.pgsSpinner.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pgsSpinner.UseCustomBackColor = true;
            this.pgsSpinner.UseSelectable = true;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(153, 158);
            this.Controls.Add(this.pgsSpinner);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner pgsSpinner;

    }
}