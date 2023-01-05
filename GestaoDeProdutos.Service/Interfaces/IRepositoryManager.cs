namespace GestaoDeProdutos.Service.Interfaces;

public interface IRepositoryManager
{
    IProdutoRepository Produto { get; }
    Task SaveAsync();
}