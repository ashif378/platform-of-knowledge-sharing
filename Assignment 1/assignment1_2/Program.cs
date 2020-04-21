
using System;
using System.Text;

namespace assignment1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int n = a.Length;
            char[] b = new char[n];
            char[] c = new char[n];
            int j = 0;
 
            for(int i=0; i<n; i++)
            {
                if(a[i] == 'a' || a[i] == 'A' || a[i] == 'e' || a[i] == 'E' || a[i] == 'i' || a[i] == 'I' || a[i] == 'o' || a[i] == 'O' || a[i] == 'u' || a[i] == 'U')
                {
                    b[j++] = a[i];
                }
            }
            for(int i=0; i<n; i++)
            {
                if (a[i] == 'a' || a[i] == 'A' || a[i] == 'e' || a[i] == 'E' || a[i] == 'i' || a[i] == 'I' || a[i] == 'o' || a[i] == 'O' || a[i] == 'u' || a[i] == 'U')
                {
                    c[i] = b[--j];
                }
                else
                {
                    c[i] = a[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(c[i]);
            }


        }
    }
}
