using System;

namespace Assignment1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("76543"));
        }

        public static bool IsValid(string a)
        {

            if(a.Length == 5)
            {
                for(int i=0; i<5; i++)
                {
                    if(a[i] < '0' || a[i] > '9')
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            { 
                return false;
            }
        }
    }
}
