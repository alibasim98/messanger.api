using messanger.core.Data;
using messanger.core.Repoisitory;
using messanger.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.infra.service
{
    public class group_apiservice : Igroup_apiservice
    {
        private readonly Igroup_apirepoisitory group_apirepoisitory ;
        public group_apiservice(Igroup_apirepoisitory group_apirepoisitory)
        {
            this.group_apirepoisitory = group_apirepoisitory;
        }
        public string Creategroup(group_api ins)
        {
            return group_apirepoisitory.Creategroup(ins);
        }

        public string Deletegroup(int id)
        {
            return group_apirepoisitory.Deletegroup(id);    
        }

        public List<group_api> GetAllgroup()
        {
            return group_apirepoisitory.GetAllgroup();
        }

        public group_api GetgroupById(int id)
        {
            return group_apirepoisitory.GetgroupById(id);   
        }

        public string UpDategroup(group_api upd)
        {
            return group_apirepoisitory.UpDategroup(upd);
        }
    }
}
