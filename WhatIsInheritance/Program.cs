using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsInheritance
{
    class Program
    {
        //Lecture 2: What is Inheritance?
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Name = "Jesse";
            e.Age = 30;
            e.ID = "3574dfg5";


            e.IntroduceSelf();
        }
    }
}
