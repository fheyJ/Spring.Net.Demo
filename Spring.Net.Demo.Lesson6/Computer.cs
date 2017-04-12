using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson6
{
    public class Computer : ITool
    {
        public void UseTool()
        {
            Console.WriteLine("使用电脑");
        }
    }
}
