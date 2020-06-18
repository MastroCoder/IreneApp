using System.Collections.Generic;
using APITESTE.Models;
using APITESTE.Repositories;
using APITESTE.Responses;
using Microsoft.AspNetCore.Mvc;

namespace TCCAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosAnterioresController
    {
        [HttpGet]
        public ActionResult<List<ProdutosAnteriores>> Get()
        {
            return ProdutosAnterioresRepository.Buscar();
        }
        [HttpGet("{IdSacola}/{Nome}")]
        public ActionResult<List<ProdutosAnteriores>> GetComFiltro(int IdSacola, string Nome)
        {
            if (Nome == "semNome")
            {
                return ProdutosAnterioresRepository.BuscarPorId(IdSacola);
            }
            else
            {
                return ProdutosAnterioresRepository.BuscarPorNome(IdSacola, Nome);
            }
        }
        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] ProdutosAnteriores request)
        {
            ProdutosAnterioresRepository.Gravar(request);
            var retorno = new ReturnResponse()
            {
                Code = 100,
                Message = "Produto cadastrado com sucesso"
            };

            return retorno;
        }
        [HttpPut]
        public ActionResult<ReturnResponse> Put([FromBody] ProdutosAnteriores request)
        {
            ProdutosAnterioresRepository.Atualizar(request);
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
            ProdutosAnterioresRepository.Deletar(id);
            var retorno = new ReturnResponse()
            {
                Code = 100,
                Message = "Produto deletado com sucesso"
            };

            return retorno;
        }
    }
}
