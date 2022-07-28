using messanger.core.domain;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace messanger.infra.domain
{
    public class DbContext : IDBContext
    {
        private DbConnection connection;
        private IConfiguration Configuration;
 
        public DbContext(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }
        public DbConnection dbConnection
        {
            get
            {
                if (connection == null)
                {

                    connection = new OracleConnection(Configuration["ConnectionStrings:DBConnectionString"]);

                    connection.Open();
                }
                else if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                return connection;
            }
        }
    }
}
