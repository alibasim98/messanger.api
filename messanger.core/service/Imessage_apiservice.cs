using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.service
{
    public interface Imessage_apiservice
    {
        public List<message_api> GetAllMessage();
        public message_api GetMessageById(int id);
        public string CreateMessage(message_api ins);
        public string UpDateMessage(message_api upd);
        public string DeleteMessage(int id);
    }
}
