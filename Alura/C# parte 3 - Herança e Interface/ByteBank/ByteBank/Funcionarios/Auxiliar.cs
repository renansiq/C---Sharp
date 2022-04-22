using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf): base(2000, cpf)
        {
            CPF = cpf;
            Console.WriteLine("Criando AUXILIAR");
        }

        // Funcionário tem esta classe abstrata e a implementação é realizada na classe derivada (aqui)
        public override void AumentarSalario()
        {
            Salario *= 1.10;
        }

        // Funcionário tem esta classe abstrata e a implementação é realizada na classe derivada (aqui)
        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }
    }  
}
