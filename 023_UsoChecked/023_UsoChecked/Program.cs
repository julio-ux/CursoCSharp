using System;

namespace _023_UsoChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.MaxValue;
            int resultado = unchecked(numero + 20);
            Console.WriteLine(resultado);
             
        }
    }
}
