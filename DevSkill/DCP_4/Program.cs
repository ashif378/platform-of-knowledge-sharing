using System;

namespace DCP_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ct1;
            int ct, n, sum, s, z;

            while ((ct1 = (Console.ReadLine())) != null && ct1 != "")
            {
                sum = 0;
                int[] ar = Array.ConvertAll(ct1.Split(' '), Convert.ToInt32);
                ct = ar[0];
                n = ar[1];

                for(int i=0; i<n; i++)
                {
                    s = Convert.ToInt32(Console.ReadLine());
                    sum += s;
                }

                if (ct % sum == 0)
                {
                    z = ct / sum;
                }
                else
                {
                    z = (ct / sum) + 1;
                }

                if (z == 1)
                {
                    Console.WriteLine("Project will finish within 1 day.");
                }
                else
                {
                    Console.WriteLine("Project will finish within "+ z +" days.");
                }


            }
            
        }
    }
}
