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
    public class logins_apiRepoisitory : Ilogins_apiRepoisitory
    {
        private readonly IDBContext dBContext;
        public logins_apiRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public string Createlogins(logins_api ins)
        {
            var parameter = new DynamicParameters();
            parameter.Add("l_username", ins.username, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("l_password", ins.password, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("l_role_id", ins.role_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("logins_package_api.Createlogins", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "NotInserted";
            }
            else
            {
                return "Inserted";
            }
        }

        public string Deletelogins(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("l_idlogin", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.Execute("logins_package_api.Deletelogins", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return "Notdelete";
            }
            else
            {
                return "deleted";
            }
        }

        public List<logins_api> GetAlllogins()
        {
            IEnumerable<logins_api> result = dBContext.dbConnection.Query<logins_api>("logins_package_api.GetAlllogins", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public logins_api GetloginsById(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("l_idlogin", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<logins_api> result = dBContext.dbConnection.Query<logins_api>("logins_package_api.GetloginsById", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public string UpDatelogins(logins_api upd)
        {
            var parameter = new DynamicParameters();
            parameter.Add("l_idlogin", upd.idlogin, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("l_username", upd.username, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("l_password", upd.password, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("l_role_id", upd.role_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("logins_package_api.UpDatelogins", parameter, commandType: CommandType.StoredProcedure);

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
