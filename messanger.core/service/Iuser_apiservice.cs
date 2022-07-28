using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.service
{
    public  interface Iuser_apiservice
    {
        public List<user_api> getalluser();
        public user_api getbyid(int id);
        public string insertuser(user_api ins);
        public string updateuser(user_api upd);
        public string deleteuser(int id);
    }
}
