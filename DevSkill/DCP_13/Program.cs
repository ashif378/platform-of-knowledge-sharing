using System;

namespace DCP_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0, score = 0;
            t = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<t; i++)
            {
                score = 0;
                for(int j=0; j<2; j++)
                {
                    int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
                    if(ar[0]+ar[1] > ar[2]+ar[3])
                    {
                        score++;
                    }
                }
                if(score == 2)
                {
                    Console.WriteLine("Banglawash");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
