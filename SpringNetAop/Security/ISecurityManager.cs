using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringNetAop.Security
{
    public interface ISecurityManager
    {
        bool IsPass(string userName);
    }
}
