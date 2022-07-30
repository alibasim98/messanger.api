using messanger.core.Data;
using messanger.core.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace messanger.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class likepostController : ControllerBase
    {
        private readonly Ilikepost_apiservice likepost_apiservice  ;
        public likepostController(Ilikepost_apiservice likepost_apiservice)
        {
            this.likepost_apiservice = likepost_apiservice;
        }
        [HttpGet]
        [Route("GetAllLike")]
        public List<likepost_api> GetAllLike()
        {
            return likepost_apiservice.GetAllLike();
        }

        [HttpDelete]
        [Route("DeleteLike/{id}")]
        public string DeleteLike(int id)
        {
            return likepost_apiservice.DeleteLike(id);

        }

        [HttpPost]
        [Route("CreateLike")]
        public string CreateLike([FromBody] likepost_api cc)
        {
            return likepost_apiservice.CreateLike(cc);
        }
    }
}
