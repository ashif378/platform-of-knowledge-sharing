using System;


namespace DCP_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double ab, bc, cd, ac, ad;
            int t = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<t; i++)
            {
                double[] s = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToDouble);
                ab = s[0];
                bc = s[1];
                cd = s[2];

                ac = Math.Sqrt((ab * ab) + (bc * bc));
                ad = Math.Sqrt((ac * ac) + (cd * cd));

                Console.WriteLine("{0:F2}", ad);
            }
        }
    }
}
