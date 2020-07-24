namespace CTRLMusic
{
    partial class frmCadastroAcessorios
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
            MetroFramework.Controls.MetroLabel lblCor;
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.btnRetornar = new MetroFramework.Controls.MetroButton();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.lblDistribuidor = new MetroFramework.Controls.MetroLabel();
            this.txtDistribuidor = new MetroFramework.Controls.MetroTextBox();
            this.lblMarca = new MetroFramework.Controls.MetroLabel();
            this.lblAltura = new MetroFramework.Controls.MetroLabel();
            this.lblLargura = new MetroFramework.Controls.MetroLabel();
            this.txtMarca = new MetroFramework.Controls.MetroTextBox();
            this.txtAltura = new MetroFramework.Controls.MetroTextBox();
            this.txtLargura = new MetroFramework.Controls.MetroTextBox();
            this.cmbTipo = new MetroFramework.Controls.MetroComboBox();
            this.ptbImagem = new System.Windows.Forms.PictureBox();
            this.cmbInstrumento = new MetroFramework.Controls.MetroComboBox();
            this.lblQuantidade = new MetroFramework.Controls.MetroLabel();
            this.txtQuantidade = new MetroFramework.Controls.MetroTextBox();
            this.lblPreco = new MetroFramework.Controls.MetroLabel();
            this.txtPreco = new MetroFramework.Controls.MetroTextBox();
            this.gpbAcessorio = new System.Windows.Forms.GroupBox();
            this.btnResetar = new MetroFramework.Controls.MetroButton();
            this.btnCarregar = new MetroFramework.Controls.MetroButton();
            this.lblPeso = new MetroFramework.Controls.MetroLabel();
            this.lblProfundidade = new MetroFramework.Controls.MetroLabel();
            this.txtPeso = new MetroFramework.Controls.MetroTextBox();
            this.txtProfundidade = new MetroFramework.Controls.MetroTextBox();
            this.txtCor = new MetroFramework.Controls.MetroTextBox();
            this.pgbLoad = new MetroFramework.Controls.MetroProgressBar();
            this.lblObrigatorio = new MetroFramework.Controls.MetroLabel();
            this.txtModelo = new MetroFramework.Controls.MetroTextBox();
            this.lblModelo = new MetroFramework.Controls.MetroLabel();
            this.lblImagem = new MetroFramework.Controls.MetroLabel();
            this.lblInstrumento = new MetroFramework.Controls.MetroLabel();
            this.lblTipo = new MetroFramework.Controls.MetroLabel();
            this.ttpAjuda = new MetroFramework.Components.MetroToolTip();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            lblCor = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).BeginInit();
            this.gpbAcessorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.FontSize = MetroFramework.MetroLabelSize.Tall;
            lblCor.Location = new System.Drawing.Point(15, 265);
            lblCor.Name = "lblCor";
            lblCor.Size = new System.Drawing.Size(39, 25);
            lblCor.Style = MetroFramework.MetroColorStyle.Red;
            lblCor.TabIndex = 16;
            lblCor.Text = "Cor";
            lblCor.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCadastrar.Highlight = true;
            this.btnCadastrar.Location = new System.Drawing.Point(463, 597);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 30);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCadastrar.TabIndex = 31;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.btnCadastrar, "Para cadastrar o acessório");
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetornar.BackColor = System.Drawing.Color.LightGray;
            this.btnRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRetornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetornar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRetornar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRetornar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRetornar.Location = new System.Drawing.Point(25, 597);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(100, 30);
            this.btnRetornar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnRetornar.TabIndex = 29;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.btnRetornar, "Para cancelar o cadastro");
            this.btnRetornar.UseSelectable = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLimpar.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnLimpar.Location = new System.Drawing.Point(242, 597);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnLimpar.TabIndex = 30;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.btnLimpar, "Para limpar os campos");
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(15, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 25);
            this.lblNome.Style = MetroFramework.MetroColorStyle.Red;
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome*";
            this.lblNome.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(15, 45);
            this.txtNome.MaxLength = 150;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(160, 23);
            this.txtNome.Style = MetroFramework.MetroColorStyle.Red;
            this.txtNome.TabIndex = 1;
            this.txtNome.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtNome, "Insira o nome do acessório (até 150 caracteres)");
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDistribuidor
            // 
            this.lblDistribuidor.AutoSize = true;
            this.lblDistribuidor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDistribuidor.Location = new System.Drawing.Point(195, 15);
            this.lblDistribuidor.Name = "lblDistribuidor";
            this.lblDistribuidor.Size = new System.Drawing.Size(107, 25);
            this.lblDistribuidor.Style = MetroFramework.MetroColorStyle.Red;
            this.lblDistribuidor.TabIndex = 2;
            this.lblDistribuidor.Text = "Distribuídor*";
            this.lblDistribuidor.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtDistribuidor
            // 
            // 
            // 
            // 
            this.txtDistribuidor.CustomButton.Image = null;
            this.txtDistribuidor.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtDistribuidor.CustomButton.Name = "";
            this.txtDistribuidor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDistribuidor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDistribuidor.CustomButton.TabIndex = 1;
            this.txtDistribuidor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDistribuidor.CustomButton.UseSelectable = true;
            this.txtDistribuidor.CustomButton.Visible = false;
            this.txtDistribuidor.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDistribuidor.Lines = new string[0];
            this.txtDistribuidor.Location = new System.Drawing.Point(195, 43);
            this.txtDistribuidor.MaxLength = 100;
            this.txtDistribuidor.Name = "txtDistribuidor";
            this.txtDistribuidor.PasswordChar = '\0';
            this.txtDistribuidor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDistribuidor.SelectedText = "";
            this.txtDistribuidor.SelectionLength = 0;
            this.txtDistribuidor.SelectionStart = 0;
            this.txtDistribuidor.Size = new System.Drawing.Size(160, 23);
            this.txtDistribuidor.Style = MetroFramework.MetroColorStyle.Red;
            this.txtDistribuidor.TabIndex = 3;
            this.txtDistribuidor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtDistribuidor, "Informe o distribuídor do acessório (até 100 caracteres)");
            this.txtDistribuidor.UseSelectable = true;
            this.txtDistribuidor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDistribuidor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblMarca.Location = new System.Drawing.Point(15, 75);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(66, 25);
            this.lblMarca.Style = MetroFramework.MetroColorStyle.Red;
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca*";
            this.lblMarca.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAltura.Location = new System.Drawing.Point(195, 265);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(57, 25);
            this.lblAltura.Style = MetroFramework.MetroColorStyle.Red;
            this.lblAltura.TabIndex = 18;
            this.lblAltura.Text = "Altura";
            this.lblAltura.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLargura.Location = new System.Drawing.Point(15, 325);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(70, 25);
            this.lblLargura.Style = MetroFramework.MetroColorStyle.Red;
            this.lblLargura.TabIndex = 20;
            this.lblLargura.Text = "Largura";
            this.lblLargura.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtMarca
            // 
            // 
            // 
            // 
            this.txtMarca.CustomButton.Image = null;
            this.txtMarca.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtMarca.CustomButton.Name = "";
            this.txtMarca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMarca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMarca.CustomButton.TabIndex = 1;
            this.txtMarca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMarca.CustomButton.UseSelectable = true;
            this.txtMarca.CustomButton.Visible = false;
            this.txtMarca.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMarca.Lines = new string[0];
            this.txtMarca.Location = new System.Drawing.Point(15, 105);
            this.txtMarca.MaxLength = 100;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMarca.SelectedText = "";
            this.txtMarca.SelectionLength = 0;
            this.txtMarca.SelectionStart = 0;
            this.txtMarca.Size = new System.Drawing.Size(160, 23);
            this.txtMarca.Style = MetroFramework.MetroColorStyle.Red;
            this.txtMarca.TabIndex = 5;
            this.txtMarca.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtMarca, "Informe a marca do acessório (até 100 caracteres)");
            this.txtMarca.UseSelectable = true;
            this.txtMarca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMarca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAltura
            // 
            // 
            // 
            // 
            this.txtAltura.CustomButton.Image = null;
            this.txtAltura.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtAltura.CustomButton.Name = "";
            this.txtAltura.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAltura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAltura.CustomButton.TabIndex = 1;
            this.txtAltura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAltura.CustomButton.UseSelectable = true;
            this.txtAltura.CustomButton.Visible = false;
            this.txtAltura.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAltura.Lines = new string[0];
            this.txtAltura.Location = new System.Drawing.Point(195, 295);
            this.txtAltura.MaxLength = 20;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.PasswordChar = '\0';
            this.txtAltura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAltura.SelectedText = "";
            this.txtAltura.SelectionLength = 0;
            this.txtAltura.SelectionStart = 0;
            this.txtAltura.Size = new System.Drawing.Size(160, 23);
            this.txtAltura.Style = MetroFramework.MetroColorStyle.Red;
            this.txtAltura.TabIndex = 19;
            this.txtAltura.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtAltura, "Informe a altura do acessório (até 20 caracteres)");
            this.txtAltura.UseSelectable = true;
            this.txtAltura.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAltura.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLargura
            // 
            // 
            // 
            // 
            this.txtLargura.CustomButton.Image = null;
            this.txtLargura.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtLargura.CustomButton.Name = "";
            this.txtLargura.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLargura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLargura.CustomButton.TabIndex = 1;
            this.txtLargura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLargura.CustomButton.UseSelectable = true;
            this.txtLargura.CustomButton.Visible = false;
            this.txtLargura.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLargura.Lines = new string[0];
            this.txtLargura.Location = new System.Drawing.Point(15, 355);
            this.txtLargura.MaxLength = 20;
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.PasswordChar = '\0';
            this.txtLargura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLargura.SelectedText = "";
            this.txtLargura.SelectionLength = 0;
            this.txtLargura.SelectionStart = 0;
            this.txtLargura.Size = new System.Drawing.Size(157, 23);
            this.txtLargura.Style = MetroFramework.MetroColorStyle.Red;
            this.txtLargura.TabIndex = 21;
            this.txtLargura.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtLargura, "Informe a largura do acessório (até 20 caracteres)");
            this.txtLargura.UseSelectable = true;
            this.txtLargura.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLargura.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Percussão",
            "Cordas",
            "Vozes"});
            this.cmbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.ItemHeight = 23;
            this.cmbTipo.Location = new System.Drawing.Point(15, 225);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(157, 29);
            this.cmbTipo.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbTipo.TabIndex = 13;
            this.cmbTipo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.cmbTipo, "Escolha à classe do instrumento");
            this.cmbTipo.UseSelectable = true;
            // 
            // ptbImagem
            // 
            this.ptbImagem.BackgroundImage = global::CTRLMusic.Properties.Resources._7_PNG_drumstick;
            this.ptbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbImagem.InitialImage = null;
            this.ptbImagem.Location = new System.Drawing.Point(398, 45);
            this.ptbImagem.Name = "ptbImagem";
            this.ptbImagem.Size = new System.Drawing.Size(122, 118);
            this.ptbImagem.TabIndex = 24;
            this.ptbImagem.TabStop = false;
            // 
            // cmbInstrumento
            // 
            this.cmbInstrumento.AutoCompleteCustomSource.AddRange(new string[] {
            "Percussão",
            "Cordas",
            "Vozes"});
            this.cmbInstrumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbInstrumento.FormattingEnabled = true;
            this.cmbInstrumento.ItemHeight = 23;
            this.cmbInstrumento.Location = new System.Drawing.Point(195, 225);
            this.cmbInstrumento.Name = "cmbInstrumento";
            this.cmbInstrumento.Size = new System.Drawing.Size(160, 29);
            this.cmbInstrumento.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbInstrumento.TabIndex = 15;
            this.cmbInstrumento.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.cmbInstrumento, "Informe para qual instrumento ele será utilizado");
            this.cmbInstrumento.UseSelectable = true;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblQuantidade.Location = new System.Drawing.Point(195, 75);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(109, 25);
            this.lblQuantidade.Style = MetroFramework.MetroColorStyle.Red;
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade*";
            this.lblQuantidade.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtQuantidade
            // 
            // 
            // 
            // 
            this.txtQuantidade.CustomButton.Image = null;
            this.txtQuantidade.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtQuantidade.CustomButton.Name = "";
            this.txtQuantidade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantidade.CustomButton.TabIndex = 1;
            this.txtQuantidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantidade.CustomButton.UseSelectable = true;
            this.txtQuantidade.CustomButton.Visible = false;
            this.txtQuantidade.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtQuantidade.Lines = new string[0];
            this.txtQuantidade.Location = new System.Drawing.Point(195, 105);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.SelectionLength = 0;
            this.txtQuantidade.SelectionStart = 0;
            this.txtQuantidade.Size = new System.Drawing.Size(160, 23);
            this.txtQuantidade.Style = MetroFramework.MetroColorStyle.Red;
            this.txtQuantidade.TabIndex = 7;
            this.txtQuantidade.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtQuantidade, "Informe a quantidade (até 10 caracteres)");
            this.txtQuantidade.UseSelectable = true;
            this.txtQuantidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPreco.Location = new System.Drawing.Point(15, 135);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(62, 25);
            this.lblPreco.Style = MetroFramework.MetroColorStyle.Red;
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "Preço*";
            this.lblPreco.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtPreco
            // 
            // 
            // 
            // 
            this.txtPreco.CustomButton.Image = null;
            this.txtPreco.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtPreco.CustomButton.Name = "";
            this.txtPreco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPreco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPreco.CustomButton.TabIndex = 1;
            this.txtPreco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPreco.CustomButton.UseSelectable = true;
            this.txtPreco.CustomButton.Visible = false;
            this.txtPreco.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPreco.Lines = new string[0];
            this.txtPreco.Location = new System.Drawing.Point(15, 165);
            this.txtPreco.MaxLength = 20;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPreco.SelectedText = "";
            this.txtPreco.SelectionLength = 0;
            this.txtPreco.SelectionStart = 0;
            this.txtPreco.Size = new System.Drawing.Size(160, 23);
            this.txtPreco.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPreco.TabIndex = 9;
            this.txtPreco.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtPreco, "Preço do acessório (até 20 caracteres)");
            this.txtPreco.UseSelectable = true;
            this.txtPreco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPreco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gpbAcessorio
            // 
            this.gpbAcessorio.Controls.Add(this.lblAltura);
            this.gpbAcessorio.Controls.Add(this.cmbInstrumento);
            this.gpbAcessorio.Controls.Add(this.btnResetar);
            this.gpbAcessorio.Controls.Add(this.btnCarregar);
            this.gpbAcessorio.Controls.Add(this.lblPeso);
            this.gpbAcessorio.Controls.Add(this.lblProfundidade);
            this.gpbAcessorio.Controls.Add(this.txtAltura);
            this.gpbAcessorio.Controls.Add(this.txtPeso);
            this.gpbAcessorio.Controls.Add(this.lblLargura);
            this.gpbAcessorio.Controls.Add(this.cmbTipo);
            this.gpbAcessorio.Controls.Add(this.txtProfundidade);
            this.gpbAcessorio.Controls.Add(this.txtCor);
            this.gpbAcessorio.Controls.Add(this.txtLargura);
            this.gpbAcessorio.Controls.Add(this.ptbImagem);
            this.gpbAcessorio.Controls.Add(this.txtQuantidade);
            this.gpbAcessorio.Controls.Add(this.pgbLoad);
            this.gpbAcessorio.Controls.Add(this.lblObrigatorio);
            this.gpbAcessorio.Controls.Add(lblCor);
            this.gpbAcessorio.Controls.Add(this.txtModelo);
            this.gpbAcessorio.Controls.Add(this.txtNome);
            this.gpbAcessorio.Controls.Add(this.lblModelo);
            this.gpbAcessorio.Controls.Add(this.lblQuantidade);
            this.gpbAcessorio.Controls.Add(this.lblImagem);
            this.gpbAcessorio.Controls.Add(this.lblNome);
            this.gpbAcessorio.Controls.Add(this.txtDistribuidor);
            this.gpbAcessorio.Controls.Add(this.lblDistribuidor);
            this.gpbAcessorio.Controls.Add(this.lblInstrumento);
            this.gpbAcessorio.Controls.Add(this.lblTipo);
            this.gpbAcessorio.Controls.Add(this.lblPreco);
            this.gpbAcessorio.Controls.Add(this.txtPreco);
            this.gpbAcessorio.Controls.Add(this.lblMarca);
            this.gpbAcessorio.Controls.Add(this.txtMarca);
            this.gpbAcessorio.Location = new System.Drawing.Point(23, 63);
            this.gpbAcessorio.Name = "gpbAcessorio";
            this.gpbAcessorio.Size = new System.Drawing.Size(540, 510);
            this.gpbAcessorio.TabIndex = 0;
            this.gpbAcessorio.TabStop = false;
            // 
            // btnResetar
            // 
            this.btnResetar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetar.BackColor = System.Drawing.Color.LightGray;
            this.btnResetar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnResetar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnResetar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnResetar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResetar.Location = new System.Drawing.Point(407, 241);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(100, 30);
            this.btnResetar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnResetar.TabIndex = 28;
            this.btnResetar.Text = "Resetar";
            this.btnResetar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnResetar.UseSelectable = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregar.BackColor = System.Drawing.Color.LightGray;
            this.btnCarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCarregar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCarregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCarregar.Location = new System.Drawing.Point(407, 190);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(100, 30);
            this.btnCarregar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCarregar.TabIndex = 27;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCarregar.UseSelectable = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPeso.Location = new System.Drawing.Point(15, 385);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(47, 25);
            this.lblPeso.Style = MetroFramework.MetroColorStyle.Red;
            this.lblPeso.TabIndex = 24;
            this.lblPeso.Text = "Peso";
            this.lblPeso.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblProfundidade
            // 
            this.lblProfundidade.AutoSize = true;
            this.lblProfundidade.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProfundidade.Location = new System.Drawing.Point(195, 325);
            this.lblProfundidade.Name = "lblProfundidade";
            this.lblProfundidade.Size = new System.Drawing.Size(115, 25);
            this.lblProfundidade.Style = MetroFramework.MetroColorStyle.Red;
            this.lblProfundidade.TabIndex = 22;
            this.lblProfundidade.Text = "Profundidade";
            this.lblProfundidade.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtPeso
            // 
            // 
            // 
            // 
            this.txtPeso.CustomButton.Image = null;
            this.txtPeso.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtPeso.CustomButton.Name = "";
            this.txtPeso.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPeso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPeso.CustomButton.TabIndex = 1;
            this.txtPeso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPeso.CustomButton.UseSelectable = true;
            this.txtPeso.CustomButton.Visible = false;
            this.txtPeso.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPeso.Lines = new string[0];
            this.txtPeso.Location = new System.Drawing.Point(15, 415);
            this.txtPeso.MaxLength = 20;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.PasswordChar = '\0';
            this.txtPeso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPeso.SelectedText = "";
            this.txtPeso.SelectionLength = 0;
            this.txtPeso.SelectionStart = 0;
            this.txtPeso.Size = new System.Drawing.Size(157, 23);
            this.txtPeso.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPeso.TabIndex = 25;
            this.txtPeso.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtPeso, "Informe o peso do acessório (até 20 caracteres)");
            this.txtPeso.UseSelectable = true;
            this.txtPeso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPeso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProfundidade
            // 
            // 
            // 
            // 
            this.txtProfundidade.CustomButton.Image = null;
            this.txtProfundidade.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtProfundidade.CustomButton.Name = "";
            this.txtProfundidade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProfundidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProfundidade.CustomButton.TabIndex = 1;
            this.txtProfundidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProfundidade.CustomButton.UseSelectable = true;
            this.txtProfundidade.CustomButton.Visible = false;
            this.txtProfundidade.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProfundidade.Lines = new string[0];
            this.txtProfundidade.Location = new System.Drawing.Point(195, 360);
            this.txtProfundidade.MaxLength = 20;
            this.txtProfundidade.Name = "txtProfundidade";
            this.txtProfundidade.PasswordChar = '\0';
            this.txtProfundidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProfundidade.SelectedText = "";
            this.txtProfundidade.SelectionLength = 0;
            this.txtProfundidade.SelectionStart = 0;
            this.txtProfundidade.Size = new System.Drawing.Size(160, 23);
            this.txtProfundidade.Style = MetroFramework.MetroColorStyle.Red;
            this.txtProfundidade.TabIndex = 23;
            this.txtProfundidade.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtProfundidade, "Informe a profundidade do acessório (até 20 caracteres)");
            this.txtProfundidade.UseSelectable = true;
            this.txtProfundidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProfundidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCor
            // 
            // 
            // 
            // 
            this.txtCor.CustomButton.Image = null;
            this.txtCor.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtCor.CustomButton.Name = "";
            this.txtCor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCor.CustomButton.TabIndex = 1;
            this.txtCor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCor.CustomButton.UseSelectable = true;
            this.txtCor.CustomButton.Visible = false;
            this.txtCor.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCor.Lines = new string[0];
            this.txtCor.Location = new System.Drawing.Point(15, 295);
            this.txtCor.MaxLength = 20;
            this.txtCor.Name = "txtCor";
            this.txtCor.PasswordChar = '\0';
            this.txtCor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCor.SelectedText = "";
            this.txtCor.SelectionLength = 0;
            this.txtCor.SelectionStart = 0;
            this.txtCor.Size = new System.Drawing.Size(157, 23);
            this.txtCor.Style = MetroFramework.MetroColorStyle.Red;
            this.txtCor.TabIndex = 17;
            this.txtCor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCor.UseSelectable = true;
            this.txtCor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pgbLoad
            // 
            this.pgbLoad.Location = new System.Drawing.Point(195, 415);
            this.pgbLoad.Name = "pgbLoad";
            this.pgbLoad.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.pgbLoad.Size = new System.Drawing.Size(160, 23);
            this.pgbLoad.Style = MetroFramework.MetroColorStyle.Red;
            this.pgbLoad.TabIndex = 26;
            this.pgbLoad.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblObrigatorio
            // 
            this.lblObrigatorio.AutoSize = true;
            this.lblObrigatorio.Location = new System.Drawing.Point(15, 470);
            this.lblObrigatorio.Name = "lblObrigatorio";
            this.lblObrigatorio.Size = new System.Drawing.Size(140, 19);
            this.lblObrigatorio.TabIndex = 27;
            this.lblObrigatorio.Text = "*Campos obrigatórios";
            // 
            // txtModelo
            // 
            // 
            // 
            // 
            this.txtModelo.CustomButton.Image = null;
            this.txtModelo.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtModelo.CustomButton.Name = "";
            this.txtModelo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModelo.CustomButton.TabIndex = 1;
            this.txtModelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModelo.CustomButton.UseSelectable = true;
            this.txtModelo.CustomButton.Visible = false;
            this.txtModelo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtModelo.Lines = new string[0];
            this.txtModelo.Location = new System.Drawing.Point(195, 163);
            this.txtModelo.MaxLength = 30;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PasswordChar = '\0';
            this.txtModelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModelo.SelectedText = "";
            this.txtModelo.SelectionLength = 0;
            this.txtModelo.SelectionStart = 0;
            this.txtModelo.Size = new System.Drawing.Size(160, 23);
            this.txtModelo.Style = MetroFramework.MetroColorStyle.Red;
            this.txtModelo.TabIndex = 11;
            this.txtModelo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtModelo, "Informe o nome do modelo do acessório (até 30 caracteres)");
            this.txtModelo.UseSelectable = true;
            this.txtModelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblModelo.Location = new System.Drawing.Point(195, 135);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(77, 25);
            this.lblModelo.Style = MetroFramework.MetroColorStyle.Red;
            this.lblModelo.TabIndex = 10;
            this.lblModelo.Text = "Modelo*";
            this.lblModelo.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblImagem.Location = new System.Drawing.Point(420, 15);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(81, 25);
            this.lblImagem.Style = MetroFramework.MetroColorStyle.Red;
            this.lblImagem.TabIndex = 0;
            this.lblImagem.Text = "Imagem*";
            this.lblImagem.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblInstrumento
            // 
            this.lblInstrumento.AutoSize = true;
            this.lblInstrumento.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblInstrumento.Location = new System.Drawing.Point(195, 195);
            this.lblInstrumento.Name = "lblInstrumento";
            this.lblInstrumento.Size = new System.Drawing.Size(110, 25);
            this.lblInstrumento.Style = MetroFramework.MetroColorStyle.Red;
            this.lblInstrumento.TabIndex = 14;
            this.lblInstrumento.Text = "Instrumento*";
            this.lblInstrumento.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTipo.Location = new System.Drawing.Point(15, 195);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(52, 25);
            this.lblTipo.Style = MetroFramework.MetroColorStyle.Red;
            this.lblTipo.TabIndex = 12;
            this.lblTipo.Text = "Tipo*";
            this.lblTipo.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ttpAjuda
            // 
            this.ttpAjuda.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttpAjuda.StyleManager = null;
            this.ttpAjuda.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmCadastroAcessorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.BackMaxSize = 100;
            this.ClientSize = new System.Drawing.Size(590, 650);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.gpbAcessorio);
            this.MaximizeBox = false;
            this.Name = "frmCadastroAcessorios";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Cadastro de Acessórios";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.MidnightBlue;
            this.Load += new System.EventHandler(this.frmCadastroAcessorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).EndInit();
            this.gpbAcessorio.ResumeLayout(false);
            this.gpbAcessorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroButton btnCadastrar;
        public MetroFramework.Controls.MetroButton btnRetornar;
        public MetroFramework.Controls.MetroButton btnLimpar;
        public MetroFramework.Controls.MetroLabel lblNome;
        public MetroFramework.Controls.MetroTextBox txtNome;
        public MetroFramework.Controls.MetroLabel lblDistribuidor;
        public MetroFramework.Controls.MetroTextBox txtDistribuidor;
        public MetroFramework.Controls.MetroLabel lblMarca;
        public MetroFramework.Controls.MetroLabel lblAltura;
        public MetroFramework.Controls.MetroLabel lblLargura;
        public MetroFramework.Controls.MetroTextBox txtMarca;
        public MetroFramework.Controls.MetroTextBox txtAltura;
        public MetroFramework.Controls.MetroTextBox txtLargura;
        public MetroFramework.Controls.MetroComboBox cmbTipo;
        public MetroFramework.Controls.MetroComboBox cmbInstrumento;
        public MetroFramework.Controls.MetroLabel lblQuantidade;
        public MetroFramework.Controls.MetroTextBox txtQuantidade;
        public MetroFramework.Controls.MetroLabel lblPreco;
        public MetroFramework.Controls.MetroTextBox txtPreco;
        public System.Windows.Forms.GroupBox gpbAcessorio;
        public MetroFramework.Controls.MetroLabel lblObrigatorio;
        public System.Windows.Forms.PictureBox ptbImagem;
        public MetroFramework.Controls.MetroTextBox txtModelo;
        public MetroFramework.Controls.MetroLabel lblPeso;
        public MetroFramework.Controls.MetroLabel lblModelo;
        public MetroFramework.Controls.MetroLabel lblProfundidade;
        public MetroFramework.Controls.MetroTextBox txtPeso;
        public MetroFramework.Controls.MetroTextBox txtProfundidade;
        private MetroFramework.Components.MetroToolTip ttpAjuda;
        private MetroFramework.Controls.MetroProgressBar pgbLoad;
        public MetroFramework.Controls.MetroLabel lblImagem;
        public MetroFramework.Controls.MetroLabel lblTipo;
        public MetroFramework.Controls.MetroLabel lblInstrumento;
        public MetroFramework.Controls.MetroTextBox txtCor;
        public MetroFramework.Controls.MetroButton btnCarregar;
        public MetroFramework.Controls.MetroButton btnResetar;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
    }
}