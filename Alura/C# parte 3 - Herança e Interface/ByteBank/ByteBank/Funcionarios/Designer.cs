using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf):base(3000, cpf)
        {
            CPF = cpf;
            Console.WriteLine("Criando DESIGNER");
        }

        // Funcionário tem esta classe abstrata e a implementação é realizada na classe derivada (aqui)
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        // Funcionário tem esta classe abstrata e a implementação é realizada na classe derivada (aqui)
        public override double GetBonificacao()
        {
            Ferias();       // método não abstrato da classe Funcionario, chamando para testes, funciona normalmente.
            return Salario * 0.17;
        }
    }
}
