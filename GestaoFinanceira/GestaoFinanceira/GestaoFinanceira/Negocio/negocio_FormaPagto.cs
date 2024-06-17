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
    public class negocio_FormaPagto
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
        public negocio_FormaPagto(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        /// <summary>
        /// Metodo para Salvar no Banco de dados;
        /// </summary>
        /// <param name="mod_usuario"></param>
        public void SalvarFormaPagto(modelo_FormaPagto mod_formapagto)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO formapagto (forma_descricao) VALUES (@descricao); SELECT @@IDENTITY";
                cmd.Parameters.AddWithValue("descricao", mod_formapagto.Forma_descricao);
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
        public void EditarFormaPagto(modelo_FormaPagto mod_formapagto)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE formapagto SET forma_descricao = @descricao WHERE forma_id = @forma_id";
                cmd.Parameters.AddWithValue("@descricao", mod_formapagto.Forma_descricao);
                cmd.Parameters.AddWithValue("@forma_id", mod_formapagto.Forma_id);
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
        public void ExcluirFormaPagto(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM formapagto WHERE forma_id = @forma_id";
                cmd.Parameters.AddWithValue("@forma_id", codigo);
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
        public DataTable ListarFormaPagto(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM formapagto WHERE forma_descricao like '%" + valor + "%'", conexao.StringConexao);
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
        public modelo_FormaPagto CarregarFormaPagto(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_FormaPagto modelo_pagto = new modelo_FormaPagto();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM formapagto WHERE forma_id = @forma_id;";
                cmd.Parameters.AddWithValue("@forma_id", codigo);
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo_pagto.Forma_id = Convert.ToInt32(registro["forma_id"]);
                    modelo_pagto.Forma_descricao = Convert.ToString(registro["forma_descricao"]);
                }
                return modelo_pagto;
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
        public int VerificaFormaPagto(String valor)
        {
            try
            {
                int r = 0;
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao.Conexao;
                comando.CommandText = "SELECT * FROM formapagto WHERE forma_descricao = @forma_descricao;";
                comando.Parameters.AddWithValue("@forma_descricao", valor);
                conexao.AbrirConexao();
                MySqlDataReader registro = comando.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["forma_id"]);
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
