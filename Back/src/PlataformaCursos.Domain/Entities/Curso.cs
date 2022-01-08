using System.Collections.Generic;

namespace PlataformaCursos.Domain.Entities
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CargaHoraria { get; set; }
        public decimal Preco { get; set; }

        public ICollection<Estudante> Estudantes { get; set; }
    }
}