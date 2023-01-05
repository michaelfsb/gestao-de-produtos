using GestaoDeProdutos.Domain.Models;
using GestaoDeProdutos.Repository.Base.Repository;
using GestaoDeProdutos.Repository.Data;
using GestaoDeProdutos.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeProdutos.Service.Services;

public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
{
    public ProdutoRepository(RepositoryContext repositoryContext) : base(repositoryContext) {}

    public async Task CreateProduto(Produto produto) => await CreateAsync(produto);

    public async Task DeleteProduto(Produto produto) => await RemoveAsync(produto);

    public async Task<IEnumerable<Produto>> GetAllProdutos() 
        => await FindAllAsync().Result.OrderBy(c => c.Codigo).ToListAsync();

    public async Task<Produto?> GetProduto(int codigo)
        => await FindByConditionAsync(c => c.Codigo.Equals(codigo)).Result.SingleOrDefaultAsync();
}