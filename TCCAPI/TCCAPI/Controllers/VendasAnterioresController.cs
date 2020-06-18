using System.Collections.Generic;
using APITESTE.Models;
using APITESTE.Repositories;
using APITESTE.Responses;
using Microsoft.AspNetCore.Mvc;

namespace APITESTE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasAnterioresController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<VendasAnteriores>> Get()
        {
            return VendasAnterioresRepository.Buscar();
        }
        [HttpGet("{IdSacola}/{MesDeEntrega}")]
        public ActionResult<List<VendasAnteriores>> GetComFiltro(int IdSacola, string MesDeEntrega)
        {
            if (MesDeEntrega == "semMesDeEntrega")
            {
                return VendasAnterioresRepository.BuscarPorId(IdSacola);
            }
            else
            {
                return VendasAnterioresRepository.BuscarPorMesDeEntrega(IdSacola, MesDeEntrega);
            }
        }
        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] VendasAnteriores request)
        {
            VendasAnterioresRepository.Gravar(request);
            var retorno = new ReturnResponse()
            {
                Code = 100,
                Message = "Produto cadastrado com sucesso"
            };

            return retorno;
        }
        [HttpPut]
        public ActionResult<ReturnResponse> Put([FromBody] VendasAnteriores request)
        {
            VendasAnterioresRepository.Atualizar(request);
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
            VendasAnterioresRepository.Deletar(id);
            var retorno = new ReturnResponse()
            {
                Code = 100,
                Message = "Produto deletado com sucesso"
            };

            return retorno;
        }
    }
}