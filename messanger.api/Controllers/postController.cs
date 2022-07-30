using messanger.core.Data;
using messanger.core.Dto;
using messanger.core.Repoisitory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace messanger.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class postController : ControllerBase
    {
        private readonly Ipost_apiRepoisitory post_apirepoisitory ;
        public postController(Ipost_apiRepoisitory post_apirepoisitory)
        {
            this.post_apirepoisitory = post_apirepoisitory;
        }

        [HttpGet]
        [Route("GetAllpost")]
        public List<post_api> GetAllpost()
        {
            return post_apirepoisitory.GetAllpost();
        }

        [HttpDelete]
        [Route("Deletepost/{id}")]
        public string Deletepost(int id)
        {
            return post_apirepoisitory.Deletepost(id);
        }

        [HttpPost]
        [Route("Createpost")]
        public string Createpost([FromBody] post_api cc)
        {
            return post_apirepoisitory.Createpost(cc);
        }

        [HttpPut]
        [Route("UpDatepost")]
        public string UpDatepost([FromBody] post_api cc)
        {
            return post_apirepoisitory.UpDatepost(cc);
        }
        [HttpGet]
        [Route("GetpostById/{id}")]
        public post_api GetpostById(int id)
        {
            return post_apirepoisitory.GetpostById(id);
        }
        [HttpGet]
        [Route("Getnumoflikepost")]
        public List<Getnumoflikepost> Getnumoflikepost()
        {
            return post_apirepoisitory.Getnumoflikepost();
        }

    }
}
