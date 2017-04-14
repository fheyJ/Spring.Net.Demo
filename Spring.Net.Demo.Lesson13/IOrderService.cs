using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson13
{
    public interface IOrderService
    {

        string UserName { get; set; }

        object Save(object id);


        
    }
}
