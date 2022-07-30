using Dapper;
using messanger.core.Data;
using messanger.core.Repoisitory;
using messanger.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.infra.service
{
    public class friends_apiservice : Ifrinds_apiservice
    {
        private readonly Ifrinds_apiRepoisitory friends_apirepoisitory ;
        public friends_apiservice(Ifrinds_apiRepoisitory friends_apirepoisitory)
        {
            this.friends_apirepoisitory = friends_apirepoisitory;
        }
        public string Createfrinds(friends_api ins)
        {
            return friends_apirepoisitory.Createfrinds(ins);    
        }

        public string Deletefrinds(int id)
        {
            return friends_apirepoisitory.Deletefrinds(id);
        }

        public List<friends_api> GetAllfrinds()
        {
            return friends_apirepoisitory.GetAllfrinds();
        }

        public friends_api GetfrindsById(int id)
        {
            return friends_apirepoisitory.GetfrindsById(id);
        }

        public string UpDatefrinds(friends_api upd)
        {
            return friends_apirepoisitory.UpDatefrinds(upd);
        }
    }
}
