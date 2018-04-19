using ProjetoBase.Domain.Entities;
using ProjetoBase.Service.Base;

namespace ProjetoBase.Service.Interfaces
{
    public interface ISetorService : ICrudService<Setor, int>
    {
        bool ValidaSetor(Setor setor);
    }
}
