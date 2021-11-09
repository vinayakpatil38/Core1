using Core.Contracts.Repositories;
using Core.Models.Errata;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ErrorInfoRepo : IErrorInfoRepo
    {
        ErrataContext errataContext = new ErrataContext();
        public void AddErrorInfo(ErrorInfo errorInfo)
        {
            errataContext.ErrorInfos.Add(errorInfo);
            errataContext.SaveChanges();
        }

        public List<ErrorInfo> GetErrors()
        {
            return errataContext.ErrorInfos.ToList();
        }

        // all other methods
    }
}
