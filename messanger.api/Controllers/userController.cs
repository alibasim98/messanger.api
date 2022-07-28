using messanger.core.Data;
using messanger.core.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace messanger.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly Iuser_apiservice user_apiservice;
        public userController(Iuser_apiservice user_apiservice)
        {
            this.user_apiservice = user_apiservice;
        }           
        [HttpGet]
        [Route("getalluser")]
        public List<user_api> getalluser()
        {
            return user_apiservice.getalluser();
        }
        [HttpDelete("{id}")]
        [Route("delete")]
        public string deleteuser(int id)
        {
            return user_apiservice.deleteuser(id);

        }

        [HttpPost]
        [Route("insertuser")]
        public string insertuser([FromBody] user_api cc)
        {
            return user_apiservice.insertuser(cc);
        }

        [HttpPut]
        [Route("updateuser")]
        public string updateuser([FromBody] user_api cc)
        {
            return user_apiservice.updateuser(cc);
        }
        [HttpGet("{id}")]
        [Route("getbyid")]
        public user_api getbyid(int id)
        {
            return user_apiservice.getbyid(id);
        }
    }
}
