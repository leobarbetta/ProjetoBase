using AutoMapper;
using ProjetoBase.Domain;
using ProjetoBase.ViewModel.Setor;

namespace ProjetoBase.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Setor, ViewSetorViewModel>();
            CreateMap<Setor, UpdateSetorViewModel>();
        }
    }
}
