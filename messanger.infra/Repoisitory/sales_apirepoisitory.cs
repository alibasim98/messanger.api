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
    public class sales_apirepoisitory : Isales_apirepoisitory
    {
        private readonly IDBContext dBContext;
        public sales_apirepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public string Createsales(sales_api ins)
        {
            var parameter = new DynamicParameters();
            parameter.Add("s_userId", ins.userId, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("s_serviceid", ins.serviceid, dbType: DbType.Double, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("sales_package_api.Createsales", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "NotInserted";
            }
            else
            {
                return "Inserted";
            }
        }

        public string Deletesales(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("s_sales_id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.Execute("sales_package_api.Deletesales", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return "Notdelete";
            }
            else
            {
                return "deleted";
            }
        }

        public List<sales_api> GetAllsales()
        {
            IEnumerable<sales_api> result = dBContext.dbConnection.Query<sales_api>("sales_package_api.GetAllsales", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public sales_api GetsalesById(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("s_sales_id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<sales_api> result = dBContext.dbConnection.Query<sales_api>("sales_package_api.GetsalesById", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public string UpDatesales(sales_api upd)
        {
            var parameter = new DynamicParameters();
            parameter.Add("s_sales_id", upd.sales_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("s_userId", upd.userId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("s_serviceid", upd.serviceid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("sales_package_api.UpDatesales", parameter, commandType: CommandType.StoredProcedure);

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
