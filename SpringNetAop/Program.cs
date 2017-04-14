using Spring.Aop.Framework;
using Spring.Context;
using Spring.Context.Support;
using SpringNetAop.Aspects;
using SpringNetAop.Commands;
using SpringNetAop.CompanyManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringNetAop
{
    class Program
    {
        static void Main(string[] args)
        {
            BeforeAdvice();
            AroundAdvice();
        }

        //前置通知
        private static void BeforeAdvice()
        {
            IApplicationContext context = ContextRegistry.GetContext();

            Person P = context.GetObject("Person") as Person;
            P.Save();

            IStudentService command = (IStudentService)context["myStudentService"];
            command.GoToSchool("guwei4037", "一");

            Console.ReadLine();
        }

        //环绕通知
        private static void AroundAdvice()
        {
            ICompanyManager target = new SpringNetAop.CompanyManager.CompanyManager() { Dao = new CompanyDao(), UserName = "admin" };
            //target.Save();
            ProxyFactory factory = new ProxyFactory(target);
            factory.AddAdvice(new AroundAdvice());

            ICompanyManager manager = (ICompanyManager)factory.GetProxy();
            manager.Save();

            Console.ReadLine();
        }
    }
}
