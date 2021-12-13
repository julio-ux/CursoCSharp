using System;

namespace _010_Practica_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello World!");
            ////mensajeEnPantalla();
            ////mensajeEnPantalla();
            //Console.WriteLine("Mensaje desde el main");
            ////mensajeEnPantalla();
            ////mensajeEnPantalla();
            ////mensajeEnPantalla();
            //SumarNumeros(7,9);

            //Console.WriteLine($"La suma de los numeros es: {SumarNumeros(100,900.0)}");
            //Console.WriteLine($"La division de los numeros es: {DivideNumeros(50,25)}");
            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;
            Console.WriteLine(suma(valor1,valor2));
        }

        static double suma(int num1, double num2, double num3=0)
        {
            return num1 + num2 + num3;
        }
        static double suma(int num1, double num2) 
        {
            return num1 + num2;
        }

        //static void mensajeEnPantalla()
        //{
        //    Console.WriteLine("Mensaje desde el metodo mensajeEnPantalla");
        //}
        static void SumarNumeros(int numero1, int numero2) 
        {
            Console.WriteLine($"La suma de { numero1 } y { numero2 } es { numero1 + numero2 }");
        }
        //static double SumarNumeros(int numero1, double numero2) 
        //{
        //    return numero1 + numero2;
        //}
        //static double DivideNumeros(double numero1, double numero2) => numero1 / numero2;
        //void primerMetodo() 
        //{
        //    Console.WriteLine($"La suma de los dos numeros es: {numero1 + numero2}");
        //}
        //void segundoMetodo()
        //{
        //    Console.WriteLine($"La suma de los dos numeros es: {numero1 + numero2}");
        //}
        //int numero1 = 5;
        //int numero2 = 7;

        //static int suma(int operador1, int operador2) => operador1 + operador2;
        //static int suma(int operador1, double operador2) => operador1;
        //static int suma(int operador1, int operador2, int operador3, int numero4) => operador1 + operador2;
    }
}
