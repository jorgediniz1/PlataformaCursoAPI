using PlataformaCursos.Domain.Entities;
using System.Threading.Tasks;

namespace PlataformaCursos.Application.Interfaces
{
    public interface IEstudanteService
    {
        //CadastrarEstudante
        Task<Estudante> CadastrarEstudante(Estudante estudante);
    }
}