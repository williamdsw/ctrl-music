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
using System.IO;
using System.Data.SqlClient;

namespace CTRLMusic
{
    public partial class frmConsultas : MetroForm
    {
        #region Variáveis 

        public string consulta = null;

        string caminho;

        int i;

        #endregion

        #region Instanciamento de classes

        Acessorio ac = new Acessorio();
        Instrumento ins = new Instrumento();
        Midia mid = new Midia();
        Venda vda = new Venda();
        Som som = new Som();
        Banco bd = new Banco();

        #endregion

        public frmConsultas()
        {
            InitializeComponent();
        }

        #region Evento que carrega os dados e outros itens (Load)

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            try
            {
                pgbLoad.Visible = false;                                            //esconde visibilidade

                this.Icon = CTRLMusic.Properties.Resources._6_ICONE_database;       //define ícone

                PreencheDataGrid();                             

                cmbParametro.PromptText = "Parâmetro";                              //define o texto de exibição

                txtPesquisar.Enabled = false;                                       //desabilita botão
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region Evento para abrir tela de cadastro (Click)

        public void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                som.Chimes();

                if (consulta == "ace")
                {
                    frmCadastroAcessorios cad = new frmCadastroAcessorios();
                    cad.Show();

                    Close();
                }
                else
                    if (consulta == "ins")
                    {
                        frmCadastroInstrumento cin = new frmCadastroInstrumento();
                        cin.Show();

                        Close();
                    }
                    else
                        if (consulta == "mid")
                        {
                            frmCadastroMidia cmi = new frmCadastroMidia();
                            cmi.Show();

                            Close();
                        }
                        else
                            if(consulta == "vda")
                            {
                                frmAbaVender abv = new frmAbaVender();
                                abv.Show();

                                Close();
                            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para fechar form (Click)

        private void lbkVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Evento para excluir (Click)

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ExcluirRegistro();      
        }

        #endregion

        #region Evento para abrir tela de atualização (Click)

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt16(dgvDados.SelectedRows[0].Cells[0].Value.ToString());

                MudarTela();

                som.Chimes();

                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para abrir tela de produto (CellContentDoubleClick)

        private void dgvDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int cod = Convert.ToInt16(dgvDados.SelectedRows[0].Cells[0].Value.ToString());

                CarregarDados();

                if ((consulta == "ace") || (consulta == "ins") || (consulta == "mid"))
                {
                    som.Chimes();
                }
                else
                    if (consulta == "mid")
                    {
                        som.Chord();
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para limpar o TxtPesquisar (Enter)

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
        }

        #endregion

        #region Evento para preencher o txtPesquisar (Leave)

        private void txtPesquisar_Leave(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == null)
            {
                txtPesquisar.Text = "Pesquisar";
            }
        }

        #endregion

        #region Evento para habilitar o txtPesquisar (SelectedIndexChanged)

