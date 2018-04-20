using ProjetoBase.Domain;
using ProjetoBase.Service.Base;
using System.Collections.Generic;

namespace ProjetoBase.Service.Interfaces
{
    public interface ISetorService : ICrudService<Setor, int>
    {
        List<StatusValidacaoEnum> ValidaSetor(Setor setor);
    }
}
