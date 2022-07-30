using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace messanger.core.Data
{
    public class category_api
    {
        [Key]
        public int categoryid { get; set; }
        public string categoryname {get;set;}
    }
}
