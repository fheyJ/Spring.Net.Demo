using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();

            PersonDao dao = ctx.GetObject("personDao") as PersonDao;

            //string A = dao.test.A;
            //string B = dao.test.B;

            dao.Get();

            Console.ReadLine();
        }
    }
}
