using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.service
{
    public interface IJwtService
    {
        public string Auth(logins_api login);
    }
}
