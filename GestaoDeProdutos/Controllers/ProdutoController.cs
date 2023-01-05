using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using GestaoDeProdutos.Domain.Dtos;
using GestaoDeProdutos.Domain.Models;
using GestaoDeProdutos.Service.Interfaces;

namespace GestaoDeProdutos.Controllers;


[Route("api/produtos")]
[ApiController]
public class ProdutoController : BaseApiController
{
    public ProdutoController(IRepositoryManager repository, IMapper mapper) : base(repository, mapper)
    {
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduto([FromBody] ProdutoCreateDto produto)
    {
        var produtoData = _mapper.Map<Produto>(produto);
        await _repository.Produto.CreateProduto(produtoData);
        await _repository.SaveAsync();
        var produtoReturn = _mapper.Map<ProdutoDto>(produtoData);
        return CreatedAtRoute("ProdutoByCodigo",
            new
            {
                produtoCodigo = produtoReturn.Id
            },
            produtoReturn);
    }


    [HttpGet]
    public async Task<IActionResult> GetProdutos()
    {
        try
        {
            var produtos = await _repository.Produto.GetAllProdutos();
            var produtosDto = _mapper.Map<IEnumerable<ProdutoDto>>(produtos);
            return Ok(produtosDto);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error");
        }
    }


    [HttpGet("{codigo}", Name = "ProdutoByCodigo")]
    public async Task<IActionResult> GetProduto(int produtoId)
    {
        var produto = await _repository.Produto.GetProduto(produtoId);
        if (produto is null)
        {
            return NotFound();
        }
        else
        {
            var produtoDto = _mapper.Map<ProdutoDto>(produto);
            return Ok(produtoDto);
        }
    }


    [HttpPut("{codigo}")]
    public async Task<IActionResult> UpdateProduto(int produtoId, [FromBody] ProdutoUpdateDto produto)
    {
        var produtoData = HttpContext.Items["produto"] as Produto;
        _mapper.Map(produto, produtoData);
        await _repository.SaveAsync();
        return NoContent();
    }
}