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
using GestaoFinanceira.Modelo;
using GestaoFinanceira.Negocio;
using MetroFramework;
using GestaoFinanceira.Validacao;

namespace GestaoFinanceira.Visual
{
    public partial class frmCadastroUsuario : MetroForm
    {
        /// <summary>
        /// Variavel Global da Classe
        /// </summary>
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        private string usuario, operacao;

        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Função altera estados dos botões
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
        /// Metodo que verifica usuario cadastrado no banco de dados;
        /// </summary>
        /// <param name="usuario"></param>
        public void VerificaUsuario(String usuario)
        {
            int r = 0;
            if(this.operacao == "cadastrar")
            {
                validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
                r = valida_usuario.VerificaUsuario(txtUsuario.Text);
                if (r > 0)
                {
                    MetroMessageBox.Show(this, "\n\n Já existe um usuário cadastrado no banco de dados!", "VERIFICACAO DE USUÁRIO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpaCampos();
                    txtUsuario.Focus();
                }
            }
        }

        /// <summary>
        /// Função habilita campos do formulario;
        /// </summary>
        public void HabilitaCampos()
        {
            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
        }

        /// <summary>
        /// Função desabibilita campos do formulario;
        /// </summary>
        public void DesabilitaCampos()
        {
            txtUsuario.Enabled = false;
            txtPassword.Enabled = false;
        }
        
        /// <summary>
        /// Metodo limpar campos do textbox;
        /// </summary>
        public void LimpaCampos()
        {
            txtCodigo.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

        /// <summary>
        /// Metodo Botão voltar;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo load do formulario cadastro de usuario;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlteraBotao(1);
        }

        /// <summary>
        /// Metodo botao novo formulario cadastro de usuario;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.HabilitaCampos();
            this.AlteraBotao(2);
            this.txtUsuario.Focus();
        }

        /// <summary>
        /// Metodo botao editar formulario cadastro de usuario;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlteraBotao(2);
            this.txtUsuario.Focus();
        }

        /// <summary>
        /// Metodo do gravar do formulario de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Usuario mod_usuario = new modelo_Usuario();
                mod_usuario.User_usuario = txtUsuario.Text;
                mod_usuario.User_password = txtPassword.Text;
                validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
                if (operacao == "cadastrar")
                {
                    valida_usuario.SalvarUsuario(mod_usuario);
                    MetroMessageBox.Show(this, "\n Usário cadastrado com sucesso!", "CADASTRO DE USUÁRIO", 
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
                else
                {
                    mod_usuario.User_id = Convert.ToInt32(txtCodigo.Text);
                    valida_usuario.EditarUsuario(mod_usuario);
                    MetroMessageBox.Show(this, "\n Usário Editado com sucesso!", "USUÁRIO EDITADO",
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
        /// Metodo do excluir do formulario de usuario
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
                    validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
                    valida_usuario.ExcluirUsuario(Convert.ToInt32(txtCodigo.Text));
                    MetroMessageBox.Show(this, "\n Usário Excluido com sucesso!", "EXCLUSÂO DE USUÁRIO",
                       MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlteraBotao(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n\n Impossivel excluir usuário do banco de dados. \n Detalhes:" + ex.Message,
                   "ERROR AO EXCLUIR USUÁRIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsuario.Focus();
                this.AlteraBotao(3);
            }
        }

        /// <summary>
        /// Metodo do botao pesquisar do formulario de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmRelatorioUsuario fRelatorioUsuario = new frmRelatorioUsuario();
            fRelatorioUsuario.ShowDialog();
            if (fRelatorioUsuario.codigo != 0)
            {
                validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
                modelo_Usuario modelo_usuario = valida_usuario.CarregarUsuario(fRelatorioUsuario.codigo);
                txtCodigo.Text = modelo_usuario.User_id.ToString();
                txtUsuario.Text = modelo_usuario.User_usuario;
                txtPassword.Text = modelo_usuario.User_password;
                AlteraBotao(3);
            }
            else
            {
                LimpaCampos();
                txtUsuario.Focus();
                AlteraBotao(1);
            }
            fRelatorioUsuario.Dispose();
        }

        /// <summary>
        /// Metodo para pular para outro textbox;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        /// <summary>
        /// Evento que verifica usuario no banco de dados;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            VerificaUsuario(usuario);
        }

        /// <summary>
        /// Metodo Botao Cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
            //this.txtUsuario.Focus();
            this.DesabilitaCampos();
            this.AlteraBotao(1);
        }
    }
}
