using PlataformaCursos.Domain.Entities;
using System.Threading.Tasks;

namespace PlataformaCursos.Domain.Interfaces.Repositories
{
    public interface IEstudanteRepo
    {
        Task<Estudante> CriarEstudante(Estudante estudante);
    }
}
