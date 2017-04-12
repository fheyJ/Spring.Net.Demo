using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            AppRegistry();
            Console.ReadLine();
        }

        static void AppRegistry()
        {
            MyXmlFactory ctx = new MyXmlFactory("Objects.xml");

            PersonDao demo = ctx.GetObject("PersonDao") as PersonDao;

            Console.WriteLine(demo.say());
        }
    }
}