        private void cmbParametro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbParametro.Text != null)                                  //se o texto do cmb não for null, habilita o 
            {                                                               //txtPesquisar
                txtPesquisar.Enabled = true;
            }
        }

        #endregion

        #region Evento para filtrar o DataGridView (TextChanged)

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (consulta == "ace")
                {
                    if (txtPesquisar.Text != null)                      //se o txt não for null, preenche o datagrid de acordo com o a escolha
                    {
                        dgvDados.DataSource = bd.filtra("ACESSORIO", cmbParametro.SelectedItem.ToString(), txtPesquisar.Text);
                    }
                }
                else
                    if (consulta == "ins")
                    {
                        if (txtPesquisar.Text != null)
                        {
                            dgvDados.DataSource = bd.filtra("INSTRUMENTO", cmbParametro.SelectedItem.ToString(), txtPesquisar.Text);
                        }
                    }
                    else
                        if (consulta == "mid")
                        {
                            if (txtPesquisar.Text != null)
                            {
                                dgvDados.DataSource = bd.filtra("MIDIA", cmbParametro.SelectedItem.ToString(), txtPesquisar.Text);
                            }
                        }
                        else
                            if (consulta == "vda")
                            {
                                if (txtPesquisar.Text != null)
                                {
                                    dgvDados.DataSource = bd.filtra("VENDA", cmbParametro.SelectedItem.ToString(), txtPesquisar.Text);
                                }
                            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Método para reutilizar o form de cadastro (Método)

        public void MudarTela()
        {
            try
            {
                if (consulta == "ace")
                {
                    frmCadastroAcessorios frm = new frmCadastroAcessorios();        //Instanciando o form

                    frm.cod = dgvDados.SelectedRows[0].Cells[0].Value.ToString();   //Pegando código do DataGrid

                    frm.Text = "Atualizar Acessório";                               //Mudando texto da janela

                    frm.btnCadastrar.Text = "Atualizar";                            //Mudando o Text do Button 'Cadastrar'
             
                    frm.btnLimpar.Hide();                                           //"Escondendo" Buttons

                    //Preenchendo Labels, TextBoxes e ComboBoxes de acordo com o valor na tabela
                    frm.txtNome.Text = dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                    frm.txtMarca.Text = dgvDados.SelectedRows[0].Cells[2].Value.ToString();
                    frm.txtDistribuidor.Text = dgvDados.SelectedRows[0].Cells[3].Value.ToString();
                    frm.txtModelo.Text = dgvDados.SelectedRows[0].Cells[4].Value.ToString();
                    frm.txtCor.Text = dgvDados.SelectedRows[0].Cells[5].Value.ToString();
                    frm.cmbTipo.PromptText = dgvDados.SelectedRows[0].Cells[6].Value.ToString();
                    frm.cmbInstrumento.PromptText = dgvDados.SelectedRows[0].Cells[7].Value.ToString();
                    frm.txtAltura.Text = dgvDados.SelectedRows[0].Cells[8].Value.ToString();
                    frm.txtLargura.Text = dgvDados.SelectedRows[0].Cells[9].Value.ToString();
                    frm.txtProfundidade.Text = dgvDados.SelectedRows[0].Cells[10].Value.ToString();
                    frm.txtPeso.Text = dgvDados.SelectedRows[0].Cells[11].Value.ToString();
                    frm.txtPreco.Text = dgvDados.SelectedRows[0].Cells[12].Value.ToString();
                    frm.txtQuantidade.Text = dgvDados.SelectedRows[0].Cells[13].Value.ToString();

                    caminho = dgvDados.SelectedRows[0].Cells[14].Value.ToString();
               
                    frm.ptbImagem.BackgroundImage = Bitmap.FromFile(caminho);

                    frm.Show();                                                                 //Mostrando o form
                }
                else
                    if (consulta == "ins")
                    {
                        frmCadastroInstrumento frm = new frmCadastroInstrumento();

                        frm.cod = dgvDados.SelectedRows[0].Cells[0].Value.ToString();

                        frm.Text = "Atualizar Instrumento";

                        frm.btnCadastrar.Text = "Atualizar";

                        frm.btnLimpar.Hide();

                        frm.txtNome.Text = dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                        frm.txtMarca.Text = dgvDados.SelectedRows[0].Cells[2].Value.ToString();
                        frm.txtDistribuidor.Text = dgvDados.SelectedRows[0].Cells[3].Value.ToString();
                        frm.txtCor.Text = dgvDados.SelectedRows[0].Cells[4].Value.ToString();
                        frm.txtModelo.Text = dgvDados.SelectedRows[0].Cells[5].Value.ToString();
                        frm.txtAltura.Text = dgvDados.SelectedRows[0].Cells[6].Value.ToString();
                        frm.txtLargura.Text = dgvDados.SelectedRows[0].Cells[7].Value.ToString();
                        frm.txtProfundidade.Text = dgvDados.SelectedRows[0].Cells[8].Value.ToString();
                        frm.txtPeso.Text = dgvDados.SelectedRows[0].Cells[9].Value.ToString();
                        frm.cmbTipo.PromptText = dgvDados.SelectedRows[0].Cells[10].Value.ToString();
                        frm.cmbInstrumento.PromptText = dgvDados.SelectedRows[0].Cells[11].Value.ToString();
                        frm.cmbEstado.PromptText = dgvDados.SelectedRows[0].Cells[12].Value.ToString();
                        frm.txtPreco.Text = dgvDados.SelectedRows[0].Cells[13].Value.ToString();
                        frm.txtQuantidade.Text = dgvDados.SelectedRows[0].Cells[14].Value.ToString();

                        caminho = dgvDados.SelectedRows[0].Cells[15].Value.ToString();

                        frm.ptbImagem.BackgroundImage = Bitmap.FromFile(caminho);

                        frm.Show();
                    }
                    else
                        if (consulta == "mid")
                        {
                            frmCadastroMidia frm = new frmCadastroMidia();

                            frm.cod = dgvDados.SelectedRows[0].Cells[0].Value.ToString();

                            frm.Text = "Atualizar Midia";

                            frm.btnCadastrar.Text = "Atualizar";

                            frm.btnLimpar.Hide();

                            frm.txtTitulo.Text = dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                            frm.txtArtista.Text = dgvDados.SelectedRows[0].Cells[2].Value.ToString();
                            frm.txtPreco.Text = dgvDados.SelectedRows[0].Cells[3].Value.ToString();
                            frm.txtAno.Text = dgvDados.SelectedRows[0].Cells[4].Value.ToString();
                            frm.cmbGenero.PromptText = dgvDados.SelectedRows[0].Cells[5].Value.ToString();
                            frm.txtDuracao.Text = dgvDados.SelectedRows[0].Cells[6].Value.ToString();
                            frm.txtQuantidade.Text = dgvDados.SelectedRows[0].Cells[7].Value.ToString();
                            frm.txtIdioma.Text = dgvDados.SelectedRows[0].Cells[8].Value.ToString();
                            frm.cmbTipo.PromptText = dgvDados.SelectedRows[0].Cells[9].Value.ToString();
                            frm.cmbEstado.PromptText = dgvDados.SelectedRows[0].Cells[10].Value.ToString();
                            frm.txtMarca.Text = dgvDados.SelectedRows[0].Cells[11].Value.ToString();
                            frm.txtProfundidade.Text = dgvDados.SelectedRows[0].Cells[12].Value.ToString();
                            frm.txtAltura.Text = dgvDados.SelectedRows[0].Cells[13].Value.ToString();
                            frm.txtPeso.Text = dgvDados.SelectedRows[0].Cells[14].Value.ToString();
                            frm.txtLargura.Text = dgvDados.SelectedRows[0].Cells[15].Value.ToString();

                            caminho = dgvDados.SelectedRows[0].Cells[16].Value.ToString();

                            frm.ptbImagem.BackgroundImage = Bitmap.FromFile(caminho);

                            frm.Show();
                        }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Método para carregar os dados no frmProduto (Método)

        public void CarregarDados()
        {
            try
            {
                if (consulta == "ace")
                {
                    int cod = Convert.ToInt16(dgvDados.SelectedRows[0].Cells[0].Value.ToString());  //Pegando o código do DataGrid

                    frmProduto fpt = new frmProduto();                                          //Instanciando o form 

                    fpt.lblDuracao.Hide();                                                      //"Escondendo" Labels

                    fpt.Text = "Informações do acessório";

                    //Preenchendo Labels, TextBoxes e ComboBoxes de acordo com o valor na tabela.
                    fpt.lblCodBarras.Text = fpt.lblCodBarras.Text + dgvDados.SelectedRows[0].Cells[0].Value.ToString();
                    fpt.lblNome.Text = fpt.lblNome.Text + dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                    fpt.lblMarca.Text = fpt.lblMarca.Text + dgvDados.SelectedRows[0].Cells[2].Value.ToString();
                    fpt.lblDistribuidor.Text = fpt.lblDistribuidor.Text + dgvDados.SelectedRows[0].Cells[3].Value.ToString();
                    fpt.lblModelo.Text = fpt.lblModelo.Text + dgvDados.SelectedRows[0].Cells[4].Value.ToString();
                    fpt.lblCor.Text = fpt.lblCor.Text + dgvDados.SelectedRows[0].Cells[5].Value.ToString();
                    fpt.lblTipo.Text = fpt.lblTipo.Text + dgvDados.SelectedRows[0].Cells[6].Value.ToString();
                    fpt.lblInstrumento.Text = fpt.lblInstrumento.Text + dgvDados.SelectedRows[0].Cells[7].Value.ToString();
                    fpt.lblAltura.Text = fpt.lblAltura.Text + dgvDados.SelectedRows[0].Cells[8].Value.ToString();
                    fpt.lblLargura.Text = fpt.lblLargura.Text + dgvDados.SelectedRows[0].Cells[9].Value.ToString();
                    fpt.lblProfundidade.Text = fpt.lblProfundidade.Text + dgvDados.SelectedRows[0].Cells[10].Value.ToString();
                    fpt.lblPeso.Text = fpt.lblPeso.Text + dgvDados.SelectedRows[0].Cells[11].Value.ToString();
                    fpt.lblPreco.Text = fpt.lblPreco.Text + dgvDados.SelectedRows[0].Cells[12].Value.ToString();
                    fpt.lblQuantidade.Text = fpt.lblQuantidade.Text + dgvDados.SelectedRows[0].Cells[13].Value.ToString();

                    caminho = dgvDados.SelectedRows[0].Cells[14].Value.ToString();

                    fpt.ptbImagem.BackgroundImage = Bitmap.FromFile(caminho);

                    fpt.Show();
                }
                else
                    if (consulta == "ins")
                    {
                        int cod = Convert.ToInt16(dgvDados.SelectedRows[0].Cells[0].Value.ToString());

                        frmProduto fpt = new frmProduto();

                        fpt.Text = "Informações do instrumento";

                        fpt.lblDuracao.Hide();

                        fpt.lblCodBarras.Text = fpt.lblCodBarras.Text + dgvDados.SelectedRows[0].Cells[0].Value.ToString();
                        fpt.lblNome.Text = fpt.lblNome.Text + dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                        fpt.lblMarca.Text = fpt.lblMarca.Text + dgvDados.SelectedRows[0].Cells[2].Value.ToString();
                        fpt.lblDistribuidor.Text = fpt.lblDistribuidor.Text + dgvDados.SelectedRows[0].Cells[3].Value.ToString();
                        fpt.lblCor.Text = fpt.lblCor.Text + dgvDados.SelectedRows[0].Cells[4].Value.ToString();
                        fpt.lblModelo.Text = fpt.lblModelo.Text + dgvDados.SelectedRows[0].Cells[5].Value.ToString();
                        fpt.lblAltura.Text = fpt.lblAltura.Text + dgvDados.SelectedRows[0].Cells[6].Value.ToString();
                        fpt.lblLargura.Text = fpt.lblLargura.Text + dgvDados.SelectedRows[0].Cells[7].Value.ToString();
                        fpt.lblProfundidade.Text = fpt.lblProfundidade.Text + dgvDados.SelectedRows[0].Cells[8].Value.ToString();
                        fpt.lblPeso.Text = fpt.lblPeso.Text + dgvDados.SelectedRows[0].Cells[9].Value.ToString();
                        fpt.lblTipo.Text = fpt.lblTipo.Text + dgvDados.SelectedRows[0].Cells[10].Value.ToString();
                        fpt.lblInstrumento.Text = fpt.lblInstrumento.Text + dgvDados.SelectedRows[0].Cells[11].Value.ToString();
                        fpt.lblPreco.Text = fpt.lblPreco.Text + dgvDados.SelectedRows[0].Cells[13].Value.ToString();
                        fpt.lblQuantidade.Text = fpt.lblQuantidade.Text + dgvDados.SelectedRows[0].Cells[14].Value.ToString();

                        caminho = dgvDados.SelectedRows[0].Cells[15].Value.ToString();

                        fpt.ptbImagem.BackgroundImage = Bitmap.FromFile(caminho);

                        fpt.Show();
                    }
                    else
                        if (consulta == "mid")
                        {
                            int cod = Convert.ToInt16(dgvDados.SelectedRows[0].Cells[0].Value.ToString());

                            frmProduto fpt = new frmProduto();

                            fpt.Text = "Informações da mídia";

                            fpt.lblCodBarras.Text = fpt.lblCodBarras.Text + dgvDados.SelectedRows[0].Cells[0].Value.ToString();
                            fpt.lblNome.Text = "Título : " + dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                            fpt.lblModelo.Text = "Artista : " + dgvDados.SelectedRows[0].Cells[2].Value.ToString();
                            fpt.lblPreco.Text = fpt.lblPreco.Text + dgvDados.SelectedRows[0].Cells[3].Value.ToString();
                            fpt.lblInstrumento.Text = "Ano de lançamento : " + dgvDados.SelectedRows[0].Cells[4].Value.ToString();
                            fpt.lblCor.Text = "Gênero : " + dgvDados.SelectedRows[0].Cells[5].Value.ToString();
                            fpt.lblDuracao.Text = fpt.lblDuracao.Text + dgvDados.SelectedRows[0].Cells[6].Value.ToString();
                            fpt.lblQuantidade.Text = fpt.lblQuantidade.Text + dgvDados.SelectedRows[0].Cells[7].Value.ToString();
                            fpt.lblTipo.Text = fpt.lblTipo.Text + dgvDados.SelectedRows[0].Cells[9].Value.ToString();
                            fpt.lblDistribuidor.Text = "Estado : " + dgvDados.SelectedRows[0].Cells[10].Value.ToString();
                            fpt.lblMarca.Text = fpt.lblMarca.Text + dgvDados.SelectedRows[0].Cells[11].Value.ToString();
                            fpt.lblProfundidade.Text = fpt.lblProfundidade.Text + dgvDados.SelectedRows[0].Cells[12].Value.ToString();
                            fpt.lblAltura.Text = fpt.lblAltura.Text + dgvDados.SelectedRows[0].Cells[13].Value.ToString();
                            fpt.lblPeso.Text = fpt.lblPeso.Text + dgvDados.SelectedRows[0].Cells[14].Value.ToString();
                            fpt.lblLargura.Text = fpt.lblLargura.Text + dgvDados.SelectedRows[0].Cells[15].Value.ToString();

                            caminho = dgvDados.SelectedRows[0].Cells[16].Value.ToString();

                            fpt.ptbImagem.BackgroundImage = Bitmap.FromFile(caminho);
                           
                            fpt.Show();
                        }
                        else
                            if (consulta == "vda")
                            {
                                MessageBox.Show("Não há tela para informações da venda");
                            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Método para esconder/mudar cabeçalhos da tabela (Método)

        public void MudarHeader()
        {
            if (consulta == "ace")
            {
                dgvDados.Columns[0].HeaderText = "Código";
                dgvDados.Columns[1].HeaderText = "Nome";
                dgvDados.Columns[2].HeaderText = "Marca";
                dgvDados.Columns[3].HeaderText = "Distribuídor";
                dgvDados.Columns[4].HeaderText = "Modelo";
                dgvDados.Columns[5].Visible = false;
                dgvDados.Columns[6].HeaderText = "Tipo";
                dgvDados.Columns[7].HeaderText = "Instrumento";
                dgvDados.Columns[8].Visible = false;
                dgvDados.Columns[9].Visible = false;
                dgvDados.Columns[10].Visible = false;
                dgvDados.Columns[11].Visible = false;
                dgvDados.Columns[12].HeaderText = "Preço";
                dgvDados.Columns[13].HeaderText = "Quantidade";
                dgvDados.Columns[14].Visible = false;
            }
            else
                if(consulta == "ins")
                {
                    dgvDados.Columns[0].HeaderText = "Código";
                    dgvDados.Columns[1].HeaderText = "Nome";
                    dgvDados.Columns[2].HeaderText = "Marca";
                    dgvDados.Columns[3].HeaderText = "Distribuídor";
                    dgvDados.Columns[4].Visible = false;
                    dgvDados.Columns[5].HeaderText = "Modelo";
                    dgvDados.Columns[6].Visible = false;
                    dgvDados.Columns[7].Visible = false;
                    dgvDados.Columns[8].Visible = false;
                    dgvDados.Columns[9].Visible = false;
                    dgvDados.Columns[10].HeaderText = "Tipo";
                    dgvDados.Columns[11].HeaderText = "Instrumento";
                    dgvDados.Columns[12].HeaderText = "Estado";
                    dgvDados.Columns[13].HeaderText = "Preço";
                    dgvDados.Columns[14].HeaderText = "Quantidade";
                    dgvDados.Columns[15].Visible = false;
                }
                else
                    if(consulta == "mid")
                    {
                        dgvDados.Columns[0].HeaderText = "Código";
                        dgvDados.Columns[1].HeaderText = "Nome";
                        dgvDados.Columns[2].HeaderText = "Artista";
                        dgvDados.Columns[3].HeaderText = "Preço";
                        dgvDados.Columns[4].HeaderText = "Ano";
                        dgvDados.Columns[5].HeaderText = "Gênero";
                        dgvDados.Columns[6].HeaderText = "Duração";
                        dgvDados.Columns[7].HeaderText = "Quantidade";
                        dgvDados.Columns[8].HeaderText = "Idioma";
                        dgvDados.Columns[9].HeaderText = "Tipo";
                        dgvDados.Columns[10].HeaderText = "Estado";
                        dgvDados.Columns[11].Visible = false;
                        dgvDados.Columns[12].Visible = false;
                        dgvDados.Columns[13].Visible = false;
                        dgvDados.Columns[14].Visible = false;
                        dgvDados.Columns[15].Visible = false;
                        dgvDados.Columns[16].Visible = false;
                    }
                    else
                        if (consulta == "vda")
                        {
                            dgvDados.Columns[0].HeaderText = "Código";
                            dgvDados.Columns[1].HeaderText = "Cód. Produto";
                            dgvDados.Columns[2].HeaderText = "Produto";
                            dgvDados.Columns[3].HeaderText = "Valor total";
                            dgvDados.Columns[4].HeaderText = "Valor do troco";
                            dgvDados.Columns[5].HeaderText = "Valor pago";
                            dgvDados.Columns[6].HeaderText = "Valor Unitário";
                            dgvDados.Columns[7].HeaderText = "Desconto";
                            dgvDados.Columns[8].HeaderText = "Qtd. Produto";
                            dgvDados.Columns[9].HeaderText = "Qtd. Vendida";
                            dgvDados.Columns[10].HeaderText = "Data da Venda";
                        }
        }

        #endregion

        #region Método para excluir registro (Método)

        public void ExcluirRegistro()
        {
            try
            {
                int cod = Convert.ToInt16(dgvDados.SelectedRows[0].Cells[0].Value.ToString());  //pegando código do datagrid

                if (consulta == "ace")
                {
                    som.Notify();

                    var opcao = MessageBox.Show("Tem certeza?", "Excluir acessório",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (opcao == DialogResult.Yes)
                    {
                        pgbLoad.Visible = true;

                        for (i = 1; i < 100; i++)
                        {
                            pgbLoad.Increment(i);
                        }

                        Banco bd = new Banco();

                        string mensagem = bd.apaga("ACESSORIO", "COD_ACESSORIO", cod.ToString());

                        som.Tada();

                        MessageBox.Show(mensagem);

                        Close();

                        frmConsultas frm = new frmConsultas();

                        frm.consulta = "ace";

                        frm.Show();
                    }
                }
                else
                    if (consulta == "ins")
                    {
                        som.Notify();

                        var opcao = MessageBox.Show("Tem certeza?", "Excluir instrumento",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (opcao == DialogResult.Yes)
                        {
                            pgbLoad.Visible = true;

                            for (i = 1; i < 100; i++)
                            {
                                pgbLoad.Increment(i);
                            }

                            Banco bd = new Banco();

                            string mensagem = bd.apaga("INSTRUMENTO", "COD_INSTRUMENTO", cod.ToString());

                            som.Tada();

                            MessageBox.Show(mensagem);

                            Close();

                            frmConsultas frm = new frmConsultas();

                            frm.consulta = "ins";

                            frm.Show();
                        }
                    }
                    else
                        if (consulta == "mid")
                        {
                            som.Notify();

                            var opcao = MessageBox.Show("Tem certeza?", "Excluir mídia",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (opcao == DialogResult.Yes)
                            {
                                pgbLoad.Visible = true;

                                for (i = 1; i < 100; i++)
                                {
                                    pgbLoad.Increment(i);
                                }

                                Banco bd = new Banco();

                                string mensagem = bd.apaga("MIDIA", "COD_MIDIA", cod.ToString());

                                som.Tada();

                                MessageBox.Show(mensagem);

                                Close();

                                frmConsultas frm = new frmConsultas();

                                frm.consulta = "mid";

                                frm.Show();
                            }
                        }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Método para carregar os dados no DataGrid (Método)

        public void PreencheDataGrid()
        {
            try
            {
                if (consulta == "ace")
                {
                    dgvDados.DataSource = ac.consulta();
                    dgvDados.Refresh();

                    Text = "Consulta de Acessórios";
                    MudarHeader();

                    //utiliza um for para pegar cada campo da tabela pra preencher o combobox
                    for (int index = 0; index < bd.tabelas("ACESSORIO").FieldCount; index++)
                    {
                        cmbParametro.Items.Add(bd.tabelas("ACESSORIO").GetName(index));
                    }

                    ttpAjuda.SetToolTip(btnNovo, "Cadastrar um novo acessório");
                    ttpAjuda.SetToolTip(btnEditar, "Edite dados do acessório escolhido");
                    ttpAjuda.SetToolTip(btnDeletar, "Exclua um acessório cadastrado");
                }
                else
                    if (consulta == "ins")
                    {
                        dgvDados.DataSource = ins.consulta();
                        dgvDados.Refresh();

                        Text = "Consulta de Instrumentos";
                        MudarHeader();

                        for (int index = 0; index < bd.tabelas("INSTRUMENTO").FieldCount; index++)
                        {
                            cmbParametro.Items.Add(bd.tabelas("INSTRUMENTO").GetName(index));
                        }

                        ttpAjuda.SetToolTip(btnNovo, "Cadastrar um novo instrumento");
                        ttpAjuda.SetToolTip(btnEditar, "Edite dados do instrumento escolhido");
                        ttpAjuda.SetToolTip(btnDeletar, "Exclua um instrumento cadastrado");
                    }
                    else
                        if (consulta == "mid")
                        {
                            dgvDados.DataSource = mid.consulta();
                            dgvDados.Refresh();

                            Text = "Consulta de Mídias";
                            MudarHeader();

                            for (int index = 0; index < bd.tabelas("MIDIA").FieldCount; index++)
                            {
                                cmbParametro.Items.Add(bd.tabelas("MIDIA").GetName(index));
                            }

                            ttpAjuda.SetToolTip(btnNovo, "Cadastrar uma nova mídia");
                            ttpAjuda.SetToolTip(btnEditar, "Edite dados da mídia escolhida");
                            ttpAjuda.SetToolTip(btnDeletar, "Exclua uma mídia cadastrada");
                        }
                        else
                            if (consulta == "vda")
                            {
                                dgvDados.DataSource = vda.consulta();
                                dgvDados.Refresh();

                                Text = "Consulta de Vendas";
                                MudarHeader();

                                btnDeletar.Hide();
                                btnEditar.Hide();

                                for (int index = 0; index < bd.tabelas("VENDA").FieldCount; index++)
                                {
                                    cmbParametro.Items.Add(bd.tabelas("VENDA").GetName(index));
                                }

                                btnNovo.Text = "Nova";

                                ttpAjuda.SetToolTip(btnNovo, "Efetuar uma nova venda");
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
