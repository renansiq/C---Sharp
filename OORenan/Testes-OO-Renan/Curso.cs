using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_OO_Renan
{
    public class Curso
    {        
        public short IdCurso { get; set; }
        public string NomeCurso { get; set; }
        public string  Periodo { get; set; }        
        public Professor cursoProfessor = new Professor(0, "nome");

        public Curso(short id, string nome, string periodo)
        {
            this.IdCurso = id;
            this.NomeCurso = nome;
            this.Periodo = periodo;
        }
    }
    enum periodo { manha, tarde, noite };    
}

