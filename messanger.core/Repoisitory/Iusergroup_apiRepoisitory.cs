using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.Repoisitory
{
    public  interface Iusergroup_apiRepoisitory
    {
        public List<usergroup_api> GetAllusergroup();
        public usergroup_api GetusergroupById(int id);
        public string Createusergroup(usergroup_api ins);
        public string UpDateusergroup(usergroup_api upd);
        public string Deleteusergroup(int id);


    }
}
