using messanger.core.Data;
using messanger.core.Repoisitory;
using messanger.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.infra.service
{
    public class service_apiservice : Iservice_apiservice
    {
        private readonly Iservice_apiRepoisitory service_apirepoisitory  ;
        public service_apiservice(Iservice_apiRepoisitory service_apirepoisitory)
        {
            this.service_apirepoisitory = service_apirepoisitory;
        }
        public string CreateService(service_api ins)
        {
            return service_apirepoisitory.CreateService(ins);   
        }

        public string DeleteService(int id)
        {
            return service_apirepoisitory.DeleteService(id);    
        }

        public List<service_api> GetAllService()
        {
            return service_apirepoisitory.GetAllService();
        }

        public service_api GetServiceById(int id)
        {
            return service_apirepoisitory.GetServiceById(id);   
        }

        public string UpDateService(service_api upd)
        {
            return service_apirepoisitory.UpDateService(upd);   
        }
    }
}
