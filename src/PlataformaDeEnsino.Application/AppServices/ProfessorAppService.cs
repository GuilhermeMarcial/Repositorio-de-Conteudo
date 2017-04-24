using System;
using PlataformaDeEnsino.Application.AppServices.Interfaces;
using PlataformaDeEnsino.Core.Entities;
using PlataformaDeEnsino.Core.Services.Interfaces;

namespace PlataformaDeEnsino.Application.AppServices
{
    public class ProfessorAppService : AppServiceBase<Professor>, IProfessorAppService
    {
        private readonly IProfessorService _professorService;
        public ProfessorAppService(IProfessorService professorService) : base(professorService)
        {
            _professorService = professorService;
        }

        public Professor ConsultarPelaUnidade(int idDaUnidade)
        {
            return _professorService.ConsultarPelaUnidade(idDaUnidade);
        }

        public Professor ConsultarPeloCpf(string cpfDoProfessor)
        {
            return _professorService.ConsultarPeloCpf(cpfDoProfessor);
        }
    }
}