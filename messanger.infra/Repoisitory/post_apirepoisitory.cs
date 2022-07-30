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
    public class post_apirepoisitory : Ipost_apiRepoisitory
    {
        private readonly IDBContext dBContext;
        public post_apirepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public string Createpost(post_api ins)
        {
            var parameter = new DynamicParameters();
            parameter.Add("p_post_details ", ins.post_details, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("p_post_date", ins.post_date, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameter.Add("p_usersID", ins.usersID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.dbConnection.ExecuteAsync("Post_package_api.CreatePost", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "NotInserted";
            }
            else
            {
                return "Inserted";
            }

        }

        public string Deletepost(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("p_postid ", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("Post_package_api.DeletePost", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return "Notdelete";
            }
            else
            {
                return "deleted";
            }
        }

        public List<post_api> GetAllpost()
        {
            IEnumerable<post_api> result = dBContext.dbConnection.Query<post_api>("Post_package_api.GetAllpost", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public post_api GetpostById(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("p_postid ", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<post_api> result = dBContext.dbConnection.Query<post_api>("Post_package_api.GetpostById", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public string UpDatepost(post_api upd)
        {
            var parameter = new DynamicParameters();
            parameter.Add("p_postid", upd.postid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("p_post_details", upd.post_details, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("p_post_date", upd.post_date, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameter.Add("p_usersID", upd.usersID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.dbConnection.ExecuteAsync("Post_package_api.UpDatepost", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {
                return "NotUpDatepost";
            }
            else
            {
                return "UpDatepost";
            }
        }
    }
}
