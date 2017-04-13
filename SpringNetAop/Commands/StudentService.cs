using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringNetAop.Commands
{
    public class StudentService : IStudentService
    {
        public void GoToSchool(string studentName, string className)
        {
            Console.WriteLine("计算机({1})班的{0}同学去上学了。。。", studentName, className);
        }
    }
}
