using messanger.core.Data;
using messanger.core.Repoisitory;
using messanger.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.infra.service
{
    public class likepost_apiservice : Ilikepost_apiservice
    {
        private readonly Ilikepost_apiRepoisitory likepost_apirepoisitory ;
        public likepost_apiservice(Ilikepost_apiRepoisitory likepost_apirepoisitory)
        {
            this.likepost_apirepoisitory = likepost_apirepoisitory;
        }
        public string CreateLike(likepost_api ins)
        {
            return likepost_apirepoisitory.CreateLike(ins);
        }
        public string DeleteLike(int id)
        {
            return likepost_apirepoisitory.DeleteLike(id);
        }

        public List<likepost_api> GetAllLike()
        {
            return likepost_apirepoisitory.GetAllLike();    
        }
    }
}
