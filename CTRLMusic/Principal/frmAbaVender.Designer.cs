namespace CTRLMusic
{
    partial class frmAbaVender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbaVender));
            this.ttpAjuda = new MetroFramework.Components.MetroToolTip();
            this.btnMidia = new System.Windows.Forms.Button();
            this.btnInstrumento = new System.Windows.Forms.Button();
            this.btnAcessorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ttpAjuda
            // 
            this.ttpAjuda.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttpAjuda.StyleManager = null;
            this.ttpAjuda.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnMidia
            // 
            resources.ApplyResources(this.btnMidia, "btnMidia");
            this.btnMidia.BackColor = System.Drawing.Color.Transparent;
            this.btnMidia.BackgroundImage = global::CTRLMusic.Properties.Resources._4_VENDER_sellmidia;
            this.btnMidia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMidia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMidia.FlatAppearance.BorderSize = 0;
            this.btnMidia.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMidia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMidia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMidia.Name = "btnMidia";
            this.ttpAjuda.SetToolTip(this.btnMidia, resources.GetString("btnMidia.ToolTip"));
            this.btnMidia.UseVisualStyleBackColor = false;
            this.btnMidia.Click += new System.EventHandler(this.btnMidia_Click);
            // 
            // btnInstrumento
            // 
            resources.ApplyResources(this.btnInstrumento, "btnInstrumento");
            this.btnInstrumento.BackColor = System.Drawing.Color.Transparent;
            this.btnInstrumento.BackgroundImage = global::CTRLMusic.Properties.Resources._4_VENDER_sellguitar;
            this.btnInstrumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstrumento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInstrumento.FlatAppearance.BorderSize = 0;
            this.btnInstrumento.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInstrumento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInstrumento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInstrumento.Name = "btnInstrumento";
            this.ttpAjuda.SetToolTip(this.btnInstrumento, resources.GetString("btnInstrumento.ToolTip"));
            this.btnInstrumento.UseVisualStyleBackColor = false;
            this.btnInstrumento.Click += new System.EventHandler(this.btnInstrumento_Click);
            // 
            // btnAcessorios
            // 
            resources.ApplyResources(this.btnAcessorios, "btnAcessorios");
            this.btnAcessorios.BackColor = System.Drawing.Color.Transparent;
            this.btnAcessorios.BackgroundImage = global::CTRLMusic.Properties.Resources._4_VENDER_sellstick;
            this.btnAcessorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcessorios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAcessorios.FlatAppearance.BorderSize = 0;
            this.btnAcessorios.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAcessorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAcessorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAcessorios.Name = "btnAcessorios";
            this.ttpAjuda.SetToolTip(this.btnAcessorios, resources.GetString("btnAcessorios.ToolTip"));
            this.btnAcessorios.UseVisualStyleBackColor = false;
            this.btnAcessorios.Click += new System.EventHandler(this.btnAcessorios_Click);
            // 
            // frmAbaVender
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.Controls.Add(this.btnInstrumento);
            this.Controls.Add(this.btnMidia);
            this.Controls.Add(this.btnAcessorios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbaVender";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ttpAjuda.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroToolTip ttpAjuda;
        private System.Windows.Forms.Button btnMidia;
        private System.Windows.Forms.Button btnInstrumento;
        private System.Windows.Forms.Button btnAcessorios;

    }
}