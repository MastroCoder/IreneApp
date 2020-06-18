using System.Collections.Generic;
using APITESTE.Models;
using APITESTE.Repositories;
using APITESTE.Responses;
using Microsoft.AspNetCore.Mvc;

namespace APITESTE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoAtualController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<ProdutoAtual>> Get()
        {
            return ProdutoAtualRepository.Buscar();
        }
        [HttpGet("{IdVendedora}/{Nome}")]
        public ActionResult<List<ProdutoAtual>> GetComFiltro(int IdVendedora, string Nome)
        {
            if (Nome == "semNome")
            {
                return ProdutoAtualRepository.BuscarPorId(IdVendedora);
            }
            else
            {
                return ProdutoAtualRepository.BuscarPorNome(IdVendedora, Nome);
            }
        }
        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] ProdutoAtual request)
        {
            ProdutoAtualRepository.Gravar(request);
            var retorno = new ReturnResponse()
            {
                Code = 100,
                Message = "Produto cadastrado com sucesso"
            };

            return retorno;
        } 
        [HttpPut]
        public ActionResult<ReturnResponse> Put([FromBody] ProdutoAtual request)
        {
            ProdutoAtualRepository.Atualizar(request);
            var retorno = new ReturnResponse()
            {
                Code = 100,
                Message = "Produto atualizado com sucesso"
            };

            return retorno;
        }
        [HttpDelete("{id}")]
        public ActionResult<ReturnResponse> Delete(int id)
        {
            ProdutoAtualRepository.Deletar(id);
            var retorno = new ReturnResponse()
            {
                Code = 100,
                Message = "Produto deletado com sucesso"
            };

            return retorno;
        }
    }
}