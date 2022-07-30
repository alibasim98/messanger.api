using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.Repoisitory
{
    public  interface Isales_apirepoisitory
    {
        public List<sales_api> GetAllsales();
        public sales_api GetsalesById(int id);
        public string Createsales(sales_api ins);
        public string UpDatesales(sales_api upd);
        public string Deletesales(int id);



    }
}
