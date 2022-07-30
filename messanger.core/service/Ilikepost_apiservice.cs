using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.service
{
    public interface Ilikepost_apiservice
    {
        public List<likepost_api> GetAllLike();
        public string CreateLike(likepost_api ins);
        public string DeleteLike(int id);
    }
}
