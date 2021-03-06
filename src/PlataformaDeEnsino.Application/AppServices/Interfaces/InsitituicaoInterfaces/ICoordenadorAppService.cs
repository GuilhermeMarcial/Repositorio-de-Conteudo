using System.Threading.Tasks;
using PlataformaDeEnsino.Core.Entities;

namespace PlataformaDeEnsino.Application.AppServices.Interfaces.InsitituicaoInterfaces
{
    public interface ICoordenadorAppService : IAppServiceBase<Coordenador>
    {
         Task<Coordenador> ConsultarPeloCpfAsync(string cpfDoCoordenador);
    }
}