using Spring.Aop.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFactory factory = new ProxyFactory(new OrderService() { UserName = "admin" });

            factory.AddAdvice(new AroundAdvise());
            IOrderService service = (IOrderService)factory.GetProxy();
            object result = service.Save(1);

            Console.WriteLine(result);

            Console.ReadLine();
        }

        private static void Before()
        {

        }
    }
}
