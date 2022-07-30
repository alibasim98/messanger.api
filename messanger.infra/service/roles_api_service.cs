using messanger.core.Data;
using messanger.core.Repoisitory;
using messanger.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.infra.service
{
    public class roles_api_service : Iroles_api_service
    {
        private readonly Iroles_api_Repoisitory roles_api_Repoisitory ;
        public roles_api_service(Iroles_api_Repoisitory roles_api_Repoisitory)
        {
            this.roles_api_Repoisitory = roles_api_Repoisitory;
        }
        public string Createroles(roles_api ins)
        {
            return roles_api_Repoisitory.Createroles(ins);
        }

        public string Deleteroles(int id)
        {
            return roles_api_Repoisitory.Deleteroles(id);   
        }

        public List<roles_api> GetAllroles()
        {
            return roles_api_Repoisitory.GetAllroles(); 

        }

        public roles_api GetrolesById(int id)
        {
            return roles_api_Repoisitory.GetrolesById(id);  

        }

        public string UpDateroles(roles_api upd)
        {
            return roles_api_Repoisitory.UpDateroles(upd); 

        }
    }
}
