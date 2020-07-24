namespace CTRLMusic
{
    partial class frmNovoUsuario
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
            this.gpbMedidas = new System.Windows.Forms.GroupBox();
            this.lblValida = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtConSenha = new MetroFramework.Controls.MetroTextBox();
            this.lblConSenha = new MetroFramework.Controls.MetroLabel();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.lblSenha = new MetroFramework.Controls.MetroLabel();
            this.lblNomeUsuario = new MetroFramework.Controls.MetroLabel();
            this.txtCodFuncionario = new MetroFramework.Controls.MetroTextBox();
            this.lblCodFuncionario = new MetroFramework.Controls.MetroLabel();
            this.chkAdministrador = new MetroFramework.Controls.MetroCheckBox();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.btnRetornar = new MetroFramework.Controls.MetroButton();
            this.ttpAjuda = new MetroFramework.Components.MetroToolTip();
            this.pgbLoad = new MetroFramework.Controls.MetroProgressBar();
            this.gpbMedidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMedidas
            // 
            this.gpbMedidas.Controls.Add(this.lblValida);
            this.gpbMedidas.Controls.Add(this.txtUsuario);
            this.gpbMedidas.Controls.Add(this.txtConSenha);
            this.gpbMedidas.Controls.Add(this.lblConSenha);
            this.gpbMedidas.Controls.Add(this.txtSenha);
            this.gpbMedidas.Controls.Add(this.lblSenha);
            this.gpbMedidas.Controls.Add(this.lblNomeUsuario);
            this.gpbMedidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbMedidas.Location = new System.Drawing.Point(23, 63);
            this.gpbMedidas.Name = "gpbMedidas";
            this.gpbMedidas.Size = new System.Drawing.Size(170, 225);
            this.gpbMedidas.TabIndex = 0;
            this.gpbMedidas.TabStop = false;
            this.gpbMedidas.Text = "Login";
            // 
            // lblValida
            // 
            this.lblValida.AutoSize = true;
            this.lblValida.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblValida.ForeColor = System.Drawing.Color.Black;
            this.lblValida.Location = new System.Drawing.Point(10, 207);
            this.lblValida.Name = "lblValida";
            this.lblValida.Size = new System.Drawing.Size(37, 15);
            this.lblValida.Style = MetroFramework.MetroColorStyle.Red;
            this.lblValida.TabIndex = 7;
            this.lblValida.Text = "Senha";
            this.lblValida.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(10, 60);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(147, 23);
            this.txtUsuario.Style = MetroFramework.MetroColorStyle.Red;
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtUsuario, "Escolha um nome de usuário (até 10 caracteres)");
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConSenha
            // 
            this.txtConSenha.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtConSenha.CustomButton.Image = null;
            this.txtConSenha.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtConSenha.CustomButton.Name = "";
            this.txtConSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConSenha.CustomButton.TabIndex = 1;
            this.txtConSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConSenha.CustomButton.UseSelectable = true;
            this.txtConSenha.CustomButton.Visible = false;
            this.txtConSenha.Lines = new string[0];
            this.txtConSenha.Location = new System.Drawing.Point(10, 180);
            this.txtConSenha.MaxLength = 32767;
            this.txtConSenha.Name = "txtConSenha";
            this.txtConSenha.PasswordChar = '●';
            this.txtConSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConSenha.SelectedText = "";
            this.txtConSenha.SelectionLength = 0;
            this.txtConSenha.SelectionStart = 0;
            this.txtConSenha.Size = new System.Drawing.Size(147, 23);
            this.txtConSenha.Style = MetroFramework.MetroColorStyle.Red;
            this.txtConSenha.TabIndex = 6;
            this.txtConSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtConSenha, "Confirme sua senha");
            this.txtConSenha.UseSelectable = true;
            this.txtConSenha.UseSystemPasswordChar = true;
            this.txtConSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtConSenha.TextChanged += new System.EventHandler(this.txtConSenha_TextChanged);
            // 
            // lblConSenha
            // 
            this.lblConSenha.AutoSize = true;
            this.lblConSenha.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblConSenha.Location = new System.Drawing.Point(10, 150);
            this.lblConSenha.Name = "lblConSenha";
            this.lblConSenha.Size = new System.Drawing.Size(146, 25);
            this.lblConSenha.Style = MetroFramework.MetroColorStyle.Red;
            this.lblConSenha.TabIndex = 5;
            this.lblConSenha.Text = "Confirme a senha";
            this.lblConSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(10, 120);
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(147, 23);
            this.txtSenha.Style = MetroFramework.MetroColorStyle.Red;
            this.txtSenha.TabIndex = 4;
            this.txtSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtSenha, "Escolha uma senha (até 10 caracteres)");
            this.txtSenha.UseSelectable = true;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSenha.Location = new System.Drawing.Point(10, 90);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(59, 25);
            this.lblSenha.Style = MetroFramework.MetroColorStyle.Red;
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomeUsuario.Location = new System.Drawing.Point(10, 30);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(147, 25);
            this.lblNomeUsuario.Style = MetroFramework.MetroColorStyle.Red;
            this.lblNomeUsuario.TabIndex = 1;
            this.lblNomeUsuario.Text = "Nome do Usuário";
            this.lblNomeUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtCodFuncionario
            // 
            // 
            // 
            // 
            this.txtCodFuncionario.CustomButton.Image = null;
            this.txtCodFuncionario.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtCodFuncionario.CustomButton.Name = "";
            this.txtCodFuncionario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodFuncionario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodFuncionario.CustomButton.TabIndex = 1;
            this.txtCodFuncionario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodFuncionario.CustomButton.UseSelectable = true;
            this.txtCodFuncionario.CustomButton.Visible = false;
            this.txtCodFuncionario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCodFuncionario.Lines = new string[0];
            this.txtCodFuncionario.Location = new System.Drawing.Point(199, 151);
            this.txtCodFuncionario.MaxLength = 10;
            this.txtCodFuncionario.Name = "txtCodFuncionario";
            this.txtCodFuncionario.PasswordChar = '\0';
            this.txtCodFuncionario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodFuncionario.SelectedText = "";
            this.txtCodFuncionario.SelectionLength = 0;
            this.txtCodFuncionario.SelectionStart = 0;
            this.txtCodFuncionario.Size = new System.Drawing.Size(186, 23);
            this.txtCodFuncionario.Style = MetroFramework.MetroColorStyle.Red;
            this.txtCodFuncionario.TabIndex = 9;
            this.txtCodFuncionario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodFuncionario.UseSelectable = true;
            this.txtCodFuncionario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodFuncionario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCodFuncionario
            // 
            this.lblCodFuncionario.AutoSize = true;
            this.lblCodFuncionario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCodFuncionario.Location = new System.Drawing.Point(199, 121);
            this.lblCodFuncionario.Name = "lblCodFuncionario";
            this.lblCodFuncionario.Size = new System.Drawing.Size(186, 25);
            this.lblCodFuncionario.Style = MetroFramework.MetroColorStyle.Red;
            this.lblCodFuncionario.TabIndex = 8;
            this.lblCodFuncionario.Text = "Código do Funcionário";
            this.lblCodFuncionario.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // chkAdministrador
            // 
            this.chkAdministrador.AutoSize = true;
            this.chkAdministrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAdministrador.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkAdministrador.Location = new System.Drawing.Point(210, 213);
            this.chkAdministrador.Name = "chkAdministrador";
            this.chkAdministrador.Size = new System.Drawing.Size(142, 25);
            this.chkAdministrador.Style = MetroFramework.MetroColorStyle.Red;
            this.chkAdministrador.TabIndex = 13;
            this.chkAdministrador.Text = "Administrador";
            this.chkAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAdministrador.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chkAdministrador.UseSelectable = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCadastrar.Highlight = true;
            this.btnCadastrar.Location = new System.Drawing.Point(285, 332);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 30);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetornar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRetornar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRetornar.Location = new System.Drawing.Point(23, 332);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(100, 30);
            this.btnRetornar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnRetornar.TabIndex = 14;
            this.btnRetornar.Text = "Fechar";
            this.btnRetornar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnRetornar.UseSelectable = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // ttpAjuda
            // 
            this.ttpAjuda.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttpAjuda.StyleManager = null;
            this.ttpAjuda.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pgbLoad
            // 
            this.pgbLoad.Location = new System.Drawing.Point(285, 265);
            this.pgbLoad.Name = "pgbLoad";
            this.pgbLoad.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.pgbLoad.Size = new System.Drawing.Size(100, 23);
            this.pgbLoad.Style = MetroFramework.MetroColorStyle.Red;
            this.pgbLoad.TabIndex = 44;
            this.pgbLoad.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmNovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.pgbLoad);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.chkAdministrador);
            this.Controls.Add(this.txtCodFuncionario);
            this.Controls.Add(this.lblCodFuncionario);
            this.Controls.Add(this.gpbMedidas);
            this.MaximizeBox = false;
            this.Name = "frmNovoUsuario";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Novo Usuário";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmNovoUsuario_Load);
            this.gpbMedidas.ResumeLayout(false);
            this.gpbMedidas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMedidas;
        private MetroFramework.Controls.MetroLabel lblSenha;
        private MetroFramework.Controls.MetroLabel lblNomeUsuario;
        private MetroFramework.Controls.MetroLabel lblConSenha;
        private MetroFramework.Controls.MetroLabel lblCodFuncionario;
        private MetroFramework.Controls.MetroLabel lblValida;
        private MetroFramework.Components.MetroToolTip ttpAjuda;
        private MetroFramework.Controls.MetroProgressBar pgbLoad;
        public MetroFramework.Controls.MetroTextBox txtUsuario;
        public MetroFramework.Controls.MetroTextBox txtSenha;
        public MetroFramework.Controls.MetroTextBox txtConSenha;
        public MetroFramework.Controls.MetroTextBox txtCodFuncionario;
        public MetroFramework.Controls.MetroCheckBox chkAdministrador;
        public MetroFramework.Controls.MetroButton btnCadastrar;
        public MetroFramework.Controls.MetroButton btnRetornar;
    }
}