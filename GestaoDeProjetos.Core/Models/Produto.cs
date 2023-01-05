using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Domain.Models
{
    public class Produto
    {
        public int Codigo { get; set; }

        [Required(ErrorMessage = "A descrição do produto é obrigatória.")]
        public string? Descricao { get; set; }

        public bool Situacao { get; set; }

        public DateOnly? Fabricacao { get; set; }

        public DateOnly? Validade { get; set; }

        public int? CodigoFornecedor { get; set; }

        public string? DescricaoFornecedor { get; set; }

        public string? CnpjFornecedor { get; set; }

    }
}
