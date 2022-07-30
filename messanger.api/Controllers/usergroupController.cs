using messanger.core.Data;
using messanger.core.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace messanger.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usergroupController : ControllerBase
    {
        private readonly Iusergroup_apirervice usergroup_apiservice;
        public usergroupController(Iusergroup_apirervice usergroup_apiservice)
        {
            this.usergroup_apiservice = usergroup_apiservice;
        }

        [HttpGet]
        [Route("GetAllusergroup")]
        public List<usergroup_api> GetAllusergroup()
        {
            return usergroup_apiservice.GetAllusergroup();  
        }

        [HttpDelete]
        [Route("Deleteusergroup/{id}")]
        public string Deleteusergroup(int id)
        {
            return usergroup_apiservice.Deleteusergroup(id);

        }

        [HttpPost]
        [Route("Createusergroup")]
        public string Createusergroup([FromBody] usergroup_api cc)
        {
            return usergroup_apiservice.Createusergroup(cc);

        }

        [HttpPut]
        [Route("UpDateusergroup")]
        public string UpDateusergroup([FromBody] usergroup_api cc)
        {
            return usergroup_apiservice.UpDateusergroup(cc);

        }
        [HttpGet]
        [Route("GetusergroupById/{id}")]
        public usergroup_api GetusergroupById(int id)
        {
            return usergroup_apiservice.GetusergroupById(id);       
        }
    }
}
