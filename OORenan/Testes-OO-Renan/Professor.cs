using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_OO_Renan
{
    public class Professor
    {        
        public short Rp { get; set; }
        public string NomeProfessor { get; set; }                
        public Endereco enderecoProfessor = new Endereco("logradouro", "complemento", "numero", "bairro", "cidade", "cep");

        public static int ContadorProfessor { get; private set; }

        public Professor(short id, string nome)
        {
            this.Rp = id;
            this.NomeProfessor = nome;
        }
    }    
}
