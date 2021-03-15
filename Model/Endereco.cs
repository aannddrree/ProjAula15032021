namespace Model
{
    public class Endereco
    {
        #region Propriedades

        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }

        #endregion

        #region Métodos

        public override string ToString()
        {
            return this.Logradouro + ", " + this.Bairro + ", " + this.Numero + ", " + this.CEP;
        }

        #endregion
    }
}