using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson2
{
    public class PersonDao
    {

        public string A;
        public string B;

        public Info C;

        public override string ToString()
        {
            return "我是PersonDao";
        }

        public string GetStr()
        {
            return "ABC";
        }

    }
}
