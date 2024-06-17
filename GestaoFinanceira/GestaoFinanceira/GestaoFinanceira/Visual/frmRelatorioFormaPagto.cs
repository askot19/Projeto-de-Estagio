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
    public partial class frmRelatorioFormaPagto : MetroForm
    {
        /// <summary>
        /// Variavel global da classe;
        /// </summary>
        public int codigo = 0;
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);

        public frmRelatorioFormaPagto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento load do formulario forma pagto;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRelatorioFormaPagto_Load(object sender, EventArgs e)
        {
            //Gerar arquivo WORD/PDF/EXCEL
            cmbGerarArquivo.Items.Insert(0, "");
            cmbGerarArquivo.Items.Insert(1, "Gerar Pdf");
            cmbGerarArquivo.Items.Insert(2, "Gerar Word");
            cmbGerarArquivo.Items.Insert(3, "Gerar Excel");

            //Muda a cor do DATAGRIDVIEW
            dgvFormaPagto.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvFormaPagto.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvFormaPagto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvFormaPagto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            CarregaUsuario(codigo);

            //Formata o DATAGRIDVIEW
            btnPesquisar_Click(sender, e);
            dgvFormaPagto.Columns["forma_id"].HeaderText = "Código";
            dgvFormaPagto.Columns["forma_id"].Width = 70;
            dgvFormaPagto.Columns["forma_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFormaPagto.Columns["forma_descricao"].HeaderText = "Descrição Forma de Pagto";
            dgvFormaPagto.Columns["forma_descricao"].Width = 687;
        }

        public void CarregaUsuario(int codigo)
        {
            validacao_FormaPagto valida_formapagto = new validacao_FormaPagto(conexao);
            dgvFormaPagto.DataSource = valida_formapagto.CarregarFormaPagto(codigo);
        }

        /// <summary>
        /// Metodo botao pesquisar formulario forma pagto;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_FormaPagto valida_pagto = new validacao_FormaPagto(conexao);
                dgvFormaPagto.DataSource = valida_pagto.ListarFormaPagto(txtPesquisaFormaPagto.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        /// Metodo gerar arquivos;
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

        /// <summary>
        /// Evento duplo click no data gtid view;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFormaPagto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvFormaPagto.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
