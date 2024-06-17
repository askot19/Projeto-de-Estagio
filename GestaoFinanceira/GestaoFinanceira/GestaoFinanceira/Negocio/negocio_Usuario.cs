using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoFinanceira.Utilidade;
using GestaoFinanceira.Modelo;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace GestaoFinanceira.Negocio
{
    public class negocio_Usuario
    {
        /// <summary>
        /// Variavel da Classe;
        /// </summary>
        private Utilidade_Conexao conexao;
        MySqlCommand comando = null;
        
        /// <summary>
        /// Metodo Construtor da conexao;
        /// </summary>
        /// <param name="cx"></param>
        public negocio_Usuario(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        /// <summary>
        /// Metodo para Salvar no Banco de dados;
        /// </summary>
        /// <param name="mod_usuario"></param>
        public void SalvarUsuario(modelo_Usuario mod_usuario)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO usuario (user_usuario, user_password) VALUES (@user_usuario, @user_password); SELECT @@IDENTITY";
                cmd.Parameters.AddWithValue("user_usuario", mod_usuario.User_usuario);
                cmd.Parameters.AddWithValue("user_password", mod_usuario.User_password);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco com dados", "Gravar" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FercharConexao();
            }
        }

        /// <summary>
        /// Metodo para Editar no Banco de dados;
        /// </summary>
        /// <param name="usuario"></param>
        public void EditarUsuario(modelo_Usuario usuario)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE usuario SET user_usuario = @user_usuario, user_password = @user_password WHERE user_id = @user_id";
                cmd.Parameters.AddWithValue("@user_usuario", usuario.User_usuario);
                cmd.Parameters.AddWithValue("@user_password", usuario.User_password);
                cmd.Parameters.AddWithValue("@user_id", usuario.User_id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Editar" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FercharConexao();
            }
        }

        /// <summary>
        /// Metodo para Excluir no Banco de dados;
        /// </summary>
        /// <param name="codigo"></param>
        public void ExcluirUsuario(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM usuario WHERE user_id = @user_id";
                cmd.Parameters.AddWithValue("@user_id", codigo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Excluir" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FercharConexao();
            }
        }

        /// <summary>
        /// Metodo para Filtrar Usuario do Banco de dados;
        /// </summary>
        /// <returns></returns>
        public DataTable ListarUsuario(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM usuario WHERE user_usuario like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo para preecher data grid view do Banco de dados;
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public modelo_Usuario CarregarUsuario(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Usuario usuario = new modelo_Usuario();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM usuario WHERE user_id = @user_id;";
                cmd.Parameters.AddWithValue("@user_id", codigo);
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    usuario.User_id = Convert.ToInt32(registro["user_id"]);
                    usuario.User_usuario = Convert.ToString(registro["user_usuario"]);
                    usuario.User_password = Convert.ToString(registro["user_password"]);
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.FercharConexao();
            }
        }

        /// <summary>
        /// Metodo de negocio para realizar a verificação se ja existe um usuario gravado no banco de dados;
        /// Se retornar 0 (não existe) || Se retornar 1 (existe)
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public int VerificaUsuario(String valor)
        {
            try
            {
                int r = 0;
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao.Conexao;
                comando.CommandText = "SELECT * FROM usuario WHERE user_usuario = @user_usuario;";
                comando.Parameters.AddWithValue("@user_usuario", valor);
                conexao.AbrirConexao();
                MySqlDataReader registro = comando.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["user_id"]);
                }
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.FercharConexao();
            }
        }
    }
}
