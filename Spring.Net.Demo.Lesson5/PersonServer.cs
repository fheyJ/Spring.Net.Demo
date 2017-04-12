using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson5
{
    public class PersonServer
    {
        public PersonServer()
        {
            Console.WriteLine("PersonServer被实例");
        }

        public override string ToString()
        {
            return "我是PersonServer";
        }
    }
}
