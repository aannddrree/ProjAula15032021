using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Pessoa
    {

        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public string Email { get; set; }
        #endregion

        #region Métodos
        public override string ToString()
        {
            return "Id: " + this.Id + 
                 "\nNome: " + this.Nome + 
                 "\nTelefone: " + this.Telefone + 
                 "\nEndereço: " + this.Endereco + 
                 "\nEmail: " + this.Email;
        }
        #endregion
    }
}
