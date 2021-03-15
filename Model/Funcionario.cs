using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Funcionario : Pessoa
    {
        #region Propriedades
        public decimal Salario { get; set; }

        #endregion

        #region Método

        public override string ToString()
        {
            return base.ToString() + "\nSalário: " + this.Salario + "\nTipo Funcionário: " + this.ValidaGrupoMaster();
        }

        public string ValidaGrupoMaster()
        {
            if (this.Salario > 6000)
                return "MASTER";
            return "GOLD";
        }
        #endregion
    }
}
