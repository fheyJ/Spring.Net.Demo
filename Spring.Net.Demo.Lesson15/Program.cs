
using Spring.Context;
using Spring.Context.Support;
using Spring.Net.Demo.Lesson15.Interface;
using Spring.Net.Demo.Lesson15.Service;
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

            IService gt = ctx.GetObject("categoryService") as IService;
            
            //拦截
            gt.FindAll();

            //不拦截
            gt.Save(111);

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
