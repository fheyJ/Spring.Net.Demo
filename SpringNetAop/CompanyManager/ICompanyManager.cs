using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringNetAop.CompanyManager
{
    public interface ICompanyManager
    {
        string UserName { get; set; }

        void Save();
    }
}
