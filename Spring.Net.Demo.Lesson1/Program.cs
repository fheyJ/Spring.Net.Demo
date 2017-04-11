using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            IoCMethod();  // IoC方法"

            Console.ReadLine();
        }

        private static void IoCMethod()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IPersonDao dao = ctx.GetObject("PersonDao") as IPersonDao;
            if (dao != null)
            {
                dao.Save();
                Console.WriteLine("我是IoC方法");
            }
        }
    }
}
