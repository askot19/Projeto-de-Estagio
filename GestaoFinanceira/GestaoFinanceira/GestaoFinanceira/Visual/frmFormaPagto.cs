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
using GestaoFinanceira.Modelo;
using MetroFramework;

namespace GestaoFinanceira.Visual
{
    public partial class frmFormaPagto : MetroForm
    {
        /// <summary>
        /// Variavel global do formulario;
        /// </summary>
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        private string usuario, operacao;

        public frmFormaPagto()
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
        /// Metodo para alterar estados botoes;
        /// </summary>
        /// <param name="op"></param>
        public void AlteraBotao(int op)
        {
            btnVoltar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = false;

            if (op == 1)
            {
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
                btnVoltar.Enabled = true;
            }
            if (op == 2)
            {
                btnGravar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        /// <summary>
        /// Função habilita campos do formulario;
        /// </summary>
        public void HabilitaCampos()
        {
            txtFormaPagto.Enabled = true;
        }

        /// <summary>
        /// Função desabibilita campos do formulario;
        /// </summary>
        public void DesabilitaCampos()
        {
            txtFormaPagto.Enabled = false;
        }

        /// <summary>
        /// Metodo load do formulario;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFormaPagto_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlteraBotao(1);
        }

        /// <summary>
        /// Metodo botao novo;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.HabilitaCampos();
            this.txtFormaPagto.Focus();
            this.AlteraBotao(2);
        }

        /// <summary>
        /// Metodo botao cancelar;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
            this.DesabilitaCampos();
            this.AlteraBotao(1);
        }

        /// <summary>
        /// Metodo botao editar;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlteraBotao(2);
            this.txtFormaPagto.Focus();
        }

        /// <summary>
        /// Metodo botao excluir;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MetroMessageBox.Show(this, "\n\n Deseja realmente EXCLUIR o registro selecionado", "CONFIRMA A EXCLUSÂO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (resultado.ToString() == "Yes")
                {
                    validacao_FormaPagto valida_formapagto = new validacao_FormaPagto(conexao);
                    valida_formapagto.ExcluirFormaPagto(Convert.ToInt32(txtCodigo.Text));
                    MetroMessageBox.Show(this, "\n Forma de Pagto Excluido com sucesso!", "EXCLUSÂO DE FORMA PAGTO",
                       MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlteraBotao(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n\n Impossivel excluir forma pagto do banco de dados. \n Detalhes:" + ex.Message,
                   "ERROR AO EXCLUIR USUÁRIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtFormaPagto.Focus();
                this.AlteraBotao(3);
            }
        }

        /// <summary>
        /// Metodo botao gravar;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_FormaPagto modelo_formpagto = new modelo_FormaPagto();
                modelo_formpagto.Forma_descricao = txtFormaPagto.Text;
                validacao_FormaPagto valida_formapagto = new validacao_FormaPagto(conexao);
                if (operacao == "cadastrar")
                {
                    valida_formapagto.SalvarFormaPagto(modelo_formpagto);
                    MetroMessageBox.Show(this, "\n Forma de pagto cadastrado com sucesso!", "CADASTRO DE FORMA PAGTO",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
                else
                {
                    modelo_formpagto.Forma_id = Convert.ToInt32(txtCodigo.Text);
                    valida_formapagto.EditarFormaPagto(modelo_formpagto);
                    MetroMessageBox.Show(this, "\n Forma de pagto editado com sucesso!", "EDITAR FORMA PAGTO",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                this.LimpaCampos();
                this.AlteraBotao(1);
                this.DesabilitaCampos();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n\n Não foi possivel efeturar a operação realizada. \n Detalhes:" + ex.Message,
                    "ERROR AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conexao.FercharConexao();
            }
        }

        /// <summary>
        /// Metodo botao pesquisar;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmRelatorioFormaPagto fRelatorioFormaPagto = new frmRelatorioFormaPagto();
            fRelatorioFormaPagto.ShowDialog();
            if (fRelatorioFormaPagto.codigo != 0)
            {
                validacao_FormaPagto valida_formapagto = new validacao_FormaPagto(conexao);
                modelo_FormaPagto modelo_formapagto = valida_formapagto.CarregarFormaPagto(fRelatorioFormaPagto.codigo);
                txtCodigo.Text = modelo_formapagto.Forma_id.ToString();
                txtFormaPagto.Text = modelo_formapagto.Forma_descricao;
                AlteraBotao(3);
            }
            else
            {
                LimpaCampos();
                txtFormaPagto.Focus();
                AlteraBotao(1);
            }
            fRelatorioFormaPagto.Dispose();
        }

        /// <summary>
        /// Metodo limpar campos do textbox;
        /// </summary>
        public void LimpaCampos()
        {
            txtCodigo.Text = "";
            txtFormaPagto.Text = "";
        }
    }
}
