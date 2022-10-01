using Application.Contracts.Requests;
using Application.Queries;
using AutoMapper;

namespace Application.Contracts;
public class Profiles : Profile
{

    public Profiles()
    {
        CreateMap<GetCurrentUserDto, GetCurrentUserQuery>();
        //  .ForMember(dest =>
        //         dest.Username,
        //         src => src.MapFrom(it => it.Username)); 
    }
}