using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(double salario, string cpf) : base(salario, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.22;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.31;
        }
    }
}
