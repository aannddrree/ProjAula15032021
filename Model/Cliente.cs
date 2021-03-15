using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente : Pessoa
    {
        #region Propriedades
        public decimal Saldo { get; set; }
        #endregion

        #region Métodos

        public override string ToString()
        {
            return base.ToString() + "\nSaldo: " + this.Saldo;
        }

        #endregion
    }
}
