using System;
using System.Collections.Generic;
using System.Text;

namespace _032_Conceptos_POO
{
    class Punto { 
        public Punto() 
        {
            Console.WriteLine("Es es constructor por defecto");
        }
        public Punto(int x, int y) 
        {
            Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");
        }
    }
}
