using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace messanger.core.Data
{
    public class visa_api
    {
    [Key]
    public int visaid { get; set; }
    public double balance { get; set; }

    public int CNumber { get; set; }
    public DateTime enddate { get; set; }
    public string Cname { get; set; }   
    public int userid { get; set; } 
    }
}
