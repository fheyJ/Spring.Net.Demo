using Spring.Context;
using Spring.Context.Support;
using SpringNetAop.Commands;
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
            IApplicationContext context = ContextRegistry.GetContext();

            Person P = context.GetObject("Person") as Person;
            P.Save();

            IStudentService command = (IStudentService)context["myStudentService"];
            command.GoToSchool("guwei4037", "一");

            Console.ReadLine();
        }
    }
}
