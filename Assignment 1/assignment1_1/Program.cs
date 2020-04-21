using System;

namespace assignment1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for (int i = 0; i<9; i++)
            {
                if (i < 5) 
                {
                    n++;
                    Console.Write(n + " ");
                }
                else
                {
                    n--;
                    Console.Write(n + " ");
                }
            }
        }
    }
}
