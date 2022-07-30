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
    public class friends_apirepoisitory : Ifrinds_apiRepoisitory
    {
        private readonly IDBContext dBContext;
        public friends_apirepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public string Createfrinds(friends_api ins)
        {
            var parameter = new DynamicParameters();
            parameter.Add("f_RequestDate ", ins.RequestDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameter.Add("f_userId", ins.userId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("f_frind_id", ins.frind_id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.dbConnection.ExecuteAsync("frinds_package_api.Createfrinds", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "NotInserted";
            }
            else
            {
                return "Inserted";
            }
        }

        public string Deletefrinds(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("f_friendsid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.Execute("frinds_package_api.Deletefrinds", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return "Notdelete";
            }
            else
            {
                return "deleted";
            }
        }

        public List<friends_api> GetAllfrinds()
        {
            IEnumerable<friends_api> result = dBContext.dbConnection.Query<friends_api>("frinds_package_api.GetAllfrinds", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public friends_api GetfrindsById(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("f_friendsid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<friends_api> result = dBContext.dbConnection.Query<friends_api>("frinds_package_api.GetMyfrinds", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public string UpDatefrinds(friends_api upd)
        {

                var parameter = new DynamicParameters();
                parameter.Add("f_friendsid", upd.friendsid, dbType: DbType.Int32, direction: ParameterDirection.Input);
                parameter.Add("f_RequestDate", upd.RequestDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                parameter.Add("f_userId", upd.userId, dbType: DbType.Int32, direction: ParameterDirection.Input);
                parameter.Add("f_frind_id", upd.frind_id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                var result = dBContext.dbConnection.ExecuteAsync("frinds_package_api.UpDatefrinds", parameter, commandType: CommandType.StoredProcedure);

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
