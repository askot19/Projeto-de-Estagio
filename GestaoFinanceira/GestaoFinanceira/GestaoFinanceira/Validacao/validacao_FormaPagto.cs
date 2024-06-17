using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoFinanceira.Utilidade;
using GestaoFinanceira.Modelo;
using GestaoFinanceira.Negocio;
using System.Windows.Forms;
using System.Data;

namespace GestaoFinanceira.Validacao
{
    public class validacao_FormaPagto
    {
        /// <summary>
        /// Objeto de conexao com banco de dados;
        /// </summary>
        private Utilidade_Conexao conexao;

        /// <summary>
        /// Metodo Construtor da classe de valicaao;
        /// </summary>
        /// <param name="cx"></param>
        public validacao_FormaPagto(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        /// <summary>
        /// Metodo de validação salvar usuario;
        /// </summary>
        public void SalvarFormaPagto(modelo_FormaPagto modelo_formapagto)
        {
            if (modelo_formapagto.Forma_descricao.Trim().Length == 0)
            {
                MessageBox.Show("O nome da descrição é obrigatório!", "Validação Forma Pagto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            negocio_FormaPagto negocio_formapagto = new negocio_FormaPagto(conexao);
            negocio_formapagto.SalvarFormaPagto(modelo_formapagto);
        }

        /// <summary>
        /// Metodo de validação editar usuario;
        /// </summary>
        /// <param name="modelo_formapagto"></param>
        public void EditarFormaPagto(modelo_FormaPagto modelo_formapagto)
        {
            if (modelo_formapagto.Forma_id <= 0)
            {
                MessageBox.Show("O código Forma de Pagto é obrigatório!", "Validação Forma Pagto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (modelo_formapagto.Forma_descricao.Trim().Length == 0)
            {
                MessageBox.Show("O nome da Descrição é obrigatório!", "Validação Forma Pagto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            negocio_FormaPagto negocio_formapagto = new negocio_FormaPagto(conexao);
            negocio_formapagto.EditarFormaPagto(modelo_formapagto);
        }

        /// <summary>
        /// Metodo de validação excluir usuario;
        /// </summary>
        /// <param name="codigo"></param>
        public void ExcluirFormaPagto(int codigo)
        {
            negocio_FormaPagto negocio_formapagto = new negocio_FormaPagto(conexao);
            negocio_formapagto.ExcluirFormaPagto(codigo);
        }

        /// <summary>
        /// Metodo de validação listar usuario;
        /// </summary>
        /// <returns></returns>
        public DataTable ListarFormaPagto(String valor)
        {
            negocio_FormaPagto negocio_formapagto = new negocio_FormaPagto(conexao);
            return negocio_formapagto.ListarFormaPagto(valor);
        }

        /// <summary>
        /// Metodo de validação carrega usuario;
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public modelo_FormaPagto CarregarFormaPagto(int codigo)
        {
            negocio_FormaPagto negocio_formapagto = new negocio_FormaPagto(conexao);
            return negocio_formapagto.CarregarFormaPagto(codigo);
        }

        /// <summary>
        /// Metodo de negocio para realizar a verificação se ja existe um usuario gravado no banco de dados;
        /// Se retornar 0 (não existe) || Se retornar 1 (existe)
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public int VerificaFormaPagto(String valor)
        {
            negocio_FormaPagto negocio_formapagto = new negocio_FormaPagto(conexao);
            return negocio_formapagto.VerificaFormaPagto(valor);
        }
    }
}
