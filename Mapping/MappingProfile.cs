using AutoMapper;
using ng4_asp.net_core_2.Controllers.Resources;
using ng4_asp.net_core_2.Models;

namespace ng4_asp.net_core_2.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}