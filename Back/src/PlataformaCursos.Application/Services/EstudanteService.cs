using PlataformaCursos.Application.Interfaces;
using PlataformaCursos.Domain.Entities;
using PlataformaCursos.Domain.Interfaces.Repositories;
using System;
using System.Threading.Tasks;

namespace PlataformaCursos.Application.Services
{
    public class EstudanteService : IEstudanteService
    {
        private readonly IEstudanteRepo _estudanteRepository;
        private readonly IEmailSender _emailSender;
        public EstudanteService(IEstudanteRepo estudanteRepository,IEmailSender emailSender)
        {
            _estudanteRepository = estudanteRepository;
            _emailSender = emailSender;
        }
        
        public async Task<Estudante> CadastrarEstudante(Estudante estudante)
        {
            try
            {
                var estudanteCreated = await _estudanteRepository.CriarEstudante(estudante);

                if (estudanteCreated == null)
                {
                    return null;
                }

                await _emailSender.EnviarEmail(estudante.Email, "Conta criada com sucesso!", "Parabéns, bem-vindo a nossa plataforma de cursos on demand!");
                return estudanteCreated;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
