﻿using System;

namespace _032_Conceptos_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }
        static void realizarTarea() 
        {
            // TODO:
            Punto origen = new Punto();
            Punto destino = new Punto(150,90);
            Punto otroPunto = new Punto();

            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");

            Console.WriteLine($"Numero de objetos creados: {Punto.getNumeroContador()}");
        }
    }
}
