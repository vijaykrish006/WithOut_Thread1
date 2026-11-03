
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class WithoutThread
    {
        public void PrintNumber()
        {
            for (int i = 0; i < 10; i++)
            {
                if(i==5)
                {
                    Thread.Sleep(5000);
                }
                Console.WriteLine("i= " + i);
            }
        }
        public void PrintCharacter()
        {
            for (char ch = 'a'; ch <='f'; ch++)
            {
                Console.WriteLine("char= " + ch);
            }
        }
        static void Main()
        {
            Console.WriteLine("Main Thread Started");
            WithoutThread obj = new WithoutThread();

            Console.WriteLine("\n Printing Number");
            obj.PrintNumber();

            Console.WriteLine("\n Printing Character");
            obj.PrintCharacter();

        }
    }
}

