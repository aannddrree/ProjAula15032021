using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula15032021
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente()
            {
                Id = 1,
                Nome = "José Silva",
                Email = "jose@terra.com",
                Endereco = new Endereco()
                {
                    Logradouro = "Rua 9 de julho",
                    Bairro = "Imperador",
                    CEP = "154541212",
                    Numero = 12
                },
                Telefone = "16 99999 7777",
                Saldo = 10000
            };

            Funcionario funcionario = new Funcionario()
            {
                Id = 1,
                Nome = "João Silva",
                Email = "joao@terra.com",
                Endereco = new Endereco()
                {
                    Logradouro = "Av 7 de setembro",
                    Bairro = "Centro",
                    CEP = "897498549",
                    Numero = 13
                },
                Telefone = "16 98888 1411",
                Salario = 15000
            };

            Console.WriteLine(cliente);
            Console.WriteLine(funcionario);

            Console.WriteLine("Logradouro Funcionario: " + funcionario.Endereco.Logradouro);

            Console.ReadKey();
        }


    }
}
