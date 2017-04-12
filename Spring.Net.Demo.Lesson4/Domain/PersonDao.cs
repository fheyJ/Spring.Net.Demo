using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson4.Domain
{
    public class PersonDao
    {
        public class Person
        {
            public override string ToString()
            {
                return "我是全套类Person";
            }
        }

        public override string ToString()
        {
            return "我是PersonDao";
        }
    }
}
