using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoFinanceira.Utilidade;
using MySql.Data.MySqlClient;
using GestaoFinanceira.Modelo;
using System.Windows.Forms;
using System.Data;

namespace GestaoFinanceira.Negocio
{
    public class negocio_Cliente
    {
        /// <summary>
        /// Variavel global da classe;
        /// </summary>
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        MySqlCommand cmd = null;

        /// <summary>
        /// Metodo construtor da classe;
        /// </summary>
        /// <param name="cx"></param>
        public negocio_Cliente(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        /// <summary>
        /// Metodo gravar cliente;
        /// </summary>
        /// <param name="modelo_cliente"></param>
        public void SalvarCliente(modelo_Cliente modelo_cliente)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO cliente (cli_dtCadastro, cli_cpf, cli_nome,cli_cep, cli_endereco, cli_numero, cli_complemento, cli_bairro, cli_cidade, cli_estado, cli_email, cli_foneCelular, cli_observacao) " +
                    "VALUES ( @cli_dtCadastro, @cli_cpf, @cli_nome, @cli_cep, @cli_endereco, @cli_numero, @cli_complemento, @cli_bairro, @cli_cidade, @cli_estado, @cli_email, @cli_foneCelular, @cli_observacao); SELECT @@IDENTITY";
                cmd.Parameters.AddWithValue("cli_dtCadastro", modelo_cliente.Cli_dtCadastro);
                cmd.Parameters.AddWithValue("cli_cpf", modelo_cliente.Cli_cpf);
                cmd.Parameters.AddWithValue("cli_nome", modelo_cliente.Cli_nome);
                cmd.Parameters.AddWithValue("cli_cep", modelo_cliente.Cli_cep);
                cmd.Parameters.AddWithValue("cli_endereco", modelo_cliente.Cli_endereco);
                cmd.Parameters.AddWithValue("cli_numero", modelo_cliente.Cli_numero);
                cmd.Parameters.AddWithValue("cli_complemento", modelo_cliente.Cli_complemento);
                cmd.Parameters.AddWithValue("cli_bairro", modelo_cliente.Cli_bairro);
                cmd.Parameters.AddWithValue("cli_cidade", modelo_cliente.Cli_cidade);
                cmd.Parameters.AddWithValue("cli_estado", modelo_cliente.Cli_estado);
                cmd.Parameters.AddWithValue("cli_email", modelo_cliente.Cli_email);
                cmd.Parameters.AddWithValue("cli_foneCelular", modelo_cliente.Cli_fonecelular);
                cmd.Parameters.AddWithValue("cli_observacao", modelo_cliente.Cli_observacao);
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
        /// Metodo editar cliente
        /// </summary>
        /// <param name="modelo_cliente"></param>
        public void EditarCliente(modelo_Cliente modelo_cliente)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE cliente SET cli_cpf = @cli_cpf, cli_nome = @cli_nome, cli_dtCadastro = @cli_dtCadastro, cli_cep = @cli_cep," +
                    "cli_endereco = @cli_endereco, cli_numero = @cli_numero, cli_complemento = @cli_complemento, cli_bairro = @cli_bairro,"+
                    "cli_cidade = @cli_cidade, cli_estado = @cli_estado, cli_email = @cli_email, cli_foneCelular = @cli_foneCelular,"+
                    "cli_observacao = @cli_observacao WHERE cli_id = @cli_id";
                cmd.Parameters.AddWithValue("cli_cpf", modelo_cliente.Cli_cpf);
                cmd.Parameters.AddWithValue("cli_nome", modelo_cliente.Cli_nome);
                cmd.Parameters.AddWithValue("cli_dtCadastro", modelo_cliente.Cli_dtCadastro);
                cmd.Parameters.AddWithValue("cli_cep", modelo_cliente.Cli_cep);
                cmd.Parameters.AddWithValue("cli_endereco", modelo_cliente.Cli_endereco);
                cmd.Parameters.AddWithValue("cli_numero", modelo_cliente.Cli_numero);
                cmd.Parameters.AddWithValue("cli_complemento", modelo_cliente.Cli_complemento);
                cmd.Parameters.AddWithValue("cli_bairro", modelo_cliente.Cli_bairro);
                cmd.Parameters.AddWithValue("cli_cidade", modelo_cliente.Cli_cidade);
                cmd.Parameters.AddWithValue("cli_estado", modelo_cliente.Cli_estado);
                cmd.Parameters.AddWithValue("cli_email", modelo_cliente.Cli_email);
                cmd.Parameters.AddWithValue("cli_foneCelular", modelo_cliente.Cli_fonecelular);
                cmd.Parameters.AddWithValue("cli_observacao", modelo_cliente.Cli_observacao);
                cmd.Parameters.AddWithValue("cli_id", modelo_cliente.Cli_id);
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
        /// Metodo excluir cliente;
        /// </summary>
        /// <param name="codigo"></param>
        public void ExcluirCliente(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM cliente WHERE cli_id = @cli_id";
                cmd.Parameters.AddWithValue("@cli_id", codigo);
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
        /// Metodo listar cliente no banco de dados;
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public DataTable ListarCliente(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM cliente WHERE cli_nome like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Carrega cliente no data grid view;
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public modelo_Cliente CarregarCliente(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Cliente modelo_cliente = new modelo_Cliente();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM cliente WHERE cli_id = @cli_id;";
                cmd.Parameters.AddWithValue("@cli_id", codigo);
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo_cliente.Cli_id = Convert.ToInt32(registro["cli_id"]);
                    modelo_cliente.Cli_cpf = Convert.ToString(registro["cli_cpf"]);
                    modelo_cliente.Cli_nome = Convert.ToString(registro["cli_nome"]);
                    modelo_cliente.Cli_dtCadastro = Convert.ToDateTime(registro["cli_dtCadastro"]);
                    modelo_cliente.Cli_cep = Convert.ToString(registro["cli_cep"]);
                    modelo_cliente.Cli_endereco = Convert.ToString(registro["cli_endereco"]);
                    modelo_cliente.Cli_numero = Convert.ToInt32(registro["cli_numero"]);
                    modelo_cliente.Cli_complemento = Convert.ToString(registro["cli_complemento"]);
                    modelo_cliente.Cli_bairro = Convert.ToString(registro["cli_bairro"]);
                    modelo_cliente.Cli_cidade = Convert.ToString(registro["cli_cidade"]);
                    modelo_cliente.Cli_estado = Convert.ToString(registro["cli_estado"]);
                    modelo_cliente.Cli_email = Convert.ToString(registro["cli_email"]);
                    modelo_cliente.Cli_fonecelular = Convert.ToString(registro["cli_foneCelular"]);
                    modelo_cliente.Cli_observacao = Convert.ToString(registro["cli_observacao"]);
                }
                return modelo_cliente;
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
        public int VerificaCliente(String valor)
        {
            try
            {
                int r = 0;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM cliente WHERE cli_cpf = @cli_cpf;";
                cmd.Parameters.AddWithValue("@cli_cpf", valor);
                conexao.AbrirConexao();
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["cli_id"]);
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
