using messanger.core.Data;
using messanger.core.Repoisitory;
using messanger.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.infra.service
{
    public class logins_apiservice : Ilogins_apiservice
    {
        private readonly Ilogins_apiRepoisitory logins_apiRepoisitory;
        public logins_apiservice(Ilogins_apiRepoisitory logins_apiRepoisitory)
        {
            this.logins_apiRepoisitory = logins_apiRepoisitory;
        }
        public string Createlogins(logins_api ins)
        {
            return logins_apiRepoisitory.Createlogins(ins); 
        }

        public string Deletelogins(int id)
        {
           return logins_apiRepoisitory.Deletelogins  (id); 
        }

        public List<logins_api> GetAlllogins()
        {
            return logins_apiRepoisitory.GetAlllogins   (); 
        }

        public logins_api GetloginsById(int id)
        {
            return logins_apiRepoisitory.GetloginsById (id);    
        }

        public string UpDatelogins(logins_api upd)
        {
            return logins_apiRepoisitory.UpDatelogins (upd);    
        }
    }
}
