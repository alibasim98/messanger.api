using messanger.core.Data;
using messanger.core.Dto;
using messanger.core.Repoisitory;
using messanger.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.infra.service
{
    public class post_apiservice : Ipost_apiservice
    {
        private readonly Ipost_apiRepoisitory post_apirepoisitory  ;
        public post_apiservice(Ipost_apiRepoisitory post_apirepoisitory)
        {
            this.post_apirepoisitory = post_apirepoisitory;
        }
        public string Createpost(post_api ins)
        {
            return post_apirepoisitory.Createpost(ins); 
        }

        public string Deletepost(int id)
        {
            return post_apirepoisitory.Deletepost(id);
        }

        public List<post_api> GetAllpost()
        {
            return post_apirepoisitory.GetAllpost();    
        }

        public List<Getnumoflikepost> Getnumoflikepost()
        {
            return post_apirepoisitory.Getnumoflikepost();
        }

        public post_api GetpostById(int id)
        {
            return post_apirepoisitory.GetpostById(id); 

        }

        public string UpDatepost(post_api upd)
        {
            return post_apirepoisitory.UpDatepost(upd); 
        }
    }
}
