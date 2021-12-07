using System;

namespace _010_Practica_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //mensajeEnPantalla();
            //mensajeEnPantalla();
            Console.WriteLine("Mensaje desde el main");
            //mensajeEnPantalla();
            //mensajeEnPantalla();
            //mensajeEnPantalla();
            SumarNumeros(7,9);
        }
        //static void mensajeEnPantalla()
        //{
        //    Console.WriteLine("Mensaje desde el metodo mensajeEnPantalla");
        //}
        static void SumarNumeros(int numero1, int numero2) 
        {
            Console.WriteLine($"La suma de { numero1 } y { numero2 } es { numero1 + numero2 }");
        }

    }
}
