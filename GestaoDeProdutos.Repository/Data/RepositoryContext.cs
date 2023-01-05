using Microsoft.EntityFrameworkCore;
using GestaoDeProdutos.Domain.Models;

namespace GestaoDeProdutos.Repository.Data;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProdutoData());
    }

    public DbSet<Produto> Produto { get; set; }
}