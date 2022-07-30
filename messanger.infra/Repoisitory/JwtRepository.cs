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
    public class JwtRepository : IJwtRepository
    {

        private readonly IDBContext dBContext;
        public JwtRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public logins_api Auth(logins_api login)
        {
            var p = new DynamicParameters();
            p.Add("User_NAME", login.username, dbType: DbType.String,direction: ParameterDirection.Input);
            p.Add("PASS", login.password, dbType: DbType.String,direction: ParameterDirection.Input);
            IEnumerable<logins_api> result =dBContext.dbConnection.Query<logins_api>("UserLogin", p,commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
