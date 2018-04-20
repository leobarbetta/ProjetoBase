using ProjetoBase.Domain;
using ProjetoBase.Repository.Base;
using System.Collections.Generic;

namespace ProjetoBase.Repository.Interfaces
{
    public interface ISetorRepository : ICrudRepository<Setor, int>
    {
        List<Setor> SelectByPessoa(int pessoaId);
    }
}
