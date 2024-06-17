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
using GestaoFinanceira.Visual;
using MetroFramework;
using System.Diagnostics;

namespace GestaoFinanceira
{
    public partial class frmPrincipal : MetroForm
    {
        /// <summary>
        /// Variavel Global da classe;
        /// </summary>
        frmLogin flogin = new frmLogin();
        private string data = "Data.: " + DateTime.Now.ToShortDateString();
        Timer t = new Timer();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo load do formulario;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (frmLogin.usuario_logado == "Silvanei")
            {
                AutorizacaoUsuario();
            }
            Data();
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer_Tick);
            t.Start();
            CarregaUsuarioLogado();
        }

        /// <summary>
        /// Metodo data no sistema;
        /// </summary>
        public void Data()
        {
            labelData.Text = data;
        }
        
        /// <summary>
        /// Metodo autorizacao adminstrativa
        /// </summary>
        public void AutorizacaoUsuario()
        {
            btnConfiguracao.Visible = true;
        }

        /// <summary>
        /// Metodo carrega usuario logado;
        /// </summary>
        private void CarregaUsuarioLogado()
        {
            labelUsuarioConectado.Text = frmLogin.usuario_logado;
        }

        /// <summary>
        /// Chama tela de cadastros;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro f = new frmCadastro();
            f.ShowDialog();
            f.Dispose();
        }

        /// <summary>
        /// Chama tela de Relatorio;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorio f = new frmRelatorio();
            f.ShowDialog();
            f.Dispose();
        }

        /// <summary>
        /// Chama formular Calcula Juros Simples;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculaJuros_Click(object sender, EventArgs e)
        {
            frmCalculaJurosSimples f = new frmCalculaJurosSimples();
            f.ShowDialog();
            f.Dispose();
        }

        /// <summary>
        /// Evento FormClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Metodo botao sair;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "\n\n Realmente desejar sair do sistema? ", 
                "Abondonar o sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Metodo chama calculadora do windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCaculadora_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        /// <summary>
        /// Metodo chama programa word;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWord_Click(object sender, EventArgs e)
        {
            Process.Start("winword");
        }

        /// <summary>
        /// MEtodo chama excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Process.Start("excel");
        }

        /// <summary>
        /// Metodo chama bloco de nota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlocoNota_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        /// <summary>
        /// Metodo para trazer hora;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string time = "";
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            labelHora.Text = "Hora.: " + time;
        }

        /// <summary>
        /// Chama formulario de Impressão;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImpressao_Click(object sender, EventArgs e)
        {
            frmImpressao f = new frmImpressao();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
