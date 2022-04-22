using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios{    
    // a classe abstrata não pode ser instanciada (criado objeto Funcionario)
    public abstract class Funcionario
    {
        public static int TotaldeFuncionarios{ get; private set; }       
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }      

        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;   
            Salario = salario;
            Console.WriteLine("Criando FUNCIONARIO");
            TotaldeFuncionarios++;
            Console.WriteLine("Contador de Funcionários: " + TotaldeFuncionarios);
        }

        //Métodos abstratos só podem ser usados por classes abstratadas, e são apenas declarados
        public abstract void AumentarSalario();

        public abstract double GetBonificacao();

        //classes abstratas tamtém podem ter métodos concretos
        public void Ferias()
        {
            Console.WriteLine("Testes com método concreto em uma classe abstrata");
        }
       
     
    }
}

