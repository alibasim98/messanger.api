using messanger.core.Data;
using messanger.core.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace messanger.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class rolesController : ControllerBase
    {
        private readonly Iroles_api_service roles_api_service  ;
        public rolesController(Iroles_api_service roles_api_service)
        {
            this.roles_api_service = roles_api_service;
        }
        [HttpGet]
        [Route("GetAllroles")]
        public List<roles_api> GetAllroles()
        {
            return roles_api_service.GetAllroles(); 
        }

        [HttpDelete]
        [Route("Deleteroles/{id}")]
        public string Deleteroles(int id)
        {
            return roles_api_service.Deleteroles(id);       
        }

        [HttpPost]
        [Route("Createroles")]
        public string Createroles([FromBody] roles_api cc)
        {
            return roles_api_service.Createroles(cc);        
        }

        [HttpPut]
        [Route("UpDateroles")]
        public string UpDateroles([FromBody] roles_api cc)
        {
            return roles_api_service.UpDateroles(cc);   
        }
        [HttpGet]
        [Route("GetrolesById/{id}")]
        public roles_api GetrolesById(int id)
        {
            return roles_api_service.GetrolesById(id);  
        }
    }
}
