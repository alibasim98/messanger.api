using Dapper;using messanger.core.Data;
using messanger.core.domain;
using messanger.core.Repoisitory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace messanger.infra.Repoisitory
{
    public class roles_api_Repoisitory : Iroles_api_Repoisitory
    {
        private readonly IDBContext dBContext;
        public roles_api_Repoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public string Createroles(roles_api ins)
        {
            var parameter = new DynamicParameters();
            parameter.Add("r_rolename ", ins.rolename, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("roles_package_api.Createroles", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "NotInserted";
            }
            else
            {
                return "Inserted";
            }
        }

        public string Deleteroles(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("r_idroles", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.Execute("roles_package_api.Deleteroles", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return "Notdelete";
            }
            else
            {
                return "deleted";
            }
        }

        public List<roles_api> GetAllroles()
        {
            IEnumerable<roles_api> result = dBContext.dbConnection.Query<roles_api>("roles_package_api.GetAllroles", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public roles_api GetrolesById(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("r_idroles", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<roles_api> result = dBContext.dbConnection.Query<roles_api>("roles_package_api.GetrolesById", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public string UpDateroles(roles_api upd)
        {
            var parameter = new DynamicParameters();
            parameter.Add("r_idroles ", upd.idroles, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("r_rolename ", upd.rolename, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("roles_package_api.UpDateroles", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "NotInserted";
            }
            else
            {
                return "Inserted";
            }
        }
    }
}
