using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaCursos.Domain.Entities
{
    public class CursosEstudantes
    {
        public int Estudanteid { get; set; }
        public Estudante Estudante { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
