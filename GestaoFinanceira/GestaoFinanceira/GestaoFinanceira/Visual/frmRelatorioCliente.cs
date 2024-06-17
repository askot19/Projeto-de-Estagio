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
    public partial class frmRelatorioCliente : MetroForm
    {
        /// <summary>
        /// Variavel Global da classe;
        /// </summary>
        public int codigo = 0;
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);

        public frmRelatorioCliente()
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
        /// Metodo load do formulario de relatorio de cliente;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRelatorioCliente_Load(object sender, EventArgs e)
        {
            //Gerar arquivo WORD/PDF/EXCEL
            cmbGerarArquivo.Items.Insert(0, "");
            cmbGerarArquivo.Items.Insert(1, "Gerar Pdf");
            cmbGerarArquivo.Items.Insert(2, "Gerar Word");
            cmbGerarArquivo.Items.Insert(3, "Gerar Excel");

            //Muda a cor do DATAGRIDVIEW
            dgvCliente.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvCliente.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            CarregaCliente(codigo);

            //Formata o DATAGRIDVIEW
            btnPesquisar_Click(sender, e);
            dgvCliente.Columns["cli_dtCadastro"].HeaderText = "Data de Cadastro";
            dgvCliente.Columns["cli_dtCadastro"].Width = 140;

            dgvCliente.Columns["cli_id"].HeaderText = "Código";
            dgvCliente.Columns["cli_id"].Width = 70;
            dgvCliente.Columns["cli_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCliente.Columns["cli_cpf"].HeaderText = "Cpf do Cliente";
            dgvCliente.Columns["cli_cpf"].Width = 140;

            dgvCliente.Columns["cli_nome"].HeaderText = "Nome do Cliente";
            dgvCliente.Columns["cli_nome"].Width = 270;

            dgvCliente.Columns["cli_fonecelular"].HeaderText = "Telefone do Cliente";
            dgvCliente.Columns["cli_fonecelular"].Width = 137;

            //Disabilita a coluna
            dgvCliente.Columns["cli_cep"].Visible = false;
            dgvCliente.Columns["cli_endereco"].Visible = false;
            dgvCliente.Columns["cli_numero"].Visible = false;
            dgvCliente.Columns["cli_complemento"].Visible = false;
            dgvCliente.Columns["cli_bairro"].Visible = false;
            dgvCliente.Columns["cli_cidade"].Visible = false;
            dgvCliente.Columns["cli_estado"].Visible = false;
            dgvCliente.Columns["cli_email"].Visible = false;
            dgvCliente.Columns["cli_observacao"].Visible = false;
        }

        public void CarregaCliente(int codigo)
        {
            validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
            dgvCliente.DataSource = valida_cliente.CarregarCliente(codigo);
        }

        /// <summary>
        /// Metodo Botao Pesquisar;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
                dgvCliente.DataSource = valida_cliente.ListarCliente(txtPesquisaCliente.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Evento de duplo click;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvCliente.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        /// <summary>
        /// Metodo gera arquivo;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGerarArquivo_Click(object sender, EventArgs e)
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
