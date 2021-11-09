using Core.Models.Errata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Repositories
{
    public interface IErrorInfoRepo
    {
        void AddErrorInfo(ErrorInfo errorInfo);

        List<ErrorInfo> GetErrors();

        //

    }
}
