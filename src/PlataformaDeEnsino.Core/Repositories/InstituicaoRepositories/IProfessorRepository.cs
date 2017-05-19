using System;
using System.Threading.Tasks;
using PlataformaDeEnsino.Core.Entities;

namespace PlataformaDeEnsino.Core.Repositories.InstituicaoRepositories
{
    public interface IProfessorRepository : IRepositoryBase<Professor>, IDisposable
    {
         Task<Professor> ConsultarPeloCpfAsync(string cpfDoProfessor);
         Task<Professor> ConsultarPelaUnidadeAsync(int idDaUnidade);
    }
}