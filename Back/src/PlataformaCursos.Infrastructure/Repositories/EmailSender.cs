using PlataformaCursos.Domain.Interfaces.Repositories;
using System.Threading.Tasks;

namespace PlataformaCursos.Infrastructure.Repositories
{
    public class EmailSender : IEmailSender
    {
        public Task<bool> EnviarEmail(string destinatario, string assunto, string mensagem)
        {
            throw new System.NotImplementedException();
        }
    }
}
