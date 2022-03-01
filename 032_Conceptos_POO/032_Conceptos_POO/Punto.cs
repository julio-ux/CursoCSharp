using System;
using System.Collections.Generic;
using System.Text;

namespace _032_Conceptos_POO
{
    class Punto { 
        public Punto() 
        {
            //Console.WriteLine("Es es constructor por defecto");
            x = 0;
            y = 0;
            contadorDeObjetos++;
        }
        public Punto(int x, int y) 
        {
            //Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");
            this.x = x;
            this.y = y;
            contadorDeObjetos++;
        }
        public double DistanciaHasta(Punto otropunto) 
        {
            int xDif = this.x - otropunto.x;
            int yDif = this.y - otropunto.y;
            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif,2) + Math.Pow(yDif,2));
            return distanciaPuntos;
        }
        public static int getNumeroContador() 
        {
            return contadorDeObjetos;
        }
        private int x, y;
        private static int contadorDeObjetos = 0;
        public const int constantePrueba = 7;
    }
}
