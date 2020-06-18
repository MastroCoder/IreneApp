using System.Collections.Generic;
using APITESTE.Models;
using APITESTE.Repositories;
using APITESTE.Responses;
using Microsoft.AspNetCore.Mvc;

namespace APITESTE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoVendidoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<ProdutoVendido>> Get()
        {
            return ProdutoVendidoRepository.Buscar();
        }
        [HttpGet("{IdVendedora}/{Nome}")]
        public ActionResult<List<ProdutoVendido>> GetComFiltro(int IdVendedora, string Nome)
        {
            if (Nome == "semNome")
            {
                return ProdutoVendidoRepository.BuscarPorId(IdVendedora);
            }
            else
            {
                return ProdutoVendidoRepository.BuscarPorNome(IdVendedora, Nome);
            }
        }
        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] ProdutoVendido request)
        {
            ProdutoVendidoRepository.Gravar(request);
            var retorno = new ReturnResponse()
            {
                Code = 100,
                Message = "Produto cadastrado com sucesso"
            };

            return retorno;
        } 
        [HttpPut]
        public ActionResult<ReturnResponse> Put([FromBody] ProdutoVendido request)
        {
            ProdutoVendidoRepository.Atualizar(request);
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
            ProdutoVendidoRepository.Deletar(id);
            var retorno = new ReturnResponse()
            {
                Code = 100,
                Message = "Produto deletado com sucesso"
            };

            return retorno;
        }
    }
}