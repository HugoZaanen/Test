using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Test
{
    public class ThreadExample
    {
        public static void ThreadProc()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine("ThreadProc: {0}",i);
            Thread.Sleep(0);
        }
    }
}
