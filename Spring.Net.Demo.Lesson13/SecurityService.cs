using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson13
{
    public class SecurityService
    {
        public bool IsPass(string userName)
        {
            return userName == "admin";
        }
    }
}
