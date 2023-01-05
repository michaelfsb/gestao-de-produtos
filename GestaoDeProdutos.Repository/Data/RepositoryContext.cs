using Microsoft.EntityFrameworkCore;
using GestaoDeProdutos.Domain.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace StudentTeacher.Repo.Data;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProdutoData());
    }

    public DbSet<Produto> Teachers { get; set; }
}