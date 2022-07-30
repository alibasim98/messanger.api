using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.Repoisitory
{
    public interface Ilikepost_apiRepoisitory
    {
        public List<likepost_api> GetAllLike();
        public string CreateLike(likepost_api ins);
        public string DeleteLike(int id);
        
        

    }
}
