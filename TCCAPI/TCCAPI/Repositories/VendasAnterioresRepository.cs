using APITESTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITESTE.Repositories
{
    public static class VendasAnterioresRepository
    {
        public static void Deletar(int id)
        {
            BaseRepository.Delete<VendasAnteriores>(id);
        }
        public static void Gravar(VendasAnteriores VendasAnteriores)
        {
            BaseRepository.Command(VendasAnteriores);
        }
        public static void Atualizar(VendasAnteriores VendasAnteriores)
        {
            BaseRepository.Command(VendasAnteriores, true);
        }
        public static List<VendasAnteriores> Buscar()
        {
            string sql = "select * from VendasAnteriores";
            var retorno = BaseRepository.QuerySql<VendasAnteriores>(sql);
            return retorno;
        }
        public static List<VendasAnteriores> BuscarPorId(int IdSacola)
        {
            string sql = "select * from VendasAnteriores where IdSacola = @IdSacola";
            var retorno = BaseRepository.QuerySql<VendasAnteriores>(sql, new { IdSacola = IdSacola });
            return retorno;
        }
        public static List<VendasAnteriores> BuscarPorMesDeEntrega(int IdSacola, string MesDeEntrega)
        {
            string sql = "select * from VendasAnteriores where IdSacola = @IdSacola and MesDeEntrega like @MesDeEntrega";
            var retorno = BaseRepository.QuerySql<VendasAnteriores>(sql, new { IdSacola = IdSacola, MesDeEntrega = "%" + MesDeEntrega + "%" });
            return retorno;
        }
    }
}
