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
    public partial class frmRelatorio : MetroForm
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chama tela de Relatorio de usuario;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRelatorioUsuario_Click(object sender, EventArgs e)
        {
            frmRelatorioUsuario f = new frmRelatorioUsuario();
            f.ShowDialog();
            f.Dispose();
        }
        
        /// <summary>
        /// Chama tele de relatorio forma pagto;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFormaPagto_Click(object sender, EventArgs e)
        {
            frmRelatorioFormaPagto f = new frmRelatorioFormaPagto();
            f.ShowDialog();
            f.Dispose();
        }

        /// <summary>
        /// Chamado formualario relatorio de cliente;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRelatorioCliente_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente f = new frmRelatorioCliente();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
