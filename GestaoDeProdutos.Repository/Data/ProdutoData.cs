using GestaoDeProdutos.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoDeProdutos.Repository.Data;

public class ProdutoData : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.HasData(
            new Produto
            {
                Id = 1,
                Descricao = "Produto 1",
                Situacao = true,
                Fabricacao = DateTime.Now,
                Validade =DateTime.Now.AddDays(60),
                CodigoFornecedor = 1,
                DescricaoFornecedor = "Fornecedor 1",
                CnpjFornecedor = "XX.XXX.XXX/0001-XX"
            },

            new Produto
            {
                Id = 2,
                Descricao = "Produto 2",
                Situacao = true,
                Fabricacao = DateTime.Now,
                Validade = DateTime.Now.AddDays(180),
                CodigoFornecedor = 2,
                DescricaoFornecedor = "Fornecedor 2",
                CnpjFornecedor = "XX.XXX.XXX/0001-XX"
            },

            new Produto
            {
                Id = 3,
                Descricao = "Produto 3"
            });
    }
}