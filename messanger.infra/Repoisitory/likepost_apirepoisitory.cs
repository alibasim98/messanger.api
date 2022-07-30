using Dapper;
using messanger.core.Data;
using messanger.core.domain;
using messanger.core.Repoisitory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace messanger.infra.Repoisitory
{
    public class likepost_apirepoisitory : Ilikepost_apiRepoisitory
    {
        private readonly IDBContext dBContext;
        public likepost_apirepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public string CreateLike(likepost_api ins)
        {
            var parameter = new DynamicParameters();
            parameter.Add("l_postid ", ins.postid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("l_userid ", ins.userid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.dbConnection.ExecuteAsync("likepost_package_api.CreateLike", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "NotInserted";
            }
            else
            {
                return "Inserted";
            }
        }

    

        public string DeleteLike(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("l_likepostid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.Execute("likepost_package_api.DeleteLike", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return "Notdelete";
            }
            else
            {
                return "deleted";
            }
        }

        public List<likepost_api> GetAllLike()
        {
            IEnumerable<likepost_api> result = dBContext.dbConnection.Query<likepost_api>("likepost_package_api.GetAllLike", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
