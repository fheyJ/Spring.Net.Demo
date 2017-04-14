using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson15.Interface
{
    public interface IService
    {
        IList FindAll();

        void Save(object entity);
    }
}
