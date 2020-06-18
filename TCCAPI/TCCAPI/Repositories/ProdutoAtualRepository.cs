using APITESTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITESTE.Repositories
{
    public static class ProdutoAtualRepository
    {
        public static void Deletar(int id)
        {
            BaseRepository.Delete<ProdutoAtual>(id);
        }
        public static void Gravar(ProdutoAtual produtoAtual)
        {
            BaseRepository.Command(produtoAtual);
        }
        public static void Atualizar(ProdutoAtual produtoAtual)        
        {
            BaseRepository.Command(produtoAtual, true);
        }
        public static List<ProdutoAtual> Buscar()
        {
            string sql = "select * from ProdutoAtual";
            var retorno = BaseRepository.QuerySql<ProdutoAtual>(sql);
            return retorno;
        }
        public static List<ProdutoAtual> BuscarPorId(int IdVendedora)
        {
            string sql = "select * from ProdutoAtual where IdVendedora = @IdVendedora";
            var retorno = BaseRepository.QuerySql<ProdutoAtual>(sql, new { IdVendedora = IdVendedora });
            return retorno;
        }
        public static List<ProdutoAtual> BuscarPorNome(int IdVendedora, string Nome)
        {
            string sql = "select * from ProdutoAtual where IdVendedora = @IdVendedora and Nome like @Nome";
            var retorno = BaseRepository.QuerySql<ProdutoAtual>(sql, new { IdVendedora = IdVendedora, Nome = "%" + Nome + "%"});
            return retorno;
        }
    }
}
