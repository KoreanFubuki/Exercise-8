using System;

namespace Coding.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            run();
            Console.Read();
        }
        public static void run ()
        {
            int i = -10;
            while (true)
            {
                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }
                if (i == 10)
                {
                    break;
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}


    
