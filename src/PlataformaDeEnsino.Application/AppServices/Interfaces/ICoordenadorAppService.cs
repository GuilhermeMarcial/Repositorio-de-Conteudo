using PlataformaDeEnsino.Core.Entities;

namespace PlataformaDeEnsino.Application.AppServices.Interfaces
{
    public interface ICoordenadorAppService : IAppServiceBase<Coordenador>
    {
         Coordenador ConsultarPeloCpf(string cpfDoCoordenador);
    }
}