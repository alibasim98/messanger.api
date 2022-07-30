using Dapper;
using messanger.core.Data;
using messanger.core.domain;
using messanger.core.Dto;
using messanger.core.Repoisitory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace messanger.infra.Repoisitory
{
    public class user_apirepoisitory : Iuser_apiRepoisitory
    {
        private readonly IDBContext dBContext ;
        public user_apirepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public string deleteuser(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("u_usertid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.Execute("user_package_api.deleteuser", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
            return "Notdelete";
            }
            else
            {
                return "deleted";
            }
           
        }

        public List<user_api> getalluser()
        {
            IEnumerable<user_api> result = dBContext.dbConnection.Query<user_api>("user_package_api.getalluser", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public user_api getbyid(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("u_usertid ", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<user_api> result = dBContext.dbConnection.Query<user_api>("user_package_api.getbyid", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public List<getcountcuntre> getcountcuntre()
        {
            IEnumerable<getcountcuntre> result = dBContext.dbConnection.Query<getcountcuntre>("user_package_api.getcountcuntre", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<getvisaechuser> getvisaechuser()
        {
            IEnumerable<getvisaechuser> result = dBContext.dbConnection.Query<getvisaechuser>("user_package_api.getvisaechuser", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public string insertuser(user_api ins)
        {
             
            var parameter = new DynamicParameters();
            parameter.Add("u_FirstName", ins.FirstName, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("u_salary", ins.salary, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("u_country", ins.country, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("u_Email", ins.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("u_Login_id", ins.Login_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("user_package_api.insertuser", parameter, commandType: CommandType.StoredProcedure);

            if (result ==null)
            {

                return "NotInserted";
            }
            else
            {
                return "Inserted";
            }
            
            
        }
       
        public string updateuser(user_api upd)
        {
            var parameter = new DynamicParameters();
            parameter.Add("u_usertid", upd.usertid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("u_FirstName ", upd.FirstName, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("u_salary", upd.salary, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("u_Email", upd.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("u_country", upd.country, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("u_Login_id ", upd.Login_id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.dbConnection.ExecuteAsync("user_package_api.updateuser", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "Notupdate";
            }
            else
            {
                return "update";
            }

           
        }
    }
}
