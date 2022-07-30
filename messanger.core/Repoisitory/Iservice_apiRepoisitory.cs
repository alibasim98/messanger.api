using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.Repoisitory
{
    public  interface Iservice_apiRepoisitory
    {
        public List<service_api> GetAllService();
        public service_api GetServiceById(int id);
        public string CreateService(service_api ins);
        public string UpDateService(service_api upd);
        public string DeleteService(int id);
    }
}
