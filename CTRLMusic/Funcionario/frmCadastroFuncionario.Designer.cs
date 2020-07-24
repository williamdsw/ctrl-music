namespace CTRLMusic
{
    partial class frmCadastroFuncionario
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
            this.lblDataNascimento = new MetroFramework.Controls.MetroLabel();
            this.lblTurno = new MetroFramework.Controls.MetroLabel();
            this.lblCPF = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.lblResidencial = new MetroFramework.Controls.MetroLabel();
            this.cmbTurno = new MetroFramework.Controls.MetroComboBox();
            this.ptbImagem = new System.Windows.Forms.PictureBox();
            this.btnRetornar = new MetroFramework.Controls.MetroButton();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskResidencial = new System.Windows.Forms.MaskedTextBox();
            this.gpbFuncionario = new System.Windows.Forms.GroupBox();
            this.gpbDivisoria = new System.Windows.Forms.GroupBox();
            this.cmbUF = new MetroFramework.Controls.MetroComboBox();
            this.lblUF = new MetroFramework.Controls.MetroLabel();
            this.mskRG = new System.Windows.Forms.MaskedTextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblBairro = new MetroFramework.Controls.MetroLabel();
            this.lblRG = new MetroFramework.Controls.MetroLabel();
            this.lblEndereco = new MetroFramework.Controls.MetroLabel();
            this.lblCelular = new MetroFramework.Controls.MetroLabel();
            this.txtBairro = new MetroFramework.Controls.MetroTextBox();
            this.lblCidade = new MetroFramework.Controls.MetroLabel();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new MetroFramework.Controls.MetroTextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new MetroFramework.Controls.MetroLabel();
            this.txtEndereco = new MetroFramework.Controls.MetroTextBox();
            this.cmbGenero = new MetroFramework.Controls.MetroComboBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblGênero = new MetroFramework.Controls.MetroLabel();
            this.pgbLoad = new MetroFramework.Controls.MetroProgressBar();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.lblObrigatorio = new MetroFramework.Controls.MetroLabel();
            this.ttpAjuda = new MetroFramework.Components.MetroToolTip();
            this.cmbCargo = new MetroFramework.Controls.MetroComboBox();
            this.btnResetar = new MetroFramework.Controls.MetroButton();
            this.btnCarregar = new MetroFramework.Controls.MetroButton();
            this.lblCargo = new MetroFramework.Controls.MetroLabel();
            this.gpbImagem = new System.Windows.Forms.GroupBox();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).BeginInit();
            this.gpbFuncionario.SuspendLayout();
            this.gpbImagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDataNascimento.Location = new System.Drawing.Point(6, 177);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(173, 25);
            this.lblDataNascimento.TabIndex = 9;
            this.lblDataNascimento.Text = "Data de Nascimento*";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTurno.Location = new System.Drawing.Point(155, 234);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(62, 25);
            this.lblTurno.Style = MetroFramework.MetroColorStyle.Red;
            this.lblTurno.TabIndex = 13;
            this.lblTurno.Text = "Turno*";
            this.lblTurno.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCPF.Location = new System.Drawing.Point(95, 69);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(48, 25);
            this.lblCPF.Style = MetroFramework.MetroColorStyle.Red;
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "CPF*";
            this.lblCPF.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(6, 43);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(200, 23);
            this.txtNome.Style = MetroFramework.MetroColorStyle.Red;
            this.txtNome.TabIndex = 2;
            this.txtNome.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtNome, "Informe o nome completo ");
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(5, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 25);
            this.lblNome.Style = MetroFramework.MetroColorStyle.Red;
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome*";
            this.lblNome.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblResidencial
            // 
            this.lblResidencial.AutoSize = true;
            this.lblResidencial.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblResidencial.Location = new System.Drawing.Point(242, 123);
            this.lblResidencial.Name = "lblResidencial";
            this.lblResidencial.Size = new System.Drawing.Size(131, 25);
            this.lblResidencial.Style = MetroFramework.MetroColorStyle.Red;
            this.lblResidencial.TabIndex = 19;
            this.lblResidencial.Text = "Tel. Residencial*";
            this.lblResidencial.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cmbTurno
            // 
            this.cmbTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.ItemHeight = 23;
            this.cmbTurno.Items.AddRange(new object[] {
            "M",
            "T",
            "N"});
            this.cmbTurno.Location = new System.Drawing.Point(155, 262);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(50, 29);
            this.cmbTurno.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbTurno.TabIndex = 14;
            this.cmbTurno.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.cmbTurno, "Escolha o turno de trabalho");
            this.cmbTurno.UseSelectable = true;
            // 
            // ptbImagem
            // 
            this.ptbImagem.BackgroundImage = global::CTRLMusic.Properties.Resources._7_PNG_worker;
            this.ptbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbImagem.Location = new System.Drawing.Point(6, 25);
            this.ptbImagem.Name = "ptbImagem";
            this.ptbImagem.Size = new System.Drawing.Size(122, 118);
            this.ptbImagem.TabIndex = 35;
            this.ptbImagem.TabStop = false;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetornar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRetornar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRetornar.Location = new System.Drawing.Point(23, 415);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(100, 30);
            this.btnRetornar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnRetornar.TabIndex = 35;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.btnRetornar, "Retornar à tela anterior");
            this.btnRetornar.UseSelectable = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCadastrar.Highlight = true;
            this.btnCadastrar.Location = new System.Drawing.Point(517, 415);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 30);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCadastrar.TabIndex = 37;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.btnCadastrar, "Cadastrar funcionário");
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskCPF.Location = new System.Drawing.Point(96, 97);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskCPF.Size = new System.Drawing.Size(110, 23);
            this.mskCPF.TabIndex = 6;
            this.mskCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpAjuda.SetToolTip(this.mskCPF, "Informe o CPF");
            // 
            // mskResidencial
            // 
            this.mskResidencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskResidencial.Location = new System.Drawing.Point(242, 151);
            this.mskResidencial.Mask = "(99) 9999-9999";
            this.mskResidencial.Name = "mskResidencial";
            this.mskResidencial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskResidencial.Size = new System.Drawing.Size(110, 23);
            this.mskResidencial.TabIndex = 20;
            this.mskResidencial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpAjuda.SetToolTip(this.mskResidencial, "Informe o telefone residencial (fixo)");
            // 
            // gpbFuncionario
            // 
            this.gpbFuncionario.Controls.Add(this.gpbDivisoria);
            this.gpbFuncionario.Controls.Add(this.cmbUF);
            this.gpbFuncionario.Controls.Add(this.lblUF);
            this.gpbFuncionario.Controls.Add(this.mskRG);
            this.gpbFuncionario.Controls.Add(this.mskCEP);
            this.gpbFuncionario.Controls.Add(this.lblBairro);
            this.gpbFuncionario.Controls.Add(this.lblResidencial);
            this.gpbFuncionario.Controls.Add(this.lblRG);
            this.gpbFuncionario.Controls.Add(this.mskResidencial);
            this.gpbFuncionario.Controls.Add(this.lblEndereco);
            this.gpbFuncionario.Controls.Add(this.lblCelular);
            this.gpbFuncionario.Controls.Add(this.txtBairro);
            this.gpbFuncionario.Controls.Add(this.lblCidade);
            this.gpbFuncionario.Controls.Add(this.mskDataNascimento);
            this.gpbFuncionario.Controls.Add(this.txtCidade);
            this.gpbFuncionario.Controls.Add(this.mskCPF);
            this.gpbFuncionario.Controls.Add(this.mskCelular);
            this.gpbFuncionario.Controls.Add(this.cmbTurno);
            this.gpbFuncionario.Controls.Add(this.lblCEP);
            this.gpbFuncionario.Controls.Add(this.txtEndereco);
            this.gpbFuncionario.Controls.Add(this.lblTurno);
            this.gpbFuncionario.Controls.Add(this.cmbGenero);
            this.gpbFuncionario.Controls.Add(this.lblEmail);
            this.gpbFuncionario.Controls.Add(this.txtEmail);
            this.gpbFuncionario.Controls.Add(this.lblNome);
            this.gpbFuncionario.Controls.Add(this.txtNome);
            this.gpbFuncionario.Controls.Add(this.lblCPF);
            this.gpbFuncionario.Controls.Add(this.lblGênero);
            this.gpbFuncionario.Controls.Add(this.lblDataNascimento);
            this.gpbFuncionario.Location = new System.Drawing.Point(23, 63);
            this.gpbFuncionario.Name = "gpbFuncionario";
            this.gpbFuncionario.Size = new System.Drawing.Size(448, 310);
            this.gpbFuncionario.TabIndex = 0;
            this.gpbFuncionario.TabStop = false;
            // 
            // gpbDivisoria
            // 
            this.gpbDivisoria.Location = new System.Drawing.Point(223, 0);
            this.gpbDivisoria.Name = "gpbDivisoria";
            this.gpbDivisoria.Size = new System.Drawing.Size(2, 310);
            this.gpbDivisoria.TabIndex = 0;
            this.gpbDivisoria.TabStop = false;
            // 
            // cmbUF
            // 
            this.cmbUF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUF.FormattingEnabled = true;
            this.cmbUF.ItemHeight = 23;
            this.cmbUF.Location = new System.Drawing.Point(392, 262);
            this.cmbUF.Name = "cmbUF";
            this.cmbUF.Size = new System.Drawing.Size(50, 29);
            this.cmbUF.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbUF.TabIndex = 28;
            this.cmbUF.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.cmbUF, "Escolha a sigla do estado");
            this.cmbUF.UseSelectable = true;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUF.Location = new System.Drawing.Point(403, 234);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(39, 25);
            this.lblUF.Style = MetroFramework.MetroColorStyle.Red;
            this.lblUF.TabIndex = 27;
            this.lblUF.Text = "UF*";
            this.lblUF.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mskRG
            // 
            this.mskRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskRG.Location = new System.Drawing.Point(5, 97);
            this.mskRG.Mask = "99.999.999-9";
            this.mskRG.Name = "mskRG";
            this.mskRG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskRG.Size = new System.Drawing.Size(89, 23);
            this.mskRG.TabIndex = 4;
            this.ttpAjuda.SetToolTip(this.mskRG, "Informe o núrmero do RG");
            // 
            // mskCEP
            // 
            this.mskCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskCEP.Location = new System.Drawing.Point(367, 151);
            this.mskCEP.Mask = "99999-999";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskCEP.Size = new System.Drawing.Size(75, 23);
            this.mskCEP.TabIndex = 22;
            this.mskCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpAjuda.SetToolTip(this.mskCEP, "Informe o CEP");
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBairro.Location = new System.Drawing.Point(242, 69);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(64, 25);
            this.lblBairro.Style = MetroFramework.MetroColorStyle.Red;
            this.lblBairro.TabIndex = 17;
            this.lblBairro.Text = "Bairro*";
            this.lblBairro.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRG.Location = new System.Drawing.Point(6, 69);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(41, 25);
            this.lblRG.Style = MetroFramework.MetroColorStyle.Red;
            this.lblRG.TabIndex = 3;
            this.lblRG.Text = "RG*";
            this.lblRG.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEndereco.Location = new System.Drawing.Point(242, 15);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(90, 25);
            this.lblEndereco.Style = MetroFramework.MetroColorStyle.Red;
            this.lblEndereco.TabIndex = 15;
            this.lblEndereco.Text = "Endereço*";
            this.lblEndereco.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCelular.Location = new System.Drawing.Point(242, 177);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(72, 25);
            this.lblCelular.Style = MetroFramework.MetroColorStyle.Red;
            this.lblCelular.TabIndex = 23;
            this.lblCelular.Text = "Celular*";
            this.lblCelular.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtBairro
            // 
            // 
            // 
            // 
            this.txtBairro.CustomButton.Image = null;
            this.txtBairro.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtBairro.CustomButton.Name = "";
            this.txtBairro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBairro.CustomButton.TabIndex = 1;
            this.txtBairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBairro.CustomButton.UseSelectable = true;
            this.txtBairro.CustomButton.Visible = false;
            this.txtBairro.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBairro.Lines = new string[0];
            this.txtBairro.Location = new System.Drawing.Point(242, 97);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.Size = new System.Drawing.Size(200, 23);
            this.txtBairro.Style = MetroFramework.MetroColorStyle.Red;
            this.txtBairro.TabIndex = 18;
            this.txtBairro.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtBairro, "Informe o bairro");
            this.txtBairro.UseSelectable = true;
            this.txtBairro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBairro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCidade.Location = new System.Drawing.Point(242, 234);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(72, 25);
            this.lblCidade.Style = MetroFramework.MetroColorStyle.Red;
            this.lblCidade.TabIndex = 25;
            this.lblCidade.Text = "Cidade*";
            this.lblCidade.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskDataNascimento.Location = new System.Drawing.Point(4, 205);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskDataNascimento.Size = new System.Drawing.Size(120, 23);
            this.mskDataNascimento.TabIndex = 10;
            this.mskDataNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpAjuda.SetToolTip(this.mskDataNascimento, "Informe a data de nascimento do funcionário");
            this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtCidade
            // 
            // 
            // 
            // 
            this.txtCidade.CustomButton.Image = null;
            this.txtCidade.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtCidade.CustomButton.Name = "";
            this.txtCidade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCidade.CustomButton.TabIndex = 1;
            this.txtCidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCidade.CustomButton.UseSelectable = true;
            this.txtCidade.CustomButton.Visible = false;
            this.txtCidade.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCidade.Lines = new string[0];
            this.txtCidade.Location = new System.Drawing.Point(242, 262);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.Size = new System.Drawing.Size(119, 23);
            this.txtCidade.Style = MetroFramework.MetroColorStyle.Red;
            this.txtCidade.TabIndex = 26;
            this.txtCidade.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtCidade, "Informe a cidade");
            this.txtCidade.UseSelectable = true;
            this.txtCidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mskCelular
            // 
            this.mskCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskCelular.Location = new System.Drawing.Point(242, 205);
            this.mskCelular.Mask = "(99) 99999-9999";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskCelular.Size = new System.Drawing.Size(110, 23);
            this.mskCelular.TabIndex = 24;
            this.mskCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpAjuda.SetToolTip(this.mskCelular, "Informe o telefone celular");
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCEP.Location = new System.Drawing.Point(393, 123);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(49, 25);
            this.lblCEP.TabIndex = 21;
            this.lblCEP.Text = "CEP*";
            // 
            // txtEndereco
            // 
            // 
            // 
            // 
            this.txtEndereco.CustomButton.Image = null;
            this.txtEndereco.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtEndereco.CustomButton.Name = "";
            this.txtEndereco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEndereco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEndereco.CustomButton.TabIndex = 1;
            this.txtEndereco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEndereco.CustomButton.UseSelectable = true;
            this.txtEndereco.CustomButton.Visible = false;
            this.txtEndereco.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEndereco.Lines = new string[0];
            this.txtEndereco.Location = new System.Drawing.Point(242, 43);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.SelectionLength = 0;
            this.txtEndereco.SelectionStart = 0;
            this.txtEndereco.Size = new System.Drawing.Size(200, 23);
            this.txtEndereco.Style = MetroFramework.MetroColorStyle.Red;
            this.txtEndereco.TabIndex = 16;
            this.txtEndereco.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtEndereco, "Informe o endereço ");
            this.txtEndereco.UseSelectable = true;
            this.txtEndereco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEndereco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbGenero
            // 
            this.cmbGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.ItemHeight = 23;
            this.cmbGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cmbGenero.Location = new System.Drawing.Point(6, 262);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(111, 29);
            this.cmbGenero.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbGenero.TabIndex = 12;
            this.cmbGenero.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.cmbGenero, "Informe o gênero do/a funcionário/a");
            this.cmbGenero.UseSelectable = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmail.Location = new System.Drawing.Point(4, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 25);
            this.lblEmail.Style = MetroFramework.MetroColorStyle.Red;
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail*";
            this.lblEmail.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(5, 151);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            this.txtEmail.Style = MetroFramework.MetroColorStyle.Red;
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtEmail, "Informe o e-mail ");
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblGênero
            // 
            this.lblGênero.AutoSize = true;
            this.lblGênero.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGênero.Location = new System.Drawing.Point(4, 234);
            this.lblGênero.Name = "lblGênero";
            this.lblGênero.Size = new System.Drawing.Size(75, 25);
            this.lblGênero.Style = MetroFramework.MetroColorStyle.Red;
            this.lblGênero.TabIndex = 11;
            this.lblGênero.Text = "Gênero*";
            this.lblGênero.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pgbLoad
            // 
            this.pgbLoad.Location = new System.Drawing.Point(274, 379);
            this.pgbLoad.Name = "pgbLoad";
            this.pgbLoad.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.pgbLoad.Size = new System.Drawing.Size(100, 23);
            this.pgbLoad.Style = MetroFramework.MetroColorStyle.Red;
            this.pgbLoad.TabIndex = 34;
            this.pgbLoad.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.pgbLoad, "Cadastrando...");
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLimpar.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnLimpar.Location = new System.Drawing.Point(274, 415);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnLimpar.TabIndex = 36;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.btnLimpar, "Limpar os dados");
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblObrigatorio
            // 
            this.lblObrigatorio.AutoSize = true;
            this.lblObrigatorio.Location = new System.Drawing.Point(23, 376);
            this.lblObrigatorio.Name = "lblObrigatorio";
            this.lblObrigatorio.Size = new System.Drawing.Size(140, 19);
            this.lblObrigatorio.Style = MetroFramework.MetroColorStyle.Red;
            this.lblObrigatorio.TabIndex = 33;
            this.lblObrigatorio.Text = "*Campos obrigatórios";
            this.lblObrigatorio.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ttpAjuda
            // 
            this.ttpAjuda.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttpAjuda.StyleManager = null;
            this.ttpAjuda.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cmbCargo
            // 
            this.cmbCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.ItemHeight = 23;
            this.cmbCargo.Items.AddRange(new object[] {
            "Vendedor",
            "Gerente"});
            this.cmbCargo.Location = new System.Drawing.Point(477, 344);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(140, 29);
            this.cmbCargo.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbCargo.TabIndex = 32;
            this.cmbCargo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.cmbCargo, "Informe o cargo do funcionário");
            this.cmbCargo.UseSelectable = true;
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
            this.btnResetar.Location = new System.Drawing.Point(17, 195);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(100, 30);
            this.btnResetar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnResetar.TabIndex = 30;
            this.btnResetar.Text = "Resetar";
            this.btnResetar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.btnResetar, "Clique para excluir a imagem selecionada");
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
            this.btnCarregar.Location = new System.Drawing.Point(17, 149);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(100, 30);
            this.btnCarregar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCarregar.TabIndex = 29;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.btnCarregar, "Clique para carregar uma imagem");
            this.btnCarregar.UseSelectable = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCargo.Location = new System.Drawing.Point(477, 316);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(65, 25);
            this.lblCargo.Style = MetroFramework.MetroColorStyle.Red;
            this.lblCargo.TabIndex = 31;
            this.lblCargo.Text = "Cargo*";
            this.lblCargo.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // gpbImagem
            // 
            this.gpbImagem.Controls.Add(this.btnResetar);
            this.gpbImagem.Controls.Add(this.btnCarregar);
            this.gpbImagem.Controls.Add(this.ptbImagem);
            this.gpbImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbImagem.Location = new System.Drawing.Point(477, 60);
            this.gpbImagem.Name = "gpbImagem";
            this.gpbImagem.Size = new System.Drawing.Size(140, 238);
            this.gpbImagem.TabIndex = 0;
            this.gpbImagem.TabStop = false;
            this.gpbImagem.Text = "Imagem*";
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 475);
            this.Controls.Add(this.gpbImagem);
            this.Controls.Add(this.pgbLoad);
            this.Controls.Add(this.lblObrigatorio);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.gpbFuncionario);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.btnRetornar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroFuncionario";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Cadastro do Funcionário";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmCadastroFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).EndInit();
            this.gpbFuncionario.ResumeLayout(false);
            this.gpbFuncionario.PerformLayout();
            this.gpbImagem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblDataNascimento;
        private MetroFramework.Controls.MetroLabel lblTurno;
        private MetroFramework.Controls.MetroLabel lblCPF;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroLabel lblResidencial;
        private System.Windows.Forms.GroupBox gpbFuncionario;
        private MetroFramework.Components.MetroToolTip ttpAjuda;
        private MetroFramework.Controls.MetroLabel lblCelular;
        private MetroFramework.Controls.MetroLabel lblRG;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblGênero;
        private MetroFramework.Controls.MetroProgressBar pgbLoad;
        public MetroFramework.Controls.MetroTextBox txtNome;
        public MetroFramework.Controls.MetroComboBox cmbTurno;
        public MetroFramework.Controls.MetroButton btnRetornar;
        public MetroFramework.Controls.MetroButton btnCadastrar;
        public System.Windows.Forms.MaskedTextBox mskCPF;
        public System.Windows.Forms.MaskedTextBox mskResidencial;
        public System.Windows.Forms.MaskedTextBox mskCelular;
        public System.Windows.Forms.MaskedTextBox mskRG;
        public MetroFramework.Controls.MetroTextBox txtEmail;
        public MetroFramework.Controls.MetroComboBox cmbGenero;
        public MetroFramework.Controls.MetroButton btnLimpar;
        public MetroFramework.Controls.MetroLabel lblObrigatorio;
        public System.Windows.Forms.MaskedTextBox mskDataNascimento;
        public MetroFramework.Controls.MetroComboBox cmbCargo;
        private MetroFramework.Controls.MetroLabel lblCidade;
        public MetroFramework.Controls.MetroTextBox txtCidade;
        private MetroFramework.Controls.MetroLabel lblEndereco;
        public MetroFramework.Controls.MetroTextBox txtEndereco;
        private MetroFramework.Controls.MetroLabel lblCargo;
        private MetroFramework.Controls.MetroLabel lblBairro;
        public MetroFramework.Controls.MetroTextBox txtBairro;
        public MetroFramework.Controls.MetroComboBox cmbUF;
        private MetroFramework.Controls.MetroLabel lblUF;
        public System.Windows.Forms.MaskedTextBox mskCEP;
        private MetroFramework.Controls.MetroLabel lblCEP;
        private System.Windows.Forms.GroupBox gpbImagem;
        public MetroFramework.Controls.MetroButton btnResetar;
        public MetroFramework.Controls.MetroButton btnCarregar;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
        private System.Windows.Forms.GroupBox gpbDivisoria;
        public System.Windows.Forms.PictureBox ptbImagem;

    }
}