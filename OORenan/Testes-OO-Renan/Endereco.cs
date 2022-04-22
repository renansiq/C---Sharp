using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_OO_Renan
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public Endereco(string logradouro, string complemento, string numero, string bairro, string cidade, string cep)
        {
            this.Logradouro = logradouro;
            this.Complemento = complemento;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Cep = cep;
        }

        public static void MostrarEndereco(Endereco obj)
        {
            Console.WriteLine(obj.Logradouro);
            Console.WriteLine(obj.Numero);
            Console.WriteLine(obj.Complemento);
            Console.WriteLine(obj.Bairro);
            Console.WriteLine(obj.Cidade);
            Console.WriteLine(obj.Cep);
        }
    }
}
