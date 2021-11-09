using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnivBE.Filters
{
    public class SecurityFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        { // runs before authorizing a secured request
            base.OnAuthorization(filterContext);
        }
    }
}