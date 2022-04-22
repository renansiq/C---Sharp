using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        const int SALARIOINICIAL = 5000;
        public Diretor(string cpf):base(SALARIOINICIAL, cpf)
        {            
            CPF = cpf;           
            Console.WriteLine("Criando DIRETOR");
        }

        // Funcionário tem esta classe abstrata e a implementação é realizada na classe derivada (aqui)
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }    

        // Funcionário tem esta classe abstrata e a implementação é realizada na classe derivada (aqui)
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
