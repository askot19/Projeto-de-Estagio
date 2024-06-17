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

namespace GestaoFinanceira.Visual
{
    public partial class frmCadastro : MetroForm
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chama formulario de cadastro de usuário;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario f = new frmCadastroUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        /// <summary>
        /// Chama formulario de cadastro forma de pagto;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFormaPagto_Click(object sender, EventArgs e)
        {
            frmFormaPagto f = new frmFormaPagto();
            f.ShowDialog();
            f.Dispose();
        }

        /// <summary>
        /// Chama formulario de cadastro cliente;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

        /// <summary>
        /// Chama formulario de cadastro de empresa;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastroEmpresa_Click(object sender, EventArgs e)
        {
            frmCadastroEmpresa f = new frmCadastroEmpresa();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
