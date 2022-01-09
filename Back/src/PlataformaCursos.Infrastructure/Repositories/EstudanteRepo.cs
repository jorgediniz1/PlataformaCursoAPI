using PlataformaCursos.Domain.Entities;
using PlataformaCursos.Domain.Interfaces.Repositories;
using PlataformaCursos.Infrastructure.Data;
using System.Threading.Tasks;

namespace PlataformaCursos.Infrastructure.Repositories
{
    public class EstudanteRepo : IEstudanteRepo
    {
        private readonly PlataformaCursosContext _context;
        public EstudanteRepo(PlataformaCursosContext context)
        {
            _context = context;
        }

        public Task<Estudante> CriarEstudante(Estudante estudante)
        {
            throw new System.NotImplementedException();
        }
    }
}