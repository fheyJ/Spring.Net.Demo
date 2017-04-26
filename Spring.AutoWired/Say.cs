using Spring.Objects.Factory.Attributes;
using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.AutoWired
{
    [Service]
    public class Say
    {
        [Autowired]
        [Qualifier("Man")]
        protected IMan man { set; get; }


        public string SayHello()
        {
            string str = man.sayHello();
            return str;
        }
    }
}
