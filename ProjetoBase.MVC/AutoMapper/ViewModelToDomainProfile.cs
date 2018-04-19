using AutoMapper;
using ProjetoBase.Domain.Entities;
using ProjetoBase.ViewModel;

namespace ProjetoBase.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CreateSetorViewModel, Setor>();
            CreateMap<UpdateSetorViewModel, Setor>();
        }
    }
}
