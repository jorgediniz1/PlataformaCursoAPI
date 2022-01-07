using System;

namespace PlataformaCursos.Domain.Entities
{
    public class Estudante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int ContaId { get; set; }
        public Conta Conta { get; set; }
        
    }
}
