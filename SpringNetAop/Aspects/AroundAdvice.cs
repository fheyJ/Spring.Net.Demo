using AopAlliance.Intercept;
using SpringNetAop.CompanyManager;
using SpringNetAop.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringNetAop.Aspects
{
    public class AroundAdvice : IMethodInterceptor
    {
        //权限系统类(可外部注入)
        private ISecurityManager manager = new SecurityManager();

        public object Invoke(IMethodInvocation invocation)
        {

            Console.WriteLine("111222");

            //拦截Save方法
            if (invocation.Method.Name == "Save")
            {
                ICompanyManager target = (ICompanyManager)invocation.Target;

                return manager.IsPass(target.UserName) ? invocation.Proceed() : null;
            }
            else
            {
                return invocation.Proceed();
            }
        }
    }
}
