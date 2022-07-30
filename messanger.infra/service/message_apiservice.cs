using messanger.core.Data;
using messanger.core.Repoisitory;
using messanger.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.infra.service
{
    public class message_apiservice : Imessage_apiservice
    {
        private readonly Imessage_apiRepoisitory message_apirepoisitory;
        public message_apiservice(Imessage_apiRepoisitory message_apirepoisitory)
        {
            this.message_apirepoisitory = message_apirepoisitory;
        }
        public string CreateMessage(message_api ins)
        {
            return this.CreateMessage(ins);    
        }

        public string DeleteMessage(int id)
        {
            return this.DeleteMessage(id); 
        }

        public List<message_api> GetAllMessage()
        {
            return message_apirepoisitory.GetAllMessage();      
        }

        public message_api GetMessageById(int id)
        {
            return message_apirepoisitory.GetMessageById(id);     
        }

        public string UpDateMessage(message_api upd)
        {
            return message_apirepoisitory.UpDateMessage(upd);   
        }
    }
}
