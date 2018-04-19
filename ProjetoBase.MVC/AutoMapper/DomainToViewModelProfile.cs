using AutoMapper;
using ProjetoBase.Domain.Entities;
using ProjetoBase.ViewModel;

namespace ProjetoBase.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Setor, ViewSetorViewModel>();
        }
    }
}
