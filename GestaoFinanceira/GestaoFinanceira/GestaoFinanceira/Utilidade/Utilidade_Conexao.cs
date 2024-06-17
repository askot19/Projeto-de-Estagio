using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Utilidade
{
    public class Utilidade_Conexao
    {
        /// <summary>
            /// Variavel privado da classe de conexao;
            /// </summary>
            private String _stringConexao;
            private MySqlConnection _conexao;

            /// <summary>
            /// Metodo construtor da classe conexao;
            /// </summary>
            /// <param name="dadosConexao"></param>
            public Utilidade_Conexao(String dadosConexao)
            {
                this._conexao = new MySqlConnection();
                this.StringConexao = dadosConexao;
                this._conexao.ConnectionString = dadosConexao;
            }

            /// <summary>
            /// Propriedade da classe StringConexao;
            /// </summary>
            public String StringConexao
            {
                get => this._stringConexao;
                set => this._stringConexao = value;
            }

            /// <summary>
            /// Propriedade da classe Conexao;
            /// </summary>
            public MySqlConnection Conexao
            {
                get => this._conexao;
                set => this._conexao = value;
            }

            /// <summary>
            /// Metodo abrir a conexao com banco de dados;
            /// </summary>
            public void AbrirConexao()
            {
                this._conexao.Open();
            }

            /// <summary>
            /// Metodo fechar a conexao com banco de dados;
            /// </summary>
            public void FercharConexao()
            {
                this._conexao.Close();
            }
    }
}
