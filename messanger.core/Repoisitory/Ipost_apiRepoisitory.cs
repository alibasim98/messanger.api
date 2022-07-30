using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.Repoisitory
{
    public interface Ipost_apiRepoisitory
    {
        public List<post_api> GetAllpost();
        public post_api GetpostById(int id);
        public string Createpost(post_api ins);
        public string UpDatepost(post_api upd);
        public string Deletepost(int id);
    }
}
