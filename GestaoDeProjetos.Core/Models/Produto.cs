using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoDeProdutos.Domain.Models
{
    public class Produto
    {
        [Column("ProdutoId")]
        public int Id { get; set; }

        [Required(ErrorMessage = "A descrição do produto é obrigatória.")]
        public string? Descricao { get; set; }

        public bool Situacao { get; set; }

        public DateTime? Fabricacao { get; set; }

        public DateTime? Validade { get; set; }

        public int? CodigoFornecedor { get; set; }

        public string? DescricaoFornecedor { get; set; }

        public string? CnpjFornecedor { get; set; }

    }
}
