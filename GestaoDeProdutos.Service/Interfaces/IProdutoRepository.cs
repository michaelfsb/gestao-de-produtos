using GestaoDeProdutos.Domain.Models;

namespace GestaoDeProdutos.Service.Interfaces;

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> GetAllProdutos();
    Task<Produto?> GetProduto(int codigo);
    Task CreateProduto(Produto produto);
    Task DeleteProduto(Produto produto);
}