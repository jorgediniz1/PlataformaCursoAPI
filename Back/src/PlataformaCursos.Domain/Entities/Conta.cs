using System.Collections.Generic;

namespace PlataformaCursos.Domain.Entities
{
    public class Conta
    {
        public int Id { get; set; }
        public bool Status { get; set; } = false; 
       
        public ICollection<Cartao> Cartoes { get; set; }
        public int EstudanteId { get; set; }
        public Estudante Estudantes { get; set; }
        


    }
}