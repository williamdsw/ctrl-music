namespace CTRLMusic
{
    partial class frmConsultas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpData = new MetroFramework.Controls.MetroDateTime();
            this.dgvDados = new MetroFramework.Controls.MetroGrid();
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.ttpAjuda = new MetroFramework.Components.MetroToolTip();
            this.txtPesquisar = new MetroFramework.Controls.MetroTextBox();
            this.btnDeletar = new MetroFramework.Controls.MetroButton();
            this.pgbLoad = new MetroFramework.Controls.MetroProgressBar();
            this.lblPalavraChave = new MetroFramework.Controls.MetroLabel();
            this.cmbParametro = new MetroFramework.Controls.MetroComboBox();
            this.gpbConsulta = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.gpbConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpData.CustomFormat = "";
            this.dtpData.Enabled = false;
            this.dtpData.Location = new System.Drawing.Point(564, 305);
            this.dtpData.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(232, 29);
            this.dtpData.Style = MetroFramework.MetroColorStyle.Red;
            this.dtpData.TabIndex = 7;
            this.dtpData.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.dtpData, "Data de hoje");
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDados.Location = new System.Drawing.Point(6, 19);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDados.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(790, 280);
            this.dgvDados.Style = MetroFramework.MetroColorStyle.Red;
            this.dgvDados.TabIndex = 2;
            this.dgvDados.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.dgvDados, "Todos os dados registrados");
            this.dgvDados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentDoubleClick);
            // 
            // btnNovo
            // 
            this.btnNovo.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNovo.Highlight = true;
            this.btnNovo.Location = new System.Drawing.Point(23, 451);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(155, 45);
            this.btnNovo.Style = MetroFramework.MetroColorStyle.Red;
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnNovo.UseSelectable = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEditar.Highlight = true;
            this.btnEditar.Location = new System.Drawing.Point(357, 451);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(155, 45);
            this.btnEditar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar ";
            this.btnEditar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // ttpAjuda
            // 
            this.ttpAjuda.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttpAjuda.StyleManager = null;
            this.ttpAjuda.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtPesquisar
            // 
            // 
            // 
            // 
            this.txtPesquisar.CustomButton.Image = null;
            this.txtPesquisar.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtPesquisar.CustomButton.Name = "";
            this.txtPesquisar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPesquisar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisar.CustomButton.TabIndex = 1;
            this.txtPesquisar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisar.CustomButton.UseSelectable = true;
            this.txtPesquisar.CustomButton.Visible = false;
            this.txtPesquisar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPesquisar.Lines = new string[] {
        "Pesquisar"};
            this.txtPesquisar.Location = new System.Drawing.Point(273, 311);
            this.txtPesquisar.MaxLength = 30;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PasswordChar = '\0';
            this.txtPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisar.SelectedText = "";
            this.txtPesquisar.SelectionLength = 0;
            this.txtPesquisar.SelectionStart = 0;
            this.txtPesquisar.Size = new System.Drawing.Size(160, 23);
            this.txtPesquisar.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPesquisar.TabIndex = 5;
            this.txtPesquisar.Text = "Pesquisar";
            this.txtPesquisar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpAjuda.SetToolTip(this.txtPesquisar, "Informe o nome do modelo do acessório (até 30 caracteres)");
            this.txtPesquisar.UseSelectable = true;
            this.txtPesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter);
            this.txtPesquisar.Leave += new System.EventHandler(this.txtPesquisar_Leave);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Silver;
            this.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeletar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDeletar.Highlight = true;
            this.btnDeletar.Location = new System.Drawing.Point(662, 451);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(155, 45);
            this.btnDeletar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDeletar.TabIndex = 10;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDeletar.UseSelectable = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // pgbLoad
            // 
            this.pgbLoad.Location = new System.Drawing.Point(458, 311);
            this.pgbLoad.Name = "pgbLoad";
            this.pgbLoad.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.pgbLoad.Size = new System.Drawing.Size(100, 23);
            this.pgbLoad.Step = 1;
            this.pgbLoad.Style = MetroFramework.MetroColorStyle.Red;
            this.pgbLoad.TabIndex = 6;
            this.pgbLoad.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblPalavraChave
            // 
            this.lblPalavraChave.AutoSize = true;
            this.lblPalavraChave.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPalavraChave.Location = new System.Drawing.Point(133, 309);
            this.lblPalavraChave.Name = "lblPalavraChave";
            this.lblPalavraChave.Size = new System.Drawing.Size(134, 25);
            this.lblPalavraChave.Style = MetroFramework.MetroColorStyle.Red;
            this.lblPalavraChave.TabIndex = 4;
            this.lblPalavraChave.Text = "Palavra(s)-chave";
            this.lblPalavraChave.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cmbParametro
            // 
            this.cmbParametro.FormattingEnabled = true;
            this.cmbParametro.ItemHeight = 23;
            this.cmbParametro.Location = new System.Drawing.Point(6, 305);
            this.cmbParametro.Name = "cmbParametro";
            this.cmbParametro.Size = new System.Drawing.Size(121, 29);
            this.cmbParametro.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbParametro.TabIndex = 3;
            this.cmbParametro.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmbParametro.UseSelectable = true;
            this.cmbParametro.SelectedIndexChanged += new System.EventHandler(this.cmbParametro_SelectedIndexChanged);
            // 
            // gpbConsulta
            // 
            this.gpbConsulta.Controls.Add(this.pgbLoad);
            this.gpbConsulta.Controls.Add(this.cmbParametro);
            this.gpbConsulta.Controls.Add(this.txtPesquisar);
            this.gpbConsulta.Controls.Add(this.dgvDados);
            this.gpbConsulta.Controls.Add(this.lblPalavraChave);
            this.gpbConsulta.Controls.Add(this.dtpData);
            this.gpbConsulta.Location = new System.Drawing.Point(23, 63);
            this.gpbConsulta.Name = "gpbConsulta";
            this.gpbConsulta.Size = new System.Drawing.Size(805, 350);
            this.gpbConsulta.TabIndex = 1;
            this.gpbConsulta.TabStop = false;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 530);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gpbConsulta);
            this.MaximizeBox = false;
            this.Name = "frmConsultas";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Consultas";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.gpbConsulta.ResumeLayout(false);
            this.gpbConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dtpData;
        public MetroFramework.Controls.MetroGrid dgvDados;
        private MetroFramework.Controls.MetroButton btnNovo;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Components.MetroToolTip ttpAjuda;
        private MetroFramework.Controls.MetroButton btnDeletar;
        private MetroFramework.Controls.MetroProgressBar pgbLoad;
        public MetroFramework.Controls.MetroTextBox txtPesquisar;
        private MetroFramework.Controls.MetroLabel lblPalavraChave;
        private MetroFramework.Controls.MetroComboBox cmbParametro;
        private System.Windows.Forms.GroupBox gpbConsulta;
    }
}