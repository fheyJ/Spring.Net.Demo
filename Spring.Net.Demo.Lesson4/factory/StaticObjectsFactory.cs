using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Net.Demo.Lesson4.Domain;

namespace Spring.Net.Demo.Lesson4.factory
{
    public static class StaticObjectsFactory
    {
        public static PersonDao CreateInstance()
        {
            return new PersonDao();
        }
    }
}
