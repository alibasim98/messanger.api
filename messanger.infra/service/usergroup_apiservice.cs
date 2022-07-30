using messanger.core.Data;
using messanger.core.Repoisitory;
using messanger.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.infra.service
{
    public class usergroup_apiservice : Iusergroup_apirervice
    {
         
        private readonly Iusergroup_apiRepoisitory usergroup_apiRepoisitory;
        public usergroup_apiservice(Iusergroup_apiRepoisitory usergroup_apiRepoisitory)
        {
            this.usergroup_apiRepoisitory = usergroup_apiRepoisitory;
        }
        public string Createusergroup(usergroup_api ins)
        {
            return usergroup_apiRepoisitory.Createusergroup(ins);
        }

        public string Deleteusergroup(int id)
        {
            return usergroup_apiRepoisitory.Deleteusergroup(id);    
        }

        public List<usergroup_api> GetAllusergroup()
        {
            return usergroup_apiRepoisitory.GetAllusergroup();  
        }

        public usergroup_api GetusergroupById(int id)
        {
            return usergroup_apiRepoisitory.GetusergroupById(id);   
        }

        public string UpDateusergroup(usergroup_api upd)
        {
            return usergroup_apiRepoisitory.UpDateusergroup(upd);   
        }
    }
}
