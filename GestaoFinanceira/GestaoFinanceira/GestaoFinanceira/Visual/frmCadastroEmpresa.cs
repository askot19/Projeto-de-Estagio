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
    public partial class frmCadastroEmpresa : MetroForm
    {
        public frmCadastroEmpresa()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo load do formulario;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCadastroEmpresa_Load(object sender, EventArgs e)
        {

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
    }
}
