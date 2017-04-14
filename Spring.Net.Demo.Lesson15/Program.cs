
using Spring.Context;
using Spring.Context.Support;
using Spring.Net.Demo.Lesson15.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();

            IDictionary<string, object> speakerDictionary = ctx.GetObjectsOfType(typeof(IService));
            foreach (var entry in speakerDictionary)
            {
                string name = (string)entry.Key;
                IService service = (IService)entry.Value;
                Console.WriteLine(name + " 拦截： ");

                service.FindAll();

                Console.WriteLine();

                service.Save("数据");

                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
