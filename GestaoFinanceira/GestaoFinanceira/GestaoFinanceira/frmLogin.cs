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
using MySql.Data.MySqlClient;
using MetroFramework;

namespace GestaoFinanceira
{
    public partial class frmLogin : MetroForm
    {
        /// <summary>
        /// Variavel global do formulario;
        /// </summary>
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        modelo_Usuario modelo_usuario = new modelo_Usuario();
        public static string usuario_logado;

        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo para logar no sistema;
        /// </summary>
        public void LogarSistema()
        {
            MySqlConnection cx = new MySqlConnection("server=localhost; user id=root ;database = gestaofinanceira; Password = ");
            cx.Open();

            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection conectamos = new MySqlConnection();
            cmd.Connection = cx;
            cmd.CommandText = "SELECT * FROM usuario WHERE user_usuario = @user_usuario AND user_password = @user_password";
            cmd.Parameters.Add("user_usuario", MySqlDbType.Text).Value = txtUsuario.Text;
            cmd.Parameters.Add("user_password", MySqlDbType.Text).Value = txtPassword.Text;
            MySqlDataReader leer = null;
            leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                usuario_logado = txtUsuario.Text;
                frmPrincipal f = new frmPrincipal();
                f.Show();
                this.Hide();
            }
            else
            {
                MetroMessageBox.Show(this, "\n Usuário ou senha inválido, por favor tente novamente!\n Ou entre em contato com o administrador do sistema.", 
                    "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
                txtUsuario.Focus();
            }
            cx.Close();
        }

        /// <summary>
        /// Metodo para limpar campos;
        /// </summary>
        public void LimparCampos()
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

        /// <summary>
        /// Metodo botao Sair;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Metodo load do formulario login;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Focus();
            labelVersao.Text = Application.ProductVersion;
        }

        /// <summary>
        /// Metodo botao entrar;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroMessageBox.Show(this, "\n\n O campo usuário e senha são obrigatório.", "Validação de Acesso ao Sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
                txtUsuario.Focus();
                return;
            }
            else
            {
                LogarSistema();
            }
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
