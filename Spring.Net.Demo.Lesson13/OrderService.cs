﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson13
{
    public class OrderService : IOrderService
    {
        public string UserName { get; set; }

        public object Save(object id)
        {
            return "保存：" + id.ToString();
        }
    }
}
