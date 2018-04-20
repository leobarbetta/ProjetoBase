using AutoMapper;
using ProjetoBase.Domain;
using ProjetoBase.ViewModel.Setor;

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
