using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class ErrorInfoVM
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Captcha { get; set; }
        public bool Robot { get; set; }
    }
}
