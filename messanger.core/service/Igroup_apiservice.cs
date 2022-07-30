using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.service
{
    public  interface Igroup_apiservice
    {
        public List<group_api> GetAllgroup();
        public group_api GetgroupById(int id);
        public string Creategroup(group_api ins);
        public string UpDategroup(group_api upd);
        public string Deletegroup(int id);
    }
}
