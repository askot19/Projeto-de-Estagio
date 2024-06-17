﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Utilidade
{
    public class Utilidade_DadosConexao
    {
        /// <summary>
        /// Variavel global de conexão;
        /// </summary>
        public static String servidor = "localhost";
        public static String banco = "gestaofinanceira";
        public static String usuario = "root";
        public static String senha = "";

        /// <summary>
        /// Metodo StringConexao que realiza a conexão com o banco de dados;
        /// </summary>
        public static String StringConexao
        {
            get
            {
                return @"Data Source=" + servidor + ";Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha;
            }
        }
    }
}
