namespace CTRLMusic
{
    partial class frmVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbLista = new System.Windows.Forms.GroupBox();
            this.lblQuantidade = new MetroFramework.Controls.MetroLabel();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.dgvDados = new MetroFramework.Controls.MetroGrid();
            this.gpbVenda = new System.Windows.Forms.GroupBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.btnCalcular = new MetroFramework.Controls.MetroButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQtdVenda = new MetroFramework.Controls.MetroLabel();
            this.txtPago = new MetroFramework.Controls.MetroTextBox();
            this.txtQtdVenda = new MetroFramework.Controls.MetroTextBox();
            this.txtDesconto = new MetroFramework.Controls.MetroTextBox();
            this.lblPago = new MetroFramework.Controls.MetroLabel();
            this.lblDesconto = new MetroFramework.Controls.MetroLabel();
            this.lblUnitario = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnEfetuar = new MetroFramework.Controls.MetroButton();
            this.ttpAjuda = new MetroFramework.Components.MetroToolTip();
            this.pgbLoad = new MetroFramework.Controls.MetroProgressBar();
            this.gpbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.gpbVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbLista
            // 
            this.gpbLista.Controls.Add(this.lblQuantidade);
            this.gpbLista.Controls.Add(this.lblCodigo);
            this.gpbLista.Controls.Add(this.lblNome);
            this.gpbLista.Controls.Add(this.dgvDados);
            this.gpbLista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbLista.Location = new System.Drawing.Point(23, 53);
            this.gpbLista.Name = "gpbLista";
            this.gpbLista.Size = new System.Drawing.Size(405, 305);
            this.gpbLista.TabIndex = 0;
            this.gpbLista.TabStop = false;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblQuantidade.Location = new System.Drawing.Point(230, 265);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(111, 25);
            this.lblQuantidade.Style = MetroFramework.MetroColorStyle.Red;
            this.lblQuantidade.TabIndex = 20;
            this.lblQuantidade.Text = "Quantidade :";
            this.lblQuantidade.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCodigo.Location = new System.Drawing.Point(6, 265);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 25);
            this.lblCodigo.Style = MetroFramework.MetroColorStyle.Red;
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Código :";
            this.lblCodigo.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(6, 235);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 25);
            this.lblNome.Style = MetroFramework.MetroColorStyle.Red;
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome :";
            this.lblNome.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDados.Location = new System.Drawing.Point(6, 28);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDados.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(393, 185);
            this.dgvDados.Style = MetroFramework.MetroColorStyle.Red;
            this.dgvDados.TabIndex = 3;
            this.dgvDados.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            this.dgvDados.CurrentCellChanged += new System.EventHandler(this.dgvDados_CurrentCellChanged);
            // 
            // gpbVenda
            // 
            this.gpbVenda.Controls.Add(this.lblTroco);
            this.gpbVenda.Controls.Add(this.btnCalcular);
            this.gpbVenda.Controls.Add(this.lblTotal);
            this.gpbVenda.Controls.Add(this.lblQtdVenda);
            this.gpbVenda.Controls.Add(this.txtPago);
            this.gpbVenda.Controls.Add(this.txtQtdVenda);
            this.gpbVenda.Controls.Add(this.txtDesconto);
            this.gpbVenda.Controls.Add(this.lblPago);
            this.gpbVenda.Controls.Add(this.lblDesconto);
            this.gpbVenda.Controls.Add(this.lblUnitario);
            this.gpbVenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbVenda.Location = new System.Drawing.Point(29, 364);
            this.gpbVenda.Name = "gpbVenda";
            this.gpbVenda.Size = new System.Drawing.Size(393, 228);
            this.gpbVenda.TabIndex = 1;
            this.gpbVenda.TabStop = false;
            this.gpbVenda.Text = "Detalhes da Venda";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblTroco.Location = new System.Drawing.Point(6, 125);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(84, 30);
            this.lblTroco.TabIndex = 29;
            this.lblTroco.Text = "Troco : ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCalcular.Highlight = true;
            this.btnCalcular.Location = new System.Drawing.Point(263, 170);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(91, 32);
            this.btnCalcular.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCalcular.TabIndex = 28;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCalcular.UseSelectable = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblTotal.Location = new System.Drawing.Point(6, 157);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(113, 45);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total : ";
            // 
            // lblQtdVenda
            // 
            this.lblQtdVenda.AutoSize = true;
            this.lblQtdVenda.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblQtdVenda.Location = new System.Drawing.Point(241, 25);
            this.lblQtdVenda.Name = "lblQtdVenda";
            this.lblQtdVenda.Size = new System.Drawing.Size(50, 25);
            this.lblQtdVenda.Style = MetroFramework.MetroColorStyle.Red;
            this.lblQtdVenda.TabIndex = 20;
            this.lblQtdVenda.Text = "Qtde";
            this.lblQtdVenda.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtPago
            // 
            // 
            // 
            // 
            this.txtPago.CustomButton.Image = null;
            this.txtPago.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtPago.CustomButton.Name = "";
            this.txtPago.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPago.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPago.CustomButton.TabIndex = 1;
            this.txtPago.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPago.CustomButton.UseSelectable = true;
            this.txtPago.CustomButton.Visible = false;
            this.txtPago.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPago.Lines = new string[0];
            this.txtPago.Location = new System.Drawing.Point(95, 87);
            this.txtPago.MaxLength = 32767;
            this.txtPago.Name = "txtPago";
            this.txtPago.PasswordChar = '\0';
            this.txtPago.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPago.SelectedText = "";
            this.txtPago.SelectionLength = 0;
            this.txtPago.SelectionStart = 0;
            this.txtPago.Size = new System.Drawing.Size(100, 23);
            this.txtPago.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPago.TabIndex = 17;
            this.txtPago.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtPago, "Informe o valor pago pelo cliente");
            this.txtPago.UseSelectable = true;
            this.txtPago.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPago.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPago.Leave += new System.EventHandler(this.txtPago_Leave);
            // 
            // txtQtdVenda
            // 
            // 
            // 
            // 
            this.txtQtdVenda.CustomButton.Image = null;
            this.txtQtdVenda.CustomButton.Location = new System.Drawing.Point(28, 1);
            this.txtQtdVenda.CustomButton.Name = "";
            this.txtQtdVenda.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQtdVenda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQtdVenda.CustomButton.TabIndex = 1;
            this.txtQtdVenda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQtdVenda.CustomButton.UseSelectable = true;
            this.txtQtdVenda.CustomButton.Visible = false;
            this.txtQtdVenda.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtQtdVenda.Lines = new string[0];
            this.txtQtdVenda.Location = new System.Drawing.Point(297, 27);
            this.txtQtdVenda.MaxLength = 32767;
            this.txtQtdVenda.Name = "txtQtdVenda";
            this.txtQtdVenda.PasswordChar = '\0';
            this.txtQtdVenda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQtdVenda.SelectedText = "";
            this.txtQtdVenda.SelectionLength = 0;
            this.txtQtdVenda.SelectionStart = 0;
            this.txtQtdVenda.Size = new System.Drawing.Size(50, 23);
            this.txtQtdVenda.Style = MetroFramework.MetroColorStyle.Red;
            this.txtQtdVenda.TabIndex = 17;
            this.txtQtdVenda.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtQtdVenda, "Informe a quantidade que será vendida");
            this.txtQtdVenda.UseSelectable = true;
            this.txtQtdVenda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQtdVenda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQtdVenda.Leave += new System.EventHandler(this.txtQtdVenda_Leave);
            // 
            // txtDesconto
            // 
            // 
            // 
            // 
            this.txtDesconto.CustomButton.Image = null;
            this.txtDesconto.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtDesconto.CustomButton.Name = "";
            this.txtDesconto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDesconto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesconto.CustomButton.TabIndex = 1;
            this.txtDesconto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesconto.CustomButton.UseSelectable = true;
            this.txtDesconto.CustomButton.Visible = false;
            this.txtDesconto.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDesconto.Lines = new string[0];
            this.txtDesconto.Location = new System.Drawing.Point(95, 57);
            this.txtDesconto.MaxLength = 32767;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.PasswordChar = '\0';
            this.txtDesconto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesconto.SelectedText = "";
            this.txtDesconto.SelectionLength = 0;
            this.txtDesconto.SelectionStart = 0;
            this.txtDesconto.Size = new System.Drawing.Size(100, 23);
            this.txtDesconto.Style = MetroFramework.MetroColorStyle.Red;
            this.txtDesconto.TabIndex = 17;
            this.txtDesconto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtDesconto, "Informe o desconto que será dado no produto(s)");
            this.txtDesconto.UseSelectable = true;
            this.txtDesconto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesconto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPago.Location = new System.Drawing.Point(6, 85);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(50, 25);
            this.lblPago.Style = MetroFramework.MetroColorStyle.Red;
            this.lblPago.TabIndex = 15;
            this.lblPago.Text = "Pago";
            this.lblPago.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDesconto.Location = new System.Drawing.Point(6, 55);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(83, 25);
            this.lblDesconto.Style = MetroFramework.MetroColorStyle.Red;
            this.lblDesconto.TabIndex = 15;
            this.lblDesconto.Text = "Desconto";
            this.lblDesconto.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblUnitario
            // 
            this.lblUnitario.AutoSize = true;
            this.lblUnitario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUnitario.Location = new System.Drawing.Point(6, 25);
            this.lblUnitario.Name = "lblUnitario";
            this.lblUnitario.Size = new System.Drawing.Size(129, 25);
            this.lblUnitario.Style = MetroFramework.MetroColorStyle.Red;
            this.lblUnitario.TabIndex = 15;
            this.lblUnitario.Text = "Valor Unitário : ";
            this.lblUnitario.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnCancelar.Location = new System.Drawing.Point(29, 598);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 32);
            this.btnCancelar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEfetuar
            // 
            this.btnEfetuar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEfetuar.Location = new System.Drawing.Point(331, 598);
            this.btnEfetuar.Name = "btnEfetuar";
            this.btnEfetuar.Size = new System.Drawing.Size(91, 32);
            this.btnEfetuar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnEfetuar.TabIndex = 28;
            this.btnEfetuar.Text = "Efetuar ";
            this.btnEfetuar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEfetuar.UseSelectable = true;
            this.btnEfetuar.Click += new System.EventHandler(this.btnEfetuar_Click);
            // 
            // ttpAjuda
            // 
            this.ttpAjuda.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttpAjuda.StyleManager = null;
            this.ttpAjuda.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pgbLoad
            // 
            this.pgbLoad.Location = new System.Drawing.Point(174, 607);
            this.pgbLoad.Name = "pgbLoad";
            this.pgbLoad.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.pgbLoad.Size = new System.Drawing.Size(100, 23);
            this.pgbLoad.Style = MetroFramework.MetroColorStyle.Red;
            this.pgbLoad.TabIndex = 44;
            this.pgbLoad.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 650);
            this.Controls.Add(this.pgbLoad);
            this.Controls.Add(this.btnEfetuar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbVenda);
            this.Controls.Add(this.gpbLista);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVenda";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Venda";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.gpbLista.ResumeLayout(false);
            this.gpbLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.gpbVenda.ResumeLayout(false);
            this.gpbVenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbLista;
        private MetroFramework.Controls.MetroGrid dgvDados;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroLabel lblQuantidade;
        private System.Windows.Forms.GroupBox gpbVenda;
        private MetroFramework.Controls.MetroLabel lblDesconto;
        private MetroFramework.Controls.MetroLabel lblUnitario;
        private MetroFramework.Controls.MetroTextBox txtDesconto;
        private MetroFramework.Controls.MetroLabel lblQtdVenda;
        private MetroFramework.Controls.MetroTextBox txtQtdVenda;
        private MetroFramework.Controls.MetroLabel lblPago;
        private MetroFramework.Controls.MetroTextBox txtPago;
        private System.Windows.Forms.Label lblTotal;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnEfetuar;
        private MetroFramework.Controls.MetroButton btnCalcular;
        private System.Windows.Forms.Label lblTroco;
        private MetroFramework.Components.MetroToolTip ttpAjuda;
        private MetroFramework.Controls.MetroProgressBar pgbLoad;
    }
}