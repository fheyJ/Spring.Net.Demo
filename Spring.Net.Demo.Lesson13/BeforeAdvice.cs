using Spring.Aop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson13
{
    public class BeforeAdvice : IMethodBeforeAdvice
    {
        public void Before(System.Reflection.MethodInfo method, object[] args, object target)
        {

            //一般记录一些日志

            Console.WriteLine("拦截的方法名—>" + method.Name);
            Console.WriteLine("目标—>" + target);
            Console.WriteLine("参数—>");
            if (args != null)
            {
                foreach (object arg in args)
                {
                    Console.WriteLine("\t: " + arg);
                }
            }
        }
    }
}
