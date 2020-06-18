using APITESTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITESTE.Repositories
{
    public static class ProdutoVendidoRepository
    {
        public static void Deletar(int id)
        {
            BaseRepository.Delete<ProdutoVendido>(id);
        }
        public static void Gravar(ProdutoVendido ProdutoVendido)
        {
            BaseRepository.Command(ProdutoVendido);
        }
        public static void Atualizar(ProdutoVendido ProdutoVendido)
        {
            BaseRepository.Command(ProdutoVendido, true);
        }
        public static List<ProdutoVendido> Buscar()
        {
            string sql = "select * from ProdutoVendido";
            var retorno = BaseRepository.QuerySql<ProdutoVendido>(sql);
            return retorno;
        }
        public static List<ProdutoVendido> BuscarPorId(int IdVendedora)
        {
            string sql = "select * from ProdutoVendido where IdVendedora = @IdVendedora";
            var retorno = BaseRepository.QuerySql<ProdutoVendido>(sql, new { IdVendedora = IdVendedora });
            return retorno;
        }
        public static List<ProdutoVendido> BuscarPorNome(int IdVendedora, string Nome)
        {
            string sql = "select * from ProdutoVendido where IdVendedora = @IdVendedora and Nome like @Nome";
            var retorno = BaseRepository.QuerySql<ProdutoVendido>(sql, new { IdVendedora = IdVendedora, Nome = "%" + Nome + "%" });
            return retorno;
        }
    }
}
