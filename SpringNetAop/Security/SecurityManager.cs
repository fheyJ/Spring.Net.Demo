﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringNetAop.Security
{
    public class SecurityManager : ISecurityManager
    {
        /// <summary>
        /// 判断权限
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool IsPass(string userName)
        {
            return userName == "admin";
        }
    }
}
