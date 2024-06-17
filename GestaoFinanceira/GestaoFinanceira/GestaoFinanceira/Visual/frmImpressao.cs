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
using GestaoFinanceira.Relatorio;

namespace GestaoFinanceira.Visual
{
    public partial class frmImpressao : MetroForm
    {
        public frmImpressao()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chama formulario de impressão;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImpressaoUsuario_Click(object sender, EventArgs e)
        {
            frmImpresaoCadastroUsuario f = new frmImpresaoCadastroUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnImpressaoCliente_Click(object sender, EventArgs e)
        {
            frmImpressaoCadastroCliente f = new frmImpressaoCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
