using Spring.Context;
using Spring.Context.Support;
using Spring.Net.Demo.Lesson3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            AppRegistry();
            Console.ReadLine();
        }

        static void AppRegistry()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();

            PersonDao dao = ctx.GetObject("PersonDao") as PersonDao;

            string str1 = dao.GetStr();

            string strA = dao.A;
            string strB = dao.B;

            string C = dao.C.S1;
            string D = dao.C.S2;
            string E = dao.C.GetStr();

            //Console.WriteLine(ctx.GetObject("PersonDao").ToString());

            Console.ReadLine();
        }
    }
}
