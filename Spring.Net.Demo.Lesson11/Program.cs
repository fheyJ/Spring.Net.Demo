using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {

            using (IApplicationContext ctx = ContextRegistry.GetContext())
            {
                ctx.GetObject("person");

                Child child = (Child)ctx.GetObject("child");
                Console.WriteLine("Child中Name的值为：" + child.Name);
            }

            Console.ReadLine();

        }
    }
}
