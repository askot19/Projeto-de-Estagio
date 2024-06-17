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
using MetroFramework;
using GestaoFinanceira.Validacao;
using GestaoFinanceira.Modelo;
using GestaoFinanceira.Negocio;

namespace GestaoFinanceira.Visual
{
    public partial class frmCadastroCliente : MetroForm
    {
        /// <summary>
        /// Variavel global da classe;
        /// </summary>
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        utilidade_FomatarCampos utilidade_formatacampos = new utilidade_FomatarCampos();
        utilidade_ValidaCep valida_cep = new utilidade_ValidaCep();
        utilidade_ValidaCpf valida_cpf = new utilidade_ValidaCpf();
        public string usario, operacao;

        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Verifica se já existe um usuario no banco de dados;
        /// </summary>
        /// <param name="Usuario"></param>
        public void VerificaCpf(String Usuario)
        {
            string cpfFormat = txtCpf.Text;
            int r = 0;
            validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
            r = valida_cliente.VerificaCliente(txtCpf.Text);
            if (r > 0)
            {
                MetroMessageBox.Show(this, "\n\n Já existe o CPF: "+ cpfFormat +" cadastrado no banco de dados!", "VERIFICACAO DE CPF",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpf.Text = "";
                txtCpf.Focus();
            }
        }

        /// <summary>
        /// Função altera estados dos botões;
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
            txtDataCadastro.Enabled = true;
            txtCpf.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtCep.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            txtObervacao.Enabled = true;
        }

        /// <summary>
        /// Função desabibilita campos do formulario;
        /// </summary>
        public void DesabilitaCampos()
        {
            txtDataCadastro.Enabled = false;
            txtCpf.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtCep.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            txtObervacao.Enabled = false;
        }

        /// <summary>
        /// Metodo limpar campos do textbox;
        /// </summary>
        public void LimpaCampos()
        {
            txtCodigo.Text = "";
            txtDataCadastro.Text = "";
            txtCpf.Text = "";
            txtNomeCliente.Text = "";
            txtCep.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtObervacao.Text = "";
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
        /// Metodo load do formulario de cadastro de cliente;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.labelCpfInvalido.Visible = false;
            this.DesabilitaCampos();
            this.AlteraBotao(1);
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
            this.txtDataCadastro.Focus();
        }

