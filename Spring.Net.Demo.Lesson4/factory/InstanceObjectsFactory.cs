using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Net.Demo.Lesson4.Domain;

namespace Spring.Net.Demo.Lesson4.factory
{
    public class InstanceObjectsFactory
    {
        public PersonDao CreateInstance()
        {
            return new PersonDao();
        }
    }
}
