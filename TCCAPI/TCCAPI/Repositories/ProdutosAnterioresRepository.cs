using APITESTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITESTE.Repositories
{
    public static class ProdutosAnterioresRepository
    {
        public static void Deletar(int id)
        {
            BaseRepository.Delete<ProdutosAnteriores>(id);
        }
        public static void Gravar(ProdutosAnteriores ProdutosAnteriores)
        {
            BaseRepository.Command(ProdutosAnteriores);
        }
        public static void Atualizar(ProdutosAnteriores ProdutosAnteriores)
        {
            BaseRepository.Command(ProdutosAnteriores, true);
        }
        public static List<ProdutosAnteriores> Buscar()
        {
            string sql = "select * from ProdutosAnteriores";
            var retorno = BaseRepository.QuerySql<ProdutosAnteriores>(sql);
            return retorno;
        }
        public static List<ProdutosAnteriores> BuscarPorId(int IdSacola)
        {
            string sql = "select * from ProdutosAnteriores where IdSacola = @IdSacola";
            var retorno = BaseRepository.QuerySql<ProdutosAnteriores>(sql, new { IdSacola = IdSacola });
            return retorno;
        }
        public static List<ProdutosAnteriores> BuscarPorNome(int IdSacola, string Nome)
        {
            string sql = "select * from ProdutosAnteriores where IdSacola = @IdSacola and Nome like @Nome";
            var retorno = BaseRepository.QuerySql<ProdutosAnteriores>(sql, new { IdSacola = IdSacola, Nome = "%" + Nome + "%" });
            return retorno;
        }
    }
}