        /// <summary>
        /// Metodo botao Excluir;
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
                    validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
                    valida_cliente.ExcluirCliente(Convert.ToInt32(txtCodigo.Text));
                    MetroMessageBox.Show(this, "\n Cliente Excluido com sucesso!", "EXCLUSÂO DE CLEINTE",
                       MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlteraBotao(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n\n Impossivel excluir cliente do banco de dados. \n Detalhes:" + ex.Message,
                   "ERROR AO EXCLUIR CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtDataCadastro.Focus();
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
                modelo_Cliente modelo_cliente = new modelo_Cliente();
                modelo_cliente.Cli_cpf = txtCpf.Text;
                modelo_cliente.Cli_nome = txtNomeCliente.Text;
                modelo_cliente.Cli_dtCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                modelo_cliente.Cli_cep = txtCep.Text;
                modelo_cliente.Cli_endereco = txtEndereco.Text;
                modelo_cliente.Cli_numero = Convert.ToInt32(txtNumero.Text);
                modelo_cliente.Cli_complemento = txtComplemento.Text;
                modelo_cliente.Cli_bairro = txtBairro.Text;
                modelo_cliente.Cli_cidade = txtCidade.Text;
                modelo_cliente.Cli_estado = txtEstado.Text;
                modelo_cliente.Cli_fonecelular = txtTelefone.Text;
                modelo_cliente.Cli_email = txtEmail.Text;
                modelo_cliente.Cli_observacao = txtObervacao.Text;
                validacao_Cliente validacao_cliente = new validacao_Cliente(conexao);
                if (operacao == "cadastrar")
                {
                    validacao_cliente.SalvarCliente(modelo_cliente);
                    MetroMessageBox.Show(this, "\n Cliente cadastrado com sucesso!", "CADASTRO DE CLIENTE",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
                else 
                {
                    modelo_cliente.Cli_id = Convert.ToInt32(txtCodigo.Text);
                    validacao_cliente.EditarCliente(modelo_cliente);
                    MetroMessageBox.Show(this, "\n Cleinte Editado com sucesso!", "CLIENTE EDITADO",
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
        /// Metodo botao Pesquisar;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente fRelatorioCliente = new frmRelatorioCliente();
            fRelatorioCliente.ShowDialog();
            if (fRelatorioCliente.codigo != 0)
            {
                validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
                modelo_Cliente modelo_cliente = valida_cliente.CarregarCliente(fRelatorioCliente.codigo);
                txtCodigo.Text = modelo_cliente.Cli_id.ToString();
                txtDataCadastro.Text = modelo_cliente.Cli_dtCadastro.ToShortDateString();
                txtCpf.Text = modelo_cliente.Cli_cpf;
                txtNomeCliente.Text = modelo_cliente.Cli_nome;
                txtCep.Text = modelo_cliente.Cli_cep;
                txtEndereco.Text = modelo_cliente.Cli_endereco;
                txtNumero.Text = modelo_cliente.Cli_numero.ToString();
                txtComplemento.Text = modelo_cliente.Cli_complemento;
                txtBairro.Text = modelo_cliente.Cli_bairro;
                txtCidade.Text = modelo_cliente.Cli_cidade;
                txtEstado.Text = modelo_cliente.Cli_estado;
                txtTelefone.Text = modelo_cliente.Cli_fonecelular;
                txtEmail.Text = modelo_cliente.Cli_email;
                txtObervacao.Text = modelo_cliente.Cli_observacao;
                AlteraBotao(3);
            }
            else
            {
                LimpaCampos();
                txtDataCadastro.Focus();
                AlteraBotao(1);
            }
            fRelatorioCliente.Dispose();
        }

        /// <summary>
        /// Evento KeyPress cep;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                utilidade_FomatarCampos.Campos edit = utilidade_FomatarCampos.Campos.CEP;
                utilidade_formatacampos.Maskara(edit, txtCep);
            }
        }

        /// <summary>
        /// Evento KeyPress CPF;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                utilidade_FomatarCampos.Campos edit = utilidade_FomatarCampos.Campos.CPF;
                utilidade_formatacampos.Maskara(edit, txtCpf);
            }
        }

        /// <summary>
        /// Evento KeuPress DATA de CADASTRO;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDataCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                utilidade_FomatarCampos.Campos edit = utilidade_FomatarCampos.Campos.DATA;
                utilidade_formatacampos.Maskara(edit, txtDataCadastro);
            }
        }

        /// <summary>
        /// Evento KeyPress Telefone;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                utilidade_FomatarCampos.Campos edit = utilidade_FomatarCampos.Campos.TELEFONE;
                utilidade_formatacampos.Maskara(edit, txtTelefone);
            }
        }

        /// <summary>
        /// Evento leave do cep;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (valida_cep.verificaCEP(txtCep.Text) == true)
            {
                txtBairro.Text = utilidade_ValidaCep.bairro;
                txtEstado.Text = utilidade_ValidaCep.estado;
                txtCidade.Text = utilidade_ValidaCep.cidade;
                txtEndereco.Text = utilidade_ValidaCep.endereco;
                txtComplemento.Text = utilidade_ValidaCep.complemento;
            }
        }

        /// <summary>
        /// Evento Leave do txtCPF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCpf_Leave(object sender, EventArgs e)
        {
            VerificaCpf(usario);
            if (txtCpf.Visible == true)
            {
                if (valida_cpf.ValidaCPF(txtCpf.Text) == false)
                {
                    labelCpfInvalido.Visible = true;
                }
            }
            if (txtCpf.Text == "")
            {
                labelCpfInvalido.Visible = false;
            }
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
            this.AlteraBotao(2);
            this.txtDataCadastro.Focus();
        }
    }
}
