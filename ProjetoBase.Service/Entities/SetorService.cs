using ProjetoBase.Domain;
using ProjetoBase.Repository.Interfaces;
using ProjetoBase.Service.Base;
using ProjetoBase.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBase.Service.Entities
{
    public class SetorService : CrudService<Setor, int>, ISetorService
    {
        private ISetorRepository _setorRepository;
        public SetorService(ISetorRepository repository) : base(repository)
        {
            _setorRepository = repository;
        }

        public List<StatusValidacaoEnum> ValidaSetor(Setor setor)
        {
            List<StatusValidacaoEnum> valida = new List<StatusValidacaoEnum>();

            Setor validaSetor = new Setor();

            validaSetor = _setorRepository.Select(p => p.Nome.ToUpper().Trim() == setor.Nome.ToUpper().Trim()).FirstOrDefault();

            if ((validaSetor != null) && (validaSetor.SetorId != setor.SetorId))
                valida.Add(StatusValidacaoEnum.NomeExistente);


            validaSetor = _setorRepository.Select(p => p.Sigla.ToUpper().Trim() == setor.Sigla.ToUpper().Trim()).FirstOrDefault();

            if ((validaSetor != null) && (validaSetor.SetorId != setor.SetorId))
                valida.Add(StatusValidacaoEnum.SiglaExistente);

            return valida;
        }
    }
}
