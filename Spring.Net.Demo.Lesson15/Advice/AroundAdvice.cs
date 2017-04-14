﻿using AopAlliance.Intercept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson15.Advice
{
    public class AroundAdvice : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            Console.WriteLine("开始:  " + invocation.TargetType.Name + "." + invocation.Method.Name);
            object result = invocation.Proceed();
            Console.WriteLine("结束:  " + invocation.TargetType.Name + "." + invocation.Method.Name);
            return result;
        }
    }
}
