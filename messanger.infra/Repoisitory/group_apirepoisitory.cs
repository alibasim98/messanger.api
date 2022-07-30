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
    public class group_apirepoisitory : Igroup_apirepoisitory
    {
        private readonly IDBContext dBContext;
        public group_apirepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public string Creategroup(group_api ins)
        {
            var parameter = new DynamicParameters();
            parameter.Add("g_namegrop", ins.namegrop, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("group_package_api.Creategroup", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "NotInserted";
            }
            else
            {
                return "Inserted";
            }
        }

        public string Deletegroup(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("g_gropID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.Execute("group_package_api.Deletegroup", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return "Notdelete";
            }
            else
            {
                return "deleted";
            }
        }

        public List<group_api> GetAllgroup()
        {
            IEnumerable<group_api> result = dBContext.dbConnection.Query<group_api>("group_package_api.GetAllgroup", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public group_api GetgroupById(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("g_gropID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<group_api> result = dBContext.dbConnection.Query<group_api>("group_package_api.GetgroupById", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public string UpDategroup(group_api upd)
        {
            var parameter = new DynamicParameters();
            parameter.Add("g_gropID", upd.gropID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("g_namegrop", upd.namegrop, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("group_package_api.UpDategroup", parameter, commandType: CommandType.StoredProcedure);

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
