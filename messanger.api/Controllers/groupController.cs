using messanger.core.Data;
using messanger.core.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace messanger.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class groupController : ControllerBase
    {
        private readonly Igroup_apiservice group_apiservice  ;
        public groupController(Igroup_apiservice group_apiservice)
        {
            this.group_apiservice = group_apiservice;
        }
        [HttpGet]
        [Route("GetAllgroup")]
        public List<group_api> GetAllgroup()
        {
            return group_apiservice.GetAllgroup();
        }

        [HttpDelete]
        [Route("Deletegroup/{id}")]
        public string Deletegroup(int id)
        {
            return group_apiservice.Deletegroup(id);

        }

        [HttpPost]
        [Route("Creategroup")]
        public string Creategroup([FromBody] group_api cc)
        {
            return group_apiservice.Creategroup(cc);
        }

        [HttpPut]
        [Route("UpDategroup")]
        public string UpDategroup([FromBody] group_api cc)
        {
            return group_apiservice.UpDategroup(cc);
        }
        [HttpGet]
        [Route("GetgroupById/{id}")]
        public group_api GetgroupById(int id)
        {
            return group_apiservice.GetgroupById(id);   
        }
    }
}
