﻿using System;

namespace _023_UsoChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            checked 
            {
                int numero = int.MaxValue;
                int resultado = numero + 20;
                Console.WriteLine(resultado);
            }
             
        }
    }
}
