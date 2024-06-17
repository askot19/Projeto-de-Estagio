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
using GestaoFinanceira.Utilidade;
using GestaoFinanceira.Validacao;
using MetroFramework;

namespace GestaoFinanceira.Visual
{
    public partial class frmRelatorioUsuario : MetroForm
    {
        /// <summary>
        /// Variavel global da classe
        /// </summary>
        public int codigo = 0;
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);

        public frmRelatorioUsuario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo botao voltar;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo load do formulario relatorio de usuario;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRelatorioUsuario_Load(object sender, EventArgs e)
        {
            //Gerar arquivo WORD/PDF/EXCEL
            cmbGerarArquivo.Items.Insert(0, "");
            cmbGerarArquivo.Items.Insert(1, "Gerar Pdf");
            cmbGerarArquivo.Items.Insert(2, "Gerar Word");
            cmbGerarArquivo.Items.Insert(3, "Gerar Excel");

            //Muda a cor do DATAGRIDVIEW
            dgvUsuario.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvUsuario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            CarregaUsuario(codigo);

            //Formata o DATAGRIDVIEW
            btnPesquisar_Click(sender, e);
            dgvUsuario.Columns["user_id"].HeaderText = "Código";
            dgvUsuario.Columns["user_id"].Width = 70;
            dgvUsuario.Columns["user_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
       
            dgvUsuario.Columns["user_usuario"].HeaderText = "Nome do Usuário";
            dgvUsuario.Columns["user_usuario"].Width = 537;

            //Disabilita a coluna
            dgvUsuario.Columns["user_password"].HeaderText = "Senha do Usuário";
            dgvUsuario.Columns["user_password"].Width = 150;
        }

        /// <summary>
        /// Metodo carrea informações do banco de dados;
        /// </summary>
        /// <param name="codigo"></param>
        public void CarregaUsuario(int codigo)
        {
            validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
            dgvUsuario.DataSource = valida_usuario.CarregarUsuario(codigo);
        }

        /// <summary>
        /// Metodo botao pesquisar;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
                dgvUsuario.DataSource = valida_usuario.ListarUsuario(txtPesquisaUsuario.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo duplo click no dgv usuario;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvUsuario.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        /// <summary>
        /// Metodo para gerar aquivos PDF, WORD e EXCEL;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbGerarArquivo.selectedIndex) == -1)
            {
                MetroMessageBox.Show(this, "\n Por favor, selecione uma opção de documento", "GERAR DOCUMENTOS", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToString(cmbGerarArquivo.selectedValue) == "")
            {
                MetroMessageBox.Show(this, "\n\n Por favor, selecione uma opção de documento", "GERAR DOCUMENTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToString(cmbGerarArquivo.selectedValue) == "Gerar Pdf")
            {
                MetroMessageBox.Show(this, "\n\n Documento Pdf gerado com sucesso!", "GERAR DOCUMENTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (Convert.ToString(cmbGerarArquivo.selectedValue) == "Gerar Word")
            {
                MetroMessageBox.Show(this, "\n\n Documento Word gerado com sucesso!", "GERAR DOCUMENTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (Convert.ToString(cmbGerarArquivo.selectedValue) == "Gerar Excel")
            {
                MetroMessageBox.Show(this, "\n\n Documento Excel gerado com sucesso!", "GERAR DOCUMENTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
