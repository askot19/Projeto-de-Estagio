using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Modelo
{
    public class modelo_FormaPagto
    {
        /// <summary>
        /// Variavel global da classe;
        /// </summary>
        private int forma_id;
        private string forma_descricao;

        /// <summary>
        /// Metodo construtor da classe;
        /// </summary>
        public modelo_FormaPagto()
        {
            this.Forma_id = 0;
            this.Forma_descricao = "";
        }

        /// <summary>
        /// Propriedade da classe;
        /// </summary>
        public int Forma_id { get => forma_id; set => forma_id = value; }
        public string Forma_descricao { get => forma_descricao; set => forma_descricao = value; }
    }
}
