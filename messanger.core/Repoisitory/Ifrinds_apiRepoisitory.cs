using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.Repoisitory
{
    public  interface Ifrinds_apiRepoisitory
    {
        public List<friends_api> GetAllfrinds();
        public friends_api GetfrindsById(int id);
        public string Createfrinds(friends_api ins);
        public string UpDatefrinds(friends_api upd);
        public string Deletefrinds(int id);
        
    }
}
