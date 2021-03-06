using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PlataformaDeEnsino.Core.Entities;
using PlataformaDeEnsino.Core.Repositories;
using System.Threading.Tasks;
using PlataformaDeEnsino.Core.Repositories.InstituicaoRepositories;

namespace PlataformaDeEnsino.Infrastructure.Repositories
{
    public class UnidadeRepository : RepositoryBase<Unidade>, IUnidadeRepository
    {
        public async Task<IEnumerable<Unidade>> ConsultarUnidadadesDoModuloAsync(int idDoModulo)
        {
           return await context.Unidades.AsNoTracking().Where(u => u.IdDoModulo == idDoModulo).ToListAsync();
        }
        public async Task<IEnumerable<Unidade>> ConsultarUnidadesDoProfessorAsync(int idDoProfessor)
        {
            return await context.Unidades.AsNoTracking().Where(u => u.IdDoProfessor == idDoProfessor).ToListAsync();
        }
    }
}