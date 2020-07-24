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
    public partial class frmVenda : MetroForm
    {
        #region Atributos

        public string codvenda = null;

        decimal total, unidade, troco, desconto, pago;
        string nome, cod;
        int i, qtdvenda, estoque, qtdfinal;

        #endregion

        #region Instanciamento de classes

        Som som = new Som();

        #endregion

        public frmVenda()
        {
            InitializeComponent();
        }

        #region Evento para carregar dados e itens (Load)

        private void frmVenda_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarDados();

                pgbLoad.Visible = false;

                txtPago.Enabled = false;

                btnEfetuar.Enabled = false;

                this.Icon = CTRLMusic.Properties.Resources._6_ICONE_chart;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para calcular a venda (Click)
        
        public void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (codvenda == "ace")
                {
                    unidade = Convert.ToDecimal(dgvDados.SelectedRows[0].Cells[12].Value.ToString());
                }
                else
                    if (codvenda == "ins")
                    {
                        unidade = Convert.ToDecimal(dgvDados.SelectedRows[0].Cells[13].Value.ToString());
                    }
                    else
                        if (codvenda == "mid")
                        {
                            unidade = Convert.ToDecimal(dgvDados.SelectedRows[0].Cells[3].Value.ToString());
                        }

                CalculoVenda vd = new CalculoVenda(Convert.ToDecimal(txtDesconto.Text), unidade,
                                     Convert.ToInt16(txtQtdVenda.Text));

                lblTotal.Text = "Total : R$ " + vd.Calcular().ToString();

                total = vd.Calcular();

                txtPago.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para efetuar a venda (Click)

        private void btnEfetuar_Click(object sender, EventArgs e)
        {
            try
            {
                EfetuarVenda();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para fechar o Form (Click)

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Evento para calcular o troco (Leave)

        private void txtPago_Leave(object sender, EventArgs e)
        {
            try
            {
                pago = Convert.ToDecimal(txtPago.Text);

                lblTroco.Text = "Troco : R$ " + (pago - total).ToString();

                btnEfetuar.Enabled = true;
                btnEfetuar.Highlight = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para verificar se há quantidade suficiente para venda (Leave)

        private void txtQtdVenda_Leave(object sender, EventArgs e)
        {
            try
            {
                if (codvenda == "ace")
                {
                    if (dgvDados.SelectedRows[0].Cells[13].Value.ToString().Equals("0"))
                    {
                        MessageBox.Show("Quantidade insuficiente no estoque!", "Erro",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    if (codvenda == "ins")
                    {
                        if (dgvDados.SelectedRows[0].Cells[14].Value.ToString().Equals("0"))
                        {
                            MessageBox.Show("Quantidade insuficiente no estoque!", "Erro",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                        if (codvenda == "mid")
                        {
                            if (dgvDados.SelectedRows[0].Cells[7].Value.ToString().Equals("0"))
                            {
                                MessageBox.Show("Quantidade insuficiente no estoque!", "Erro",
                                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para atribuir valores ao Text dos Labels (CellContentClick)

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (codvenda == "ace")
                {
                    lblNome.Text = lblNome.Text + dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                    lblCodigo.Text = lblCodigo.Text + dgvDados.SelectedRows[0].Cells[0].Value.ToString();
                    lblQuantidade.Text = lblQuantidade.Text + dgvDados.SelectedRows[0].Cells[13].Value.ToString();
                    lblUnitario.Text = lblUnitario.Text + dgvDados.SelectedRows[0].Cells[12].Value.ToString();
                }
                else
                    if (codvenda == "ins")
                    {
                        lblNome.Text = lblNome.Text + dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                        lblCodigo.Text = lblCodigo.Text + dgvDados.SelectedRows[0].Cells[0].Value.ToString();
                        lblUnitario.Text = lblUnitario.Text + dgvDados.SelectedRows[0].Cells[13].Value.ToString();
                        lblQuantidade.Text = lblQuantidade.Text + dgvDados.SelectedRows[0].Cells[14].Value.ToString();
                    }
                    else
                        if (codvenda == "mid")
                        {
                            lblNome.Text = lblNome.Text + dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                            lblCodigo.Text = lblCodigo.Text + dgvDados.SelectedRows[0].Cells[0].Value.ToString();
                            lblUnitario.Text = lblUnitario.Text + dgvDados.SelectedRows[0].Cells[3].Value.ToString();
                            lblQuantidade.Text = lblQuantidade.Text + dgvDados.SelectedRows[0].Cells[7].Value.ToString();
                        }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Resetando os Text dos Labels (CurrentCellChanged)

        private void dgvDados_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                lblNome.Text = "Nome : ";
                lblCodigo.Text = "Código : ";
                lblQuantidade.Text = "Quantidade : ";
                lblUnitario.Text = "Valor Unitário : ";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region Método para mudar/esconder cabeçalhos da tabela (Método)

        public void MudarHeader()
        {
            try
            {
                dgvDados.Columns[0].Visible = false;
                dgvDados.Columns[1].HeaderText = "Nome";
                dgvDados.Columns[2].Visible = false;
                dgvDados.Columns[3].Visible = false;
                dgvDados.Columns[4].Visible = false;
                dgvDados.Columns[5].Visible = false;
                dgvDados.Columns[6].Visible = false;
                dgvDados.Columns[7].Visible = false;
                dgvDados.Columns[8].Visible = false;
                dgvDados.Columns[9].Visible = false;
                dgvDados.Columns[10].Visible = false;
                dgvDados.Columns[11].Visible = false;
                dgvDados.Columns[12].Visible = false;
                dgvDados.Columns[13].Visible = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Método pra carregar os dados na tabela (Método)

        public void CarregarDados()
        {
            try
            {
                if (codvenda == "ace")
                {
                    Acessorio ac = new Acessorio();

                    dgvDados.DataSource = ac.consulta();
                    dgvDados.Refresh();

                    MudarHeader();

                    dgvDados.Columns[1].Width = dgvDados.Width;

                    Name = "Venda de Acessório";
                }
                else
                    if (codvenda == "ins")
                    {
                        Instrumento ins = new Instrumento();

                        dgvDados.DataSource = ins.consulta();
                        dgvDados.Refresh();

                        MudarHeader();

                        dgvDados.Columns[1].Width = dgvDados.Width;

                        Name = "Venda de Instrumento";
                    }
                    else
                        if (codvenda == "mid")
                        {
                            Midia mid = new Midia();

                            dgvDados.DataSource = mid.consulta();
                            dgvDados.Refresh();

                            MudarHeader();

                            dgvDados.Columns[1].Width = dgvDados.Width;

                            Name = "Venda de Mídia";
                        }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Método para efetuar a venda e atualizar a quantidade (Método)

        public void EfetuarVenda()
        {
            try
            {
                if (codvenda == "ace")
                {
                    cod = dgvDados.SelectedRows[0].Cells[0].Value.ToString();
                    nome = dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                    desconto = Convert.ToDecimal(txtDesconto.Text);
                    estoque = Convert.ToInt16(dgvDados.SelectedRows[0].Cells[13].Value.ToString());
                    qtdvenda = Convert.ToInt16((txtQtdVenda.Text));
                    qtdfinal = estoque - qtdvenda;
                    troco = pago - total;

                    pgbLoad.Visible = true;

                    for (i = 1; i < 100; i++)
                    {
                        pgbLoad.Increment(i);
                    }

                    Banco bd = new Banco();

                    MessageBox.Show(bd.altqtd("ACESSORIO", "COD_ACESSORIO", cod, qtdfinal));

                    Venda vd = new Venda(nome, unidade, desconto, pago, total, troco, Convert.ToInt16(cod),
                                         estoque, qtdvenda, DateTime.Today.Date);

                    som.Tada();

                    MessageBox.Show(vd.insere(nome, unidade, desconto, pago, total, troco, Convert.ToInt16(cod),
                                         estoque, qtdvenda, DateTime.Today.Date));

                    som.Notify();

                    var opcao = MessageBox.Show("Vender outro acessório?", "", MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    pgbLoad.Visible = false;

                    if (opcao == DialogResult.Yes)
                    {
                        txtQtdVenda.Text = ""; txtDesconto.Text = ""; txtPago.Text = ""; lblTotal.Text = "Total :";
                        lblTroco.Text = "Troco :";

                        dgvDados.Refresh();
                    }
                    else
                    {
                        //Fechar esse form e abrir o form 'Consultas'
                        Close();

                        frmConsultas cls = new frmConsultas();
                        cls.consulta = "ace";
                        cls.Show();

                        som.Chimes();
                    }
                }
                else
                    if (codvenda == "ins")
                    {
                        cod = dgvDados.SelectedRows[0].Cells[0].Value.ToString();
                        nome = dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                        estoque = Convert.ToInt16(dgvDados.SelectedRows[0].Cells[14].Value.ToString());
                        qtdvenda = Convert.ToInt16((txtQtdVenda.Text));
                        qtdfinal = estoque - qtdvenda;

                        pgbLoad.Visible = true;

                        for (i = 1; i < 100; i++)
                        {
                            pgbLoad.Increment(i);
                        }

                        Banco bd = new Banco();

                        MessageBox.Show(bd.altqtd("INSTRUMENTO", "COD_INSTRUMENTO", cod, qtdfinal));

                        Venda vd = new Venda(nome, unidade, desconto, pago, total, troco, Convert.ToInt16(cod),
                                             estoque, qtdvenda, DateTime.Today.Date);

                        som.Tada();

                        MessageBox.Show(vd.insere(nome, unidade, desconto, pago, total, troco, Convert.ToInt16(cod),
                                             estoque, qtdvenda, DateTime.Today.Date));

                        som.Notify();

                        var opcao = MessageBox.Show("Vender outro instrumento?", "", MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                        pgbLoad.Visible = false;

                        if (opcao == DialogResult.Yes)
                        {
                            txtQtdVenda.Text = ""; txtDesconto.Text = ""; txtPago.Text = ""; lblTotal.Text = "Total :";
                            lblTroco.Text = "Troco :";

                            dgvDados.Refresh();
                        }
                        else
                        {
                            //Fechar esse form e abrir o form 'Consultas'
                            Close();

                            frmConsultas cls = new frmConsultas();
                            cls.consulta = "ins";
                            cls.Show();

                            som.Chimes();
                        }
                    }
                    else
                        if (codvenda == "mid")
                        {
                            cod = dgvDados.SelectedRows[0].Cells[0].Value.ToString();
                            nome = dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                            estoque = Convert.ToInt16(dgvDados.SelectedRows[0].Cells[7].Value.ToString());
                            qtdvenda = Convert.ToInt16((txtQtdVenda.Text));
                            qtdfinal = estoque - qtdvenda;

                            pgbLoad.Visible = true;

                            for (i = 1; i < 100; i++)
                            {
                                pgbLoad.Increment(i);
                            }

                            Banco bd = new Banco();

                            MessageBox.Show(bd.altqtd("MIDIA", "COD_MIDIA", cod, qtdfinal));

                            Venda vd = new Venda(nome, unidade, desconto, pago, total, troco, Convert.ToInt16(cod),
                                        estoque, qtdvenda, DateTime.Today.Date);

                            som.Tada();

                            MessageBox.Show(vd.insere(nome, unidade, desconto, pago, total, troco, Convert.ToInt16(cod),
                                                 estoque, qtdvenda, DateTime.Today.Date));

                            som.Notify();

                            var opcao = MessageBox.Show("Vender outra mídia?", "", MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                            pgbLoad.Visible = false;

                            if (opcao == DialogResult.Yes)
                            {
                                txtQtdVenda.Text = ""; txtDesconto.Text = ""; txtPago.Text = ""; lblTotal.Text = "Total :";
                                lblTroco.Text = "Troco :";

                                dgvDados.Refresh();
                            }
                            else
                            {
                                //Fechar esse form e abrir o form 'Consultas'
                                Close();

                                frmConsultas cls = new frmConsultas();
                                cls.consulta = "mid";
                                cls.Show();

                                som.Chimes();
                            }
                        }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
