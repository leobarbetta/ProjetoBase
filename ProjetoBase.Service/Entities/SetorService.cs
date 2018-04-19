using ProjetoBase.Domain.Entities;
using ProjetoBase.Repository.Interfaces;
using ProjetoBase.Service.Base;
using ProjetoBase.Service.Interfaces;

namespace ProjetoBase.Service.Entities
{
    public class SetorService : CrudService<Setor, int>, ISetorService
    {
        private ISetorRepository _setorRepository;
        public SetorService(ISetorRepository repository) : base(repository)
        {
            _setorRepository = repository;
        }

        public bool ValidaSetor(Setor setor)
        {
            return _setorRepository.Select(p => p.Nome == setor.Nome).Count > 0;
        }
    }
}
