using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.Repoisitory
{
    public  interface Iuser_apiRepoisitory
    {
        public List<user_api> getalluser();
        public user_api getbyid(int id);
        public string insertuser(user_api ins);
        public string updateuser(user_api upd);
        public string deleteuser(int id);
    }
}
