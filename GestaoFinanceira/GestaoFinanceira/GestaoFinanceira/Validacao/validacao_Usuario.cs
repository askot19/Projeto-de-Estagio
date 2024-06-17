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
    public class validacao_Usuario
    {
        /// <summary>
        /// Objeto de conexao com banco de dados;
        /// </summary>
        private Utilidade_Conexao conexao;
       
        public validacao_Usuario(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        /// <summary>
        /// Metodo de validação salvar usuario;
        /// </summary>
        public void SalvarUsuario(modelo_Usuario usuaio)
        {
            if (usuaio.User_usuario.Trim().Length == 0)
            {
                MessageBox.Show("O nome do usuário é obrigatório!", "Validação Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (usuaio.User_password.Trim().Length == 0)
            {
                MessageBox.Show("O password do usuário é obrigatório!", "Validação Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            negocio_Usuario negocio_usuario = new negocio_Usuario(conexao);
            negocio_usuario.SalvarUsuario(usuaio);
        }

        /// <summary>
        /// Metodo de validação editar usuario;
        /// </summary>
        /// <param name="mod_usuaio"></param>
        public void EditarUsuario(modelo_Usuario usuaio)
        {
            if (usuaio.User_id <= 0)
            {
                MessageBox.Show("O código do usuário é obrigatório!", "Validação Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (usuaio.User_usuario.Trim().Length == 0)
            {
                MessageBox.Show("O nome do usuário é obrigatório!", "Validação Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (usuaio.User_password.Trim().Length == 0)
            {
                MessageBox.Show("O password do usuário é obrigatório!", "Validação Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            negocio_Usuario negocio_usuario = new negocio_Usuario(conexao);
            negocio_usuario.EditarUsuario(usuaio);
        }

        /// <summary>
        /// Metodo de validação excluir usuario;
        /// </summary>
        /// <param name="mod_usuaio"></param>
        public void ExcluirUsuario(int codigo)
        {
            negocio_Usuario negocio_usuario = new negocio_Usuario(conexao);
            negocio_usuario.ExcluirUsuario(codigo);
        }

        /// <summary>
        /// Metodo de validação listar usuario;
        /// </summary>
        /// <returns></returns>
        public DataTable ListarUsuario(String valor)
        {
            negocio_Usuario negocio_usuario = new negocio_Usuario(conexao);
            return negocio_usuario.ListarUsuario(valor);
        }

        /// <summary>
        /// Metodo de validação carrega usuario;
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public modelo_Usuario CarregarUsuario(int codigo)
        {
            negocio_Usuario negocio_usuario = new negocio_Usuario(conexao);
            return negocio_usuario.CarregarUsuario(codigo);
        }

        /// <summary>
        /// Metodo de negocio para realizar a verificação se ja existe um usuario gravado no banco de dados;
        /// Se retornar 0 (não existe) || Se retornar 1 (existe)
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public int VerificaUsuario(String valor)
        {
            negocio_Usuario negocio_Usuario = new negocio_Usuario(conexao);
            return negocio_Usuario.VerificaUsuario(valor);
        }
    }
}
