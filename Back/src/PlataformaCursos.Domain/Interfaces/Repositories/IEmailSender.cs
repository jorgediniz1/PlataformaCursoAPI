using System.Threading.Tasks;

namespace PlataformaCursos.Domain.Interfaces.Repositories
{
    public interface IEmailSender
    {
        Task<bool> EnviarEmail(string destinatario, string assunto, string mensagem);
    }
}
