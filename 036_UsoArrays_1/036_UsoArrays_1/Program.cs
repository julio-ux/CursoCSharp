using System;

namespace _036_UsoArrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] edades;
            //edades = new int[4];

            //edades[0] = 15;
            //edades[1] = 27;
            //edades[2] = 19;
            //edades[3] = 80;

            //Console.WriteLine(edades[2]);

            int[] edades = {15,27,19,80 };
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine(edades[i]);
            }
        }
    }
}
