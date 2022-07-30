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
    public class visa_apirepoisitory : Ivisa_apiRepoisitory
    {
        private readonly IDBContext dBContext;
        public visa_apirepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public string createvisa(visa_api ins)
        {
            var parameter = new DynamicParameters();
            parameter.Add("v_balance", ins.balance, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("v_CNumber", ins.CNumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("v_enddate", ins.enddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameter.Add("v_Cname", ins.Cname, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("v_userid", ins.userid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.dbConnection.ExecuteAsync("visa_package_api.createvisa", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "NotInserted";
            }
            else
            {
                return "Inserted";
            }
        }

        public string Deletevisa(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("v_visaid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.Execute("visa_package_api.Deletevisa", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return "Notdelete";
            }
            else
            {
                return "deleted";
            }

        }

        public List<visa_api> getallvisaid()
        {
            IEnumerable<visa_api> result = dBContext.dbConnection.Query<visa_api>("visa_package_api.getallvisaid", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public visa_api GetvisaById(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("v_visaid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<visa_api> result = dBContext.dbConnection.Query<visa_api>("visa_package_api.GetvisaById", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public string UpDatevisa(visa_api upd)
        {
            var parameter = new DynamicParameters();
            parameter.Add("v_visaid", upd.visaid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("v_balance", upd.balance, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("v_CNumber", upd.CNumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("v_enddate", upd.enddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameter.Add("v_Cname", upd.Cname, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("v_userid", upd.userid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.dbConnection.ExecuteAsync("visa_package_api.UpDatevisa", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "Not update";
            }
            else
            {
                return "Update";
            }
        }
    }
}
