using messanger.core.Data;
using messanger.core.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace messanger.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class serviceController : ControllerBase
    {
        private readonly Iservice_apiservice service_apiservice ;
        public serviceController(Iservice_apiservice service_apiservice)
        {
            this.service_apiservice = service_apiservice;
        }
        [HttpGet]
        [Route("GetAllService")]
        public List<service_api> GetAllService()
        {
            return service_apiservice.GetAllService();
        }

        [HttpDelete]
        [Route("DeleteService/{id}")]
        public string DeleteService(int id)
        {
            return service_apiservice.DeleteService(id);
        }

        [HttpPost]
        [Route("CreateService")]
        public string CreateService([FromBody] service_api cc)
        {
            return service_apiservice.CreateService(cc);
        }

        [HttpPut]
        [Route("UpDateService")]
        public string UpDateService([FromBody] service_api cc)
        {
            return service_apiservice.UpDateService(cc);
        }
        [HttpGet]
        [Route("GetServiceById/{id}")]
        public service_api GetServiceById(int id)
        {
            return service_apiservice.GetServiceById(id);
        }
    }
}
