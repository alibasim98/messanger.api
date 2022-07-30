using messanger.core.Data;
using messanger.core.Repoisitory;
using messanger.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.infra.service
{
    public class visa_apiservice : Ivisa_apiservice
    {
        private readonly Ivisa_apiRepoisitory visa_apirepoisitory ;
        public visa_apiservice(Ivisa_apiRepoisitory visa_apirepoisitory)
        {
            this.visa_apirepoisitory = visa_apirepoisitory;
        }
        public string createvisa(visa_api ins)
        {
            return visa_apirepoisitory.createvisa(ins); 
        }

        public string Deletevisa(int id)
        {
            return visa_apirepoisitory.Deletevisa(id);  
        }

        public List<visa_api> getallvisaid()
        {
            return visa_apirepoisitory.getallvisaid();  
        }

        public visa_api GetvisaById(int id)
        {
            return visa_apirepoisitory.GetvisaById(id); 
        }

        public string UpDatevisa(visa_api upd)
        {
            return visa_apirepoisitory.UpDatevisa(upd);
        }
    }
}
