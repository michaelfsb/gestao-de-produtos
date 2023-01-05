using AutoMapper;
using GestaoDeProdutos.Domain.Dtos;
using GestaoDeProdutos.Domain.Models;


namespace GestaoDeProdutos.Domain.Mappings;

public class ProdutoMappingProfile : Profile
{
    public ProdutoMappingProfile()
    {
        CreateMap<Produto, ProdutoDto>();

        CreateMap<ProdutoCreateDto, Produto>();

        CreateMap<ProdutoUpdateDto, Produto>().ReverseMap();
    }
}
