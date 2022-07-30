using messanger.core.Data;
using messanger.core.Repoisitory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace messanger.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class salesController : ControllerBase
    {
        private readonly Isales_apirepoisitory sales_apirepoisitory;
        public salesController(Isales_apirepoisitory sales_apirepoisitory)
        {
            this.sales_apirepoisitory = sales_apirepoisitory;
        }

        [HttpGet]
        [Route("GetAllsales")]
        public List<sales_api> GetAllsales()
        {
            return sales_apirepoisitory.GetAllsales();
        }

        [HttpDelete]
        [Route("Deletesales/{id}")]
        public string Deletesales(int id)
        {
            return sales_apirepoisitory.Deletesales(id);
        }

        [HttpPost]
        [Route("Createsales")]
        public string Createsales([FromBody] sales_api cc)
        {
            return sales_apirepoisitory.Createsales(cc);
        }

        [HttpPut]
        [Route("UpDatesales")]
        public string UpDatesales([FromBody] sales_api cc)
        {
            return sales_apirepoisitory.UpDatesales(cc);
        }
        [HttpGet]
        [Route("GetsalesById/{id}")]
        public sales_api GetsalesById(int id)
        {
            return sales_apirepoisitory.GetsalesById(id);   

        }
    }
}
