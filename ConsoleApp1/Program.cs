using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0,b=0;
            for (int i = 0; i <100; i++)
            {
                if (i%2==0)
                {
                    a += i * 2 + 1;
                    if (i < 100)
                    {
                        b = i * 2 + 1;
                    }

                }
                if (i%2==1)
                {
                    a += -(i * 2 + 1);
                }
                if (i<100)
                {
                    b = i * 2 + 1;
                }
                
                
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
