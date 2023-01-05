using AutoMapper;
using GestaoDeProdutos.Domain.Dtos;
using GestaoDeProdutos.Domain.Models;


namespace StudentTeacher.Core.Mappings;

public class ProdutoMappingProfile : Profile
{
    public ProdutoMappingProfile()
    {
        CreateMap<Produto, ProdutoDTO>();

        CreateMap<ProdutoCreateDto, Produto>();

        CreateMap<ProdutoUpdateDto, Produto>().ReverseMap();
    }
}
