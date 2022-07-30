using messanger.core.Data;
using messanger.core.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace messanger.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class categoryController : ControllerBase
    {
        private readonly Icategory_apiservice icategory_Apiservice;
        public categoryController(Icategory_apiservice icategory_Apiservice)
        {
            this.icategory_Apiservice = icategory_Apiservice;
        }
        [HttpGet]
        [Route("GetAllCategory")]
        public List<category_api> GetAllCategory()
        {
            return icategory_Apiservice.GetAllCategory();
        }
        [HttpDelete]
        [Route("DeleteCategory/{id}")]
        public string DeleteCategory(int id)
        {
            return icategory_Apiservice.DeleteCategory(id);

        }
        [HttpPost]
        [Route("CreateCategory")]
        public string CreateCategory([FromBody] category_api cc)
        {
            return icategory_Apiservice.CreateCategory(cc);
        }

        [HttpPut]
        [Route("UpDateCategory")]
        public string UpDateCategory([FromBody] category_api cc)
        {
            return icategory_Apiservice.UpDateCategory(cc);
        }
        [HttpGet]
        [Route("GetCategoryById/{id}")]
        public category_api GetCategoryById(int id)
        {
            return icategory_Apiservice.GetCategoryById(id);
        }
    }
}
