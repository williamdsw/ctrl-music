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
    public partial class frmConsultaUsuario : MetroForm
    {
        #region Instanciamento de classes

        Usuario user = new Usuario();

        Som som = new Som();

        #endregion

        public frmConsultaUsuario()
        {
            InitializeComponent();
        }

        #region Evento para carregar dados e itens (Load)

        private void frmConsultaUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDados.DataSource = user.consulta();
                dgvDados.Refresh();

                MudarHeader();

                dgvDados.Columns[1].Width = dgvDados.Width;

                this.Icon = CTRLMusic.Properties.Resources._6_ICONE_database;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para excluir registro (Click)

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt16(dgvDados.SelectedRows[0].Cells[0].Value.ToString());

                som.Notify();

                var opcao = MessageBox.Show("Tem certeza?", "Excluir usuário",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    Banco bd = new Banco();

                    string mensagem = bd.apaga("USUARIO", "COD_USUARIO", cod.ToString());

                    som.Tada();

                    MessageBox.Show(mensagem);

                    dgvDados.Refresh();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        #region Evento para definir Text dos Labels (CellContentDoubleClick)

        private void dgvDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblCodigo.Text = lblCodigo.Text + dgvDados.SelectedRows[0].Cells[0].Value.ToString();
                lblNome.Text = lblNome.Text + dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                lblCodFun.Text = lblCodFun.Text + dgvDados.SelectedRows[0].Cells[3].Value.ToString();

                if (dgvDados.SelectedRows[0].Cells[2].Value.Equals(true))
                {
                    chkAdministrador.Checked = true;
                }
                else
                {
                    chkAdministrador.Checked = false;
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
                lblCodigo.Text = "Código de Usuário : ";
                lblCodFun.Text = "Código de Funcionário : ";
                chkAdministrador.Checked = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Método para abrir reutilizar tela de cadastro para atualização (Método)

        public void MudarTela()
        {
            try
            {
                //Instanciando o form 'CadastroMidia'
                frmNovoUsuario fnu = new frmNovoUsuario();

                fnu.cod = dgvDados.SelectedRows[0].Cells[0].Value.ToString();

                fnu.Text = "Atualizar Usuário";

                //Mudando o Text do Button 'Cadastrar'
                fnu.btnCadastrar.Text = "Atualizar";

                //Preenchendo Labels e TextBoxes de acordo com o valor na tabela.
                fnu.txtUsuario.Text = dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                fnu.txtCodFuncionario.Text = dgvDados.SelectedRows[0].Cells[3].Value.ToString();

                if (dgvDados.SelectedRows[0].Cells[2].Value.Equals(true))
                {
                    fnu.chkAdministrador.Checked = true;
                }
                else
                {
                    fnu.chkAdministrador.Checked = false;
                }

                fnu.Show();
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
            try
            {
                dgvDados.Columns[0].HeaderText = "Código";
                dgvDados.Columns[1].HeaderText = "Nome";
                dgvDados.Columns[2].Visible = false;
                dgvDados.Columns[3].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
