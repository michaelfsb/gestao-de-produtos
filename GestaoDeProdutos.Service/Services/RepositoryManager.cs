using GestaoDeProdutos.Repository.Data;
using GestaoDeProdutos.Service.Interfaces;

namespace GestaoDeProdutos.Service.Services;

public class RepositoryManager : IRepositoryManager
{
    private RepositoryContext _repositoryContext;

    private IProdutoRepository _produtoRepository;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
    }

    public IProdutoRepository Produto
    {
        get
        {
            if (_produtoRepository is null)
                _produtoRepository = new ProdutoRepository(_repositoryContext);
            return _produtoRepository;
        }
    }

    public Task SaveAsync() => _repositoryContext.SaveChangesAsync();
}