using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace messanger.core.Data
{
    public class user_api
    {
        [Key]
        public int usertid  { get; set; } 
        public string FirstName { get; set; }
        public  double salary { get; set; }
        public string Email { get; set; }
        public string country { get; set; }
        public int Login_id { get; set; }
    }
}
