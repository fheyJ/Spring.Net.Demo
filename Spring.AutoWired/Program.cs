using Spring.Context;
using Spring.Context.Support;
using Spring.Objects.Factory.Attributes;
using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.AutoWired
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();

            Say say = new AutoWired.Say();
            string str = say.SayHello();
            //Chinese chinese = (Chinese)ctx.GetObject("Chinese");
            //chinese.eat();
            //chinese.walk();
            Console.WriteLine(str);
            Console.ReadLine();
        }

        //private void Say()
        //{
        //    string str = man.sayHello();
        //    Console.WriteLine(str);
        //}
    }
}
