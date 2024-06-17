using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Modelo
{
    public class modelo_Usuario
    {
        /// <summary>
        /// Variavel do modelo;
        /// </summary>
        private int user_id;
        private string user_usuario;
        private string user_password;

        /// <summary>
        /// Metodo construtor
        /// </summary>
        public modelo_Usuario()
        {
            this.User_id = 0;
            this.User_usuario = "";
            this.User_password = "";
        }

        /// <summary>
        /// Objetos da Classe;
        /// </summary>
        public int User_id { get => user_id; set => user_id = value; }
        public string User_usuario { get => user_usuario; set => user_usuario = value; }
        public string User_password { get => user_password; set => user_password = value; }
    }
}
