using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.AutoWired
{
    [Spring.Stereotype.Repository]
    public class Man : IMan
    {
        public String sayHello()
        {
            return "I am Chinese!";
        }

    }
}
