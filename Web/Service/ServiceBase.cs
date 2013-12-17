using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Model;

namespace Web.Service
{
    public abstract class ServiceBase :ServiceStack.Service
    {
        protected CustomUserSession UserSession
        {
            get
            {
                return base.SessionAs<CustomUserSession>();
            }
        }
    }
}