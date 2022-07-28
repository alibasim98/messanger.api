using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.Data
{
    public  class message_api
    {
     public int message_Id { get; set; }
     public string message { get; set; }
     public int sender { get; set; }    
     public int receiver { get; set; }  
    public  DateTime senddate { get; set; } 
    public int gropID { get; set; }  

    }
}
