using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.Repoisitory
{
    public interface Ivisa_apiRepoisitory
    {
        public List<visa_api> getallvisaid();
        public visa_api GetvisaById(int id);
        public string createvisa(visa_api ins);
        public string UpDatevisa(visa_api upd);
        public string Deletevisa(int id);
    }
}
