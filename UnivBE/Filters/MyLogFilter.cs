using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UnivBE.Filters
{
    public class MyLogFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext) // before
        {
            CreateLog("ActionExecuting", filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext) // after
        {
            CreateLog("ActionExecuted", filterContext.RouteData);

        }

        public override void OnResultExecuting(ResultExecutingContext filterContext) 
        {
            CreateLog("Result Executing", filterContext.RouteData);

        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            CreateLog("Result Executed", filterContext.RouteData);

        }

        public void CreateLog(string EventName, RouteData routeData)
        {
            var ctrlname = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var msg = EventName + " : Action - " + actionName + " : Controller - " + ctrlname;
            // All this data captured can be written to txt file or db in real project 
            // for now we will display this in console to find its execution
            Debug.WriteLine(msg, "Custom Filter Log");
        }

    }
}