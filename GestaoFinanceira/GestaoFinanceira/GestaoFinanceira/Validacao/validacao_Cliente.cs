using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoFinanceira.Utilidade;
using GestaoFinanceira.Modelo;
using System.Windows.Forms;
using GestaoFinanceira.Negocio;
using System.Data;

namespace GestaoFinanceira.Validacao
{
    public class validacao_Cliente
    {
        /// <summary>
        /// Objeto de conexao com banco de dados;
        /// </summary>
        private Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);

        /// <summary>
        /// Metodo construtor da classe;
        /// </summary>
        /// <param name="cx"></param>
        public validacao_Cliente(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        /// <summary>
        /// Metodo de validação salvar usuario;
        /// </summary>
        public void SalvarCliente(modelo_Cliente modelo_cliente)
        {
            if (modelo_cliente.Cli_nome.Trim().Length == 0)
            {
                MessageBox.Show("O nome do cliente é obrigatório!", "Validação Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            negocio_cliente.SalvarCliente(modelo_cliente);
        }

        /// <summary>
        /// Metodo de validação editar usuario;
        /// </summary>
        /// <param name="modelo_cliente"></param>
        public void EditarCliente(modelo_Cliente modelo_cliente)
        {
            if (modelo_cliente.Cli_id <= 0)
            {
                MessageBox.Show("O código do cliente é obrigatório!", "Validação Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (modelo_cliente.Cli_nome.Trim().Length == 0)
            {
                MessageBox.Show("O nome do cliente é obrigatório!", "Validação Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            negocio_cliente.EditarCliente(modelo_cliente);
        }

        /// <summary>
        /// Metodo de validação excluir usuario;
        /// </summary>
        /// <param name="codigo"></param>
        public void ExcluirCliente(int codigo)
        {
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            negocio_cliente.ExcluirCliente(codigo);
        }

        /// <summary>
        /// Metodo de validação listar usuario;
        /// </summary>
        /// <returns></returns>
        public DataTable ListarCliente(String valor)
        {
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            return negocio_cliente.ListarCliente(valor);
        }

        /// <summary>
        /// Metodo de validação carrega usuario;
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public modelo_Cliente CarregarCliente(int codigo)
        {
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            return negocio_cliente.CarregarCliente(codigo);
        }

        /// <summary>
        /// Metodo de negocio para realizar a verificação se ja existe um usuario gravado no banco de dados;
        /// Se retornar 0 (não existe) || Se retornar 1 (existe)
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public int VerificaCliente(String valor)
        {
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            return negocio_cliente.VerificaCliente(valor);
        }
    }
}
