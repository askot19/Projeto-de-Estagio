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
    public partial class frmCalculaJurosSimples : MetroForm
    {
        /*
        * FORMULAR PARA CALCULAR JUROS SIMPLES.
        * M = P.(1+(I.N))
        * M = MONTANTE => RESULTADO ESPERANDO
        * P = VALOR PRESENTE (PRINCIPAL, BASE PARA O CALCULO)
        * I = TAXA
        * N = PERIODO
        */

        public frmCalculaJurosSimples()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo botao limpar;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo botao limpar campos;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            this.txtValorParcela.Text = "";
            this.txtValorPagar.Text = "";
            this.txtTaxaJuros.Text = "";
            this.txtDiasAtraso.Text = "";
        }

        /// <summary>
        /// Metodo botao calular;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double M;
            Double P = Convert.ToDouble(txtValorParcela.Text);
            Double I = Convert.ToDouble(txtTaxaJuros.Text) / 100;
            Double N = Convert.ToDouble(txtDiasAtraso.Text);

            M = P * (1 + (I * (N / 30)));

            txtValorPagar.Text = M.ToString("C");
        }

        /// <summary>
        /// Evento formatação de campos;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtValorParcela_Leave(object sender, EventArgs e)
        {
            if (txtValorParcela.Text.Contains(",") == false)
            {
                txtValorParcela.Text += ",00";
            }
            else
            {
                if (txtValorParcela.Text.IndexOf(",") == txtValorParcela.Text.Length - 1)
                {
                    txtValorParcela.Text += "00";
                }
            }
        }

        /// <summary>
        /// Evento KeyPess 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtValorParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorParcela.Text.Contains("."))
                {
                    e.KeyChar = ',';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Evento KeyDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCalculaJurosSimples_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        /// <summary>
        /// Evento Leave do Valor a Pagar;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtValorPagar_Leave(object sender, EventArgs e)
        {
            if (txtValorPagar.Text.Contains(",") == false)
            {
                txtValorPagar.Text += ",00";
            }
            else
            {
                if (txtValorPagar.Text.IndexOf(",") == txtValorPagar.Text.Length - 1)
                {
                    txtValorPagar.Text += "00";
                }
            }
        }

        /// <summary>
        /// Evento KeyPress Valor a Pagar;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtValorPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorPagar.Text.Contains("."))
                {
                    e.KeyChar = ',';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
