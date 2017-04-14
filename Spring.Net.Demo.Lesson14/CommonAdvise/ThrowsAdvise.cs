using Spring.Aop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson14.CommonAdvise
{
    public class ThrowsAdvise : IThrowsAdvice
    {
        public void AfterThrowing(Exception ex)
        {
            string errorMsg = string.Format("     异常通知： 方法抛出的异常 : {0}", ex.Message);
            Console.Error.WriteLine(errorMsg);

            Console.WriteLine();
        }
    }
}
