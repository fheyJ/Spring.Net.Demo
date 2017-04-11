using Spring.Context;
using Spring.Context.Support;
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
            Console.WriteLine(ctx.GetObject("PersonDao").ToString());
        }
    }
}
