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
    public class service_apirepoisitory : Iservice_apiRepoisitory
    {
        private readonly IDBContext dBContext;
        public service_apirepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public string CreateService(service_api ins)
        {
            var parameter = new DynamicParameters();
            parameter.Add("s_servicename", ins.servicename, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("s_price", ins.price, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("s_categoryid", ins.categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("service_package_api.CreateService", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "NotInserted";
            }
            else
            {
                return "Inserted";
            }
        }

        public string DeleteService(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("s_serviceid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.Execute("service_package_api.DeleteService", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return "Notdelete";
            }
            else
            {
                return "deleted";
            }
        }

        public List<service_api> GetAllService()
        {
            IEnumerable<service_api> result = dBContext.dbConnection.Query<service_api>("service_package_api.GetAllService", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public service_api GetServiceById(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("s_serviceid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<service_api> result = dBContext.dbConnection.Query<service_api>("service_package_api.GetServiceById", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public string UpDateService(service_api upd)
        {
            var parameter = new DynamicParameters();
            parameter.Add("s_serviceid", upd.serviceid, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("s_servicename", upd.servicename, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("s_price", upd.price, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("s_categoryid", upd.categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("service_package_api.UpDateService", parameter, commandType: CommandType.StoredProcedure);

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
