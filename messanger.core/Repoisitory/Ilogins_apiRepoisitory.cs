using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.Repoisitory
{
    public  interface Ilogins_apiRepoisitory
    {
        public List<logins_api> GetAlllogins();
        public logins_api GetloginsById(int id);
        public string Createlogins(logins_api ins);
        public string UpDatelogins(logins_api upd);
        public string Deletelogins(int id);

    }
}
