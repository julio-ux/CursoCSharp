using System;

namespace _014_CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool haceFrio;
            //haceFrio = true;
            //Console.WriteLine(!haceFrio);

            int edad = 25;
            Console.WriteLine("Vamos a evaluar si eres mayor de edad");
            if (edad >= 18) 
            {
                Console.WriteLine("Adelante, puedes pasar porque eres mayor de edad");
            }
        }
    }
}
