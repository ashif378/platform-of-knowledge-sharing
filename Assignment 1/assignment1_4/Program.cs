using System;

namespace assignment1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int n = a.Length;
            int[] ar = new int[200];

            for(int i=0; i<n; i++)
            {
                ar[a[i]]++;
            }

            int max = 0;
            int mxindx=0;

            for (int i = 0; i < 200; i++)
            {
                if (ar[i] > max)
                {
                    max = ar[i];
                    mxindx = i;
                }
            }

            Console.WriteLine("The Highest frequency of character '" + Convert.ToChar(mxindx) + "' appears number of times: " + ar[mxindx]);

        }
    }
}
