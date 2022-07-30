using messanger.core.Data;
using messanger.core.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace messanger.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class visaController : ControllerBase
    {
        private readonly Ivisa_apiservice visa_apiservice;
        public visaController(Ivisa_apiservice visa_apiservice)
        {
            this.visa_apiservice = visa_apiservice;
        }

        [HttpGet]
        [Route("getallvisaid")]
        public List<visa_api> getallvisaid()
        {
            return visa_apiservice.getallvisaid();  
        }

        [HttpDelete]
        [Route("Deletevisa/{id}")]
        public string Deletevisa(int id)
        {
            return visa_apiservice.Deletevisa(id);

        }

        [HttpPost]
        [Route("createvisa")]
        public string createvisa([FromBody] visa_api cc)
        {
            return visa_apiservice.createvisa(cc);
        }

        [HttpPut]
        [Route("UpDatevisa")]
        public string UpDatevisa([FromBody] visa_api cc)
        {
            return visa_apiservice.UpDatevisa(cc);
        }
        [HttpGet]
        [Route("GetvisaById/{id}")]
        public visa_api GetvisaById(int id)
        {
            return visa_apiservice.GetvisaById(id);
        }
    }
}
