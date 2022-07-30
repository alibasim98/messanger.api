using messanger.core.Data;
using messanger.core.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace messanger.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class friendsController : ControllerBase
    {
        private readonly Ifrinds_apiservice friends_apiservice;
        public friendsController(Ifrinds_apiservice friends_apiservice)
        {
            this.friends_apiservice = friends_apiservice;
        }
        [HttpGet]
        [Route("GetAllfrinds")]
        public List<friends_api> GetAllfrinds()
        {
            return friends_apiservice.GetAllfrinds();   
        }

        [HttpDelete]
        [Route("Deletefrinds/{id}")]
        public string Deletefrinds(int id)
        {
            return friends_apiservice.Deletefrinds(id);

        }

        [HttpPost]
        [Route("Createfrinds")]
        public string Createfrinds([FromBody] friends_api cc)
        {
            return friends_apiservice.Createfrinds(cc);
        }

        [HttpPut]
        [Route("UpDatefrinds")]
        public string UpDatefrinds([FromBody] friends_api cc)
        {
            return friends_apiservice.UpDatefrinds(cc);
        }
        [HttpGet]
        [Route("GetfrindsById/{id}")]
        public friends_api GetfrindsById(int id)
        {
            return friends_apiservice.GetfrindsById(id);
        }





    }
}
