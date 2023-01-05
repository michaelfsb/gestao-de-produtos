using System.ComponentModel.DataAnnotations;

namespace GestaoDeProdutos.Domain.Dtos
{
    public class ProdutoDto
    {
        public int Codigo { get; set; }

        public string? Descricao { get; set; }

        public bool Situacao { get; set; }

        public DateTime? Fabricacao { get; set; }

        public DateTime? Validade { get; set; }

        public int? CodigoFornecedor { get; set; }

        public string? DescricaoFornecedor { get; set; }

        public string? CnpjFornecedor { get; set; }

    }

    public class ProdutoCreateDto : ProdutoCreateUpdateDto
    {

    }

    public class ProdutoUpdateDto : ProdutoCreateUpdateDto
    {

    }

    public abstract class ProdutoCreateUpdateDto
    {
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
