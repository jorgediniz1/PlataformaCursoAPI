using Microsoft.EntityFrameworkCore;
using PlataformaCursos.Domain.Entities;

namespace PlataformaCursos.Infrastructure.Data
{
    public class PlataformaCursosContext : DbContext
    {
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Estudante> Estudantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}