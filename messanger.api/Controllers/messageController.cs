using messanger.core.Data;
using messanger.core.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace messanger.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class messageController : ControllerBase
    {
        private readonly Imessage_apiservice message_apiservice ;
        public messageController(Imessage_apiservice message_apiservice)
        {
            this.message_apiservice = message_apiservice;
        }
        [HttpGet]
        [Route("GetAllMessage")]
        public List<message_api> GetAllMessage()
        {
            return message_apiservice.GetAllMessage();
        }

        [HttpDelete]
        [Route("DeleteMessage/{id}")]
        public string DeleteMessage(int id)
        {
            return message_apiservice.DeleteMessage(id);    

        }

        [HttpPost]
        [Route("CreateMessage")]
        public string CreateMessage([FromBody] message_api cc)
        {
            return message_apiservice.CreateMessage(cc);
        }

        [HttpPut]
        [Route("UpDateMessage")]
        public string updateuser([FromBody] message_api cc)
        {
            return message_apiservice.UpDateMessage(cc);
        }
        [HttpGet]
        [Route("GetMessageById/{id}")]
        public message_api GetMessageById(int id)
        {
            return message_apiservice.GetMessageById(id);
        }
    }
}
