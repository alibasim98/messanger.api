using messanger.core.Data;
using messanger.core.Repoisitory;
using messanger.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.infra.service
{
    public class user_apiservice : Iuser_apiservice
    {
        private readonly Iuser_apiRepoisitory user_apiRepoisitory;
        public user_apiservice(Iuser_apiRepoisitory user_apiRepoisitory)
        {
            this.user_apiRepoisitory = user_apiRepoisitory; 
        }
        public string deleteuser(int id)
        {
           return user_apiRepoisitory.deleteuser(id);
        }

        public List<user_api> getalluser()
        {
            return user_apiRepoisitory.getalluser();    
        }

        public user_api getbyid(int id)
        {
           return user_apiRepoisitory.getbyid(id);  
        }

        public string insertuser(user_api ins)
        {
            return user_apiRepoisitory.insertuser(ins);
        }

        public string updateuser(user_api upd)
        {
            return user_apiRepoisitory.updateuser(upd);
        }
    }
}
