using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_OO_Renan
{
    public class Aluno
    {
        public Endereco enderecoAluno = new Endereco("logradouro", "complemento", "numero", "bairro", "cidade", "cep");
      
        public short Ra { get; set; }
        public string NomeAluno { get; set; }
        public short Idade { get; set; }
        public static int ContadorAluno { get; private set; }             

        public Aluno(short ra, string nome, short idade)
        {
            this.Ra = ra;
            this.NomeAluno = nome;
            this.Idade = idade;

            ContadorAluno++;
        }

        public void MostrarAluno()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(this.Ra);
            Console.WriteLine(this.NomeAluno);
            Console.WriteLine(this.Idade);
            Endereco.MostrarEndereco(enderecoAluno);      
        }
    }
}
