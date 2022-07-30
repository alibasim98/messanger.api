using messanger.core.Data;
using messanger.core.Repoisitory;
using messanger.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.infra.service
{
    public class sales_apiservice : Isales_apiservice
    {
        private readonly Isales_apirepoisitory sales_apirepoisitory  ;
        public sales_apiservice(Isales_apirepoisitory sales_apirepoisitory)
        {
            this.sales_apirepoisitory = sales_apirepoisitory;
        }
        public string Createsales(sales_api ins)
        {
            return sales_apirepoisitory.Createsales(ins);   
        }

        public string Deletesales(int id)
        {
            return sales_apirepoisitory.Deletesales(id);
        }

        public List<sales_api> GetAllsales()
        {
            return sales_apirepoisitory.GetAllsales();   
        }

        public sales_api GetsalesById(int id)
        {
            return sales_apirepoisitory.GetsalesById(id);   
        }

        public string UpDatesales(sales_api upd)
        {
            return sales_apirepoisitory.UpDatesales(upd);    
        }
    }
}
