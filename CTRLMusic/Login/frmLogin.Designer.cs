namespace CTRLMusic
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.lblSenha = new MetroFramework.Controls.MetroLabel();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.btnEntrar = new MetroFramework.Controls.MetroButton();
            this.lklCadastrarUsuario = new MetroFramework.Controls.MetroLink();
            this.ttpAjuda = new MetroFramework.Components.MetroToolTip();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUsuario.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Style = MetroFramework.MetroColorStyle.Red;
            this.lblUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.lblUsuario, resources.GetString("lblUsuario.ToolTip"));
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUsuario.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription");
            this.txtUsuario.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName");
            this.txtUsuario.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor")));
            this.txtUsuario.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize")));
            this.txtUsuario.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode")));
            this.txtUsuario.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.txtUsuario.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout")));
            this.txtUsuario.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock")));
            this.txtUsuario.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle")));
            this.txtUsuario.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            this.txtUsuario.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtUsuario.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign")));
            this.txtUsuario.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex")));
            this.txtUsuario.CustomButton.ImageKey = resources.GetString("resource.ImageKey");
            this.txtUsuario.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.txtUsuario.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.txtUsuario.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize")));
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft")));
            this.txtUsuario.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.txtUsuario.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign")));
            this.txtUsuario.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation")));
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.txtUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Style = MetroFramework.MetroColorStyle.Red;
            this.txtUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtUsuario, resources.GetString("txtUsuario.ToolTip"));
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSenha
            // 
            resources.ApplyResources(this.lblSenha, "lblSenha");
            this.lblSenha.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSenha.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Style = MetroFramework.MetroColorStyle.Red;
            this.lblSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.lblSenha, resources.GetString("lblSenha.ToolTip"));
            // 
            // txtSenha
            // 
            resources.ApplyResources(this.txtSenha, "txtSenha");
            this.txtSenha.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSenha.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription1");
            this.txtSenha.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName1");
            this.txtSenha.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor1")));
            this.txtSenha.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize1")));
            this.txtSenha.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode1")));
            this.txtSenha.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage1")));
            this.txtSenha.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout1")));
            this.txtSenha.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock1")));
            this.txtSenha.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle1")));
            this.txtSenha.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
            this.txtSenha.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txtSenha.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign1")));
            this.txtSenha.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex1")));
            this.txtSenha.CustomButton.ImageKey = resources.GetString("resource.ImageKey1");
            this.txtSenha.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.txtSenha.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.txtSenha.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize1")));
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft1")));
            this.txtSenha.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.txtSenha.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign1")));
            this.txtSenha.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation1")));
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.txtSenha.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Style = MetroFramework.MetroColorStyle.Red;
            this.txtSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtSenha, resources.GetString("txtSenha.ToolTip"));
            this.txtSenha.UseSelectable = true;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEntrar
            // 
            resources.ApplyResources(this.btnEntrar, "btnEntrar");
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEntrar.Highlight = true;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnEntrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.btnEntrar, resources.GetString("btnEntrar.ToolTip"));
            this.btnEntrar.UseSelectable = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lklCadastrarUsuario
            // 
            resources.ApplyResources(this.lklCadastrarUsuario, "lklCadastrarUsuario");
            this.lklCadastrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lklCadastrarUsuario.ForeColor = System.Drawing.Color.White;
            this.lklCadastrarUsuario.Name = "lklCadastrarUsuario";
            this.lklCadastrarUsuario.Style = MetroFramework.MetroColorStyle.Red;
            this.lklCadastrarUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.lklCadastrarUsuario, resources.GetString("lklCadastrarUsuario.ToolTip"));
            this.lklCadastrarUsuario.UseSelectable = true;
            this.lklCadastrarUsuario.Click += new System.EventHandler(this.lklCadastrarUsuario_Click);
            // 
            // ttpAjuda
            // 
            this.ttpAjuda.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttpAjuda.StyleManager = null;
            this.ttpAjuda.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackImage = global::CTRLMusic.Properties.Resources._5_HEADER_ctrlmusicheader3;
            this.BackImagePadding = new System.Windows.Forms.Padding(40, 20, 0, 0);
            this.BackMaxSize = 250;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.Controls.Add(this.lklCadastrarUsuario);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ttpAjuda.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblUsuario;
        public MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroLabel lblSenha;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroButton btnEntrar;
        private MetroFramework.Controls.MetroLink lklCadastrarUsuario;
        private MetroFramework.Components.MetroToolTip ttpAjuda;
    }
}

