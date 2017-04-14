
using Spring.Net.Demo.Lesson15.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson15.Service
{
    public class ProductService : IService
    {
        public IList FindAll()
        {
            return new ArrayList();
        }

        public void Save(object entity)
        {
            Console.WriteLine("保存：" + entity);
        }
    }
}
