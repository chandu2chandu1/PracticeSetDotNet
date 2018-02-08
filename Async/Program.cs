using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            anotherMethod();
            Console.ReadLine();
        }

        public async static void anotherMethod()
        {
            var i = 0;
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                if (i % 5 == 0)
                    //BlockingMethodAsync();
                    await BlockingMethodAsync();
                Console.WriteLine(++i);
            }
        }

        public static async Task BlockingMethodAsync()
        {
            Console.WriteLine(".....................In blocking operation...............");
            await Task.Delay(5000);
        }

    }
}
