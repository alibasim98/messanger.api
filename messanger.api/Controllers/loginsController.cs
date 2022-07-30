using messanger.core.Data;
using messanger.core.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace messanger.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginsController : ControllerBase
    {
        private readonly Ilogins_apiservice logins_apiservice  ;
        public loginsController(Ilogins_apiservice logins_apiservice)
        {
            this.logins_apiservice = logins_apiservice;
        }
        [HttpGet]
        [Route("GetAlllogins")]
        public List<logins_api> GetAlllogins()
        {
            return logins_apiservice.GetAlllogins();
        }

        [HttpPost]
        [Route("Createlogins")]
        public string Createlogins([FromBody] logins_api cc)
        {
            return logins_apiservice.Createlogins(cc);
        }

        [HttpDelete]
        [Route("Deletelogins/{id}")]
        public string Deletelogins(int id)
        {
            return logins_apiservice.Deletelogins(id);      

        }

        [HttpPost]
        [Route("UpDatelogins")]
        public string UpDatelogins([FromBody] logins_api cc)
        {
            return logins_apiservice.UpDatelogins(cc);  
        }
        [HttpGet]
        [Route("GetloginsById/{id}")]
        public logins_api GetloginsById(int id)
        {
            return logins_apiservice.GetloginsById(id);

        }
    }
}
