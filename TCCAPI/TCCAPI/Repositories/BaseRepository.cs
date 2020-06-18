using APITESTE.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace APITESTE.Repositories
{
    public class BaseRepository
    {
        public static List<T> QuerySql<T>(string sql, object parameter = null)
        {
            List<T> orderDetail;
            using (var connection = new SqlConnection("Server = DESKTOP-LPAIMLV; Database = APIBD3; Trusted_Connection = True;"))
            {
                orderDetail = connection.Query<T>(sql, parameter).ToList();
            }
            return orderDetail;
        }

        public static void Command<T>(T objeto, bool editar = false, object parameter = null) where T : BaseModel
        {
            using (var connection = new SqlConnection("Server = DESKTOP-LPAIMLV; Database = APIBD3; Trusted_Connection = True;"))
            {
                if (editar == false)
                {
                    connection.Insert(objeto);
                }
                else
                {
                    connection.Update(objeto);
                }
            }
        }
        
        public static void Delete<T>(int id) where T : BaseModel
        {
            using (var connection = new SqlConnection("Server = DESKTOP-LPAIMLV; Database = APIBD3; Trusted_Connection = True;"))
            {
                string query = $"select * from {typeof(T).Name} where Id = @id";
                var objeto = connection.Query<T>(query, new { id });
                connection.Delete(objeto);
            }
        }
    }
}
