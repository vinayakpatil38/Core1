using Core.Models.Errata;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ErrataApis.Controllers
{
    public class ErrorInfoController : ApiController
    {
        // GET: api/ErrorInfo
        ErrorInfoRepo errorInfoRepo = new ErrorInfoRepo();
        public IEnumerable<ErrorInfo> Get()
        {
            return errorInfoRepo.GetErrors();
        }

        public void Post([FromBody] ErrorInfo errorInfo)
        {
            errorInfoRepo.AddErrorInfo(errorInfo);
        }

        // GET: api/ErrorInfo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ErrorInfo
     
        // PUT: api/ErrorInfo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ErrorInfo/5
        public void Delete(int id)
        {
        }
    }
}
