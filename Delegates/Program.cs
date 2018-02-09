using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    delegate void DisplayDelegate();

    class FrameworkClass
    {
        public void ExecuteThisMethod(DisplayDelegate myDelegate)
        {
            myDelegate.DynamicInvoke();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FrameworkClass myObj = new FrameworkClass();

            //Adding the delegates to the Delegate Object
            DisplayDelegate myDel = test1;
            myDel += test2;
            myDel += test3;

            //Removes the delegate for test2 method
            myDel -= test2;

            //Passing the delegate as a method parameter.. The below will call only test1 and test2 methods..
            myObj.ExecuteThisMethod(myDel);
            Console.ReadLine();
        }

        static void test1()
        {
            Console.WriteLine("Writing to console from Test1");
        }

        static void test2()
        {
            Console.WriteLine("Writing to console from Test2");
        }

        static void test3()
        {
            Console.WriteLine("Writing to console from Test3");
        }
    }
}
