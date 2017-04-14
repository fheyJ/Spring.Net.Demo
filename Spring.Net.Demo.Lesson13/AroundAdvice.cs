using AopAlliance.Intercept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson13
{
    public class AroundAdvise : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            IOrderService target = (IOrderService)invocation.Target;
            SecurityService manager = new SecurityService();
            if (manager.IsPass(target.UserName))
            {
                return invocation.Proceed();
            }
            else
            {
                return null;
            }
        }
    }
}
