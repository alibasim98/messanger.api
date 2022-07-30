using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.service
{
    public interface Iroles_api_service
    {
        public List<roles_api> GetAllroles();
        public roles_api GetrolesById(int id);
        public string Createroles(roles_api ins);
        public string UpDateroles(roles_api upd);
        public string Deleteroles(int id);
    }
}
