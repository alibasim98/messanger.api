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
    public class message_apirepoisitory : Imessage_apiRepoisitory
    {
        private readonly IDBContext dBContext;
        public message_apirepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public string CreateMessage(message_api ins)
        {
            var parameter = new DynamicParameters();
            parameter.Add("m_message", ins.message, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("m_sender", ins.sender, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("m_receiver", ins.receiver, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("m_senddate", ins.senddate, dbType: DbType.Date, direction: ParameterDirection.Input);
            parameter.Add("m_gropID", ins.gropID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.dbConnection.ExecuteAsync("message_package_api.CreateMessage", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "NotInserted";
            }
            else
            {
                return "Inserted";
            }
        }

        public string DeleteMessage(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("m_message_Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.dbConnection.Execute("message_package_api.DeleteMessage", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return "Notdelete";
            }
            else
            {
                return "deleted";
            }
        }

        public List<message_api> filtermassegdate(message_api msg)
        {
            var parameter = new DynamicParameters();
            parameter.Add("m_startdate", msg.senddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameter.Add("M_enddate", msg.senddate,dbType: DbType.DateTime, direction: ParameterDirection.Input);
            IEnumerable<message_api> result = dBContext.dbConnection.Query<message_api>("message_package_api.filtermassegdate", parameter, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<message_api> filtermesseg(message_api msg)
        {
            var parameter = new DynamicParameters();
            parameter.Add("m_messege", msg.message, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<message_api> result = dBContext.dbConnection.Query<message_api>("message_package_api.filtermesseg", parameter, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<message_api> GetAllMessage()
        {
            IEnumerable<message_api> result = dBContext.dbConnection.Query<message_api>("message_package_api.GetAllMessage", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<countMessage> GetCountMessage()
        {
            IEnumerable<countMessage> result = dBContext.dbConnection.Query<countMessage>("message_package_api.GetCountMessage", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public message_api GetMessageById(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("m_message_Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<message_api> result = dBContext.dbConnection.Query<message_api>("message_package_api.GetMessageById", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public List<countmessageofeachuser> GettotlMessageEchuser()
        {
           
            IEnumerable<countmessageofeachuser> result = dBContext.dbConnection.Query<countmessageofeachuser>("message_package_api.GettotlMessageEchuser", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public string UpDateMessage(message_api upd)
        {
            var parameter = new DynamicParameters();
            parameter.Add("m_message_Id", upd.message_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("m_message", upd.message, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("m_sender", upd.sender, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("m_receiver", upd.receiver, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("m_senddate", upd.senddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameter.Add("m_gropID", upd.gropID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dBContext.dbConnection.ExecuteAsync("message_package_api.UpDateMessage", parameter, commandType: CommandType.StoredProcedure);

            if (result == null)
            {

                return "UpDateMessage";
            }
            else
            {
                return "UpDateMessage";
            }
        }
    }
}
