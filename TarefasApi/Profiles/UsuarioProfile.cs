using AutoMapper;
using TarefasApi.Dtos;

namespace TarefasApi.Profiles;

public class UsuarioProfile : Profile
{
    public UsuarioProfile() 
    {
        CreateMap<CreateUsuarioDto, UsuarioProfile>();
    } 
}
