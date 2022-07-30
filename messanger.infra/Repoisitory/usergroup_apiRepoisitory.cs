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
    public class usergroup_apiRepoisitory : Iusergroup_apiRepoisitory
    {
        private readonly IDBContext dBContext;
        public usergroup_apiRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public string Createusergroup(usergroup_api ins)
        {
            var parameter = new DynamicParameters();
            parameter.Add("u_userid", ins.userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("u_groupid", ins.groupid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("usergroup_package_api.Createusergroup", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "NotInserted";
            }
            else
            {
                return "Inserted";
            }
        }

        public string Deleteusergroup(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("u_usergroupid ", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.Execute("usergroup_package_api.Deleteusergroup", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return "Notdelete";
            }
            else
            {
                return "deleted";
            }
        }

        public List<usergroup_api> GetAllusergroup()
        {
            IEnumerable<usergroup_api> result = dBContext.dbConnection.Query<usergroup_api>("usergroup_package_api.GetAllusergroup", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public usergroup_api GetusergroupById(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("u_usergroupid ", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<usergroup_api> result = dBContext.dbConnection.Query<usergroup_api>("usergroup_package_api.GetusergroupById", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public string UpDateusergroup(usergroup_api upd)
        {
            var parameter = new DynamicParameters();
            parameter.Add("u_usergroupid ", upd.usergroupid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("u_userid", upd.userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("u_groupid", upd.groupid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("usergroup_package_api.UpDateusergroup", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "NotUpDate";
            }
            else
            {
                return "UpDate";
            }
        }
    }
}
