using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    //5. Define Method overloading in c# code and how to call them (write sample syntax).
    public class MethodConcept
    {
        public void add()
        {
            Console.WriteLine("default method");
        }
        public void add(int a,int b)
        {
            int addition=a+b;
            Console.WriteLine("addition of two numbers:"+addition);
        }
        public void add(double x,double y,double z)
        {
            double result=x+y+z;
            Console.WriteLine("final Result:"+result);
        }
      
    }
    //7. Write a code snippet in c# for an overloaded constructor.
    public class ConstructorMethod
    {
        public ConstructorMethod()
        {
            Console.WriteLine("Default constructor");
        }
        public ConstructorMethod(string firstName,string lastName)
        {
            Console.WriteLine("constructor overloading:"+firstName+lastName);
        }
        public ConstructorMethod(int a, int d)
        {
            Console.WriteLine("constructor overloading part 2:" +a+d);
        }
    }
}
