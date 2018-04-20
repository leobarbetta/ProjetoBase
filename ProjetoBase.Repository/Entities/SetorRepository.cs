using Microsoft.EntityFrameworkCore;
using ProjetoBase.Domain;
using ProjetoBase.Repository.Base;
using ProjetoBase.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBase.Repository.Entities
{
    public class SetorRepository : CrudRepository<Setor, int>, ISetorRepository
    {
        public SetorRepository(DbContext context)
            : base(context)
        {
            _context = context;
        }

        public List<Setor> SelectByPessoa(int pessoaId)
        {            
            return _context.Set<Setor>()
                            .Where(p => p.Nome == "Teste")
                            .ToList();            
        }
    }
}
