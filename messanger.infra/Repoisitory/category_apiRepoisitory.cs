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
    public  class category_apiRepoisitory: Icategory_apiRepoisitory
    {
        private readonly IDBContext dBContext;
        public category_apiRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public string CreateCategory(category_api ins)
        {
            var parameter = new DynamicParameters();
            parameter.Add("c_categoryname ", ins.categoryname, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("category_package_api.CreateCategory", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "NotInserted";
            }
            else
            {
                return "Inserted";
            }
        }

        public string DeleteCategory(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("c_categoryid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.Execute("category_package_api.DeleteCategory", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return "Notdelete";
            }
            else
            {
                return "deleted";
            }
        }

        public List<category_api> GetAllCategory()
        {
            IEnumerable<category_api> result = dBContext.dbConnection.Query<category_api>("category_package_api.GetAllCategory", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public category_api GetCategoryById(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("c_categoryid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<category_api> result = dBContext.dbConnection.Query<category_api>("category_package_api.GetCategoryById", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public string UpDateCategory(category_api upd)
        {
            var parameter = new DynamicParameters();
            parameter.Add("c_categoryid", upd.categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("c_categoryname ", upd.categoryname, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.ExecuteAsync("category_package_api.UpDateCategory", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "Not Update";
            }
            else
            {
                return "Update";
            }
        }
    }
}
