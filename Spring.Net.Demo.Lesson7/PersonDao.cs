﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net.Demo.Lesson7
{
    public class PersonDao
    {

        private Person argPerson;
        private int intProp;

        //public Test test;

        public PersonDao(Person argPerson, int intProp)
        {
            this.argPerson = argPerson;
            this.intProp = intProp;
        }

        public void Get()
        {
            //构造函数注入的整型参数
            Console.WriteLine(string.Format("intProp:{0}", intProp));
            
            //构造函数注入的Person
            Console.WriteLine(string.Format("argPerson Name:{0}", argPerson.Name));
            Console.WriteLine(string.Format("argPerson Age:{0}", argPerson.Age));

            //内联对象Friend
            Console.WriteLine(string.Format("argPerson Friend Name:{0}", argPerson.Friend.Name));
            Console.WriteLine(string.Format("argPerson Friend Age:{0}", argPerson.Friend.Age));

            //内联对象的循环引用
            Console.WriteLine(string.Format("argPerson Friend Friend Name:{0}", argPerson.Friend.Friend.Name));
            Console.WriteLine(string.Format("argPerson Friend Friend Age:{0}", argPerson.Friend.Friend.Age));
        }
    }
}
