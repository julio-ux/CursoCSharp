using System;

namespace _028_POO_II
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorEuroDolar obj = new ConversorEuroDolar();
            obj.CambiarValorEuro(-7.85);
            Console.WriteLine(obj.Convierte(50));
            //Circulo miCirculo = new Circulo();//Instanciar una clase 
            ////Instanciacion, Ejemplarizacion, Crear de ejemplar de clase

            //Console.WriteLine("El area del circulo es: " + miCirculo.CalculoArea(5));

            //Circulo miCurculo2 = new Circulo();

            //Console.WriteLine("El area del circulo es: " + miCirculo.CalculoArea(9));
        }
    }
    class Circulo 
    {
        private const double pi = 3.1416;//Propiedad de la clase Circulo. Campo de clase.
        public double CalculoArea(int radio)//Metodo de clase. ¿Que pueden hacer los objetos de tipo circulo? 
        {
            return pi * radio * radio;
        }
    }
    class ConversorEuroDolar 
    {
        private double euro = 1.253;
        public double Convierte(double cantidad) 
        {
            return cantidad * euro;
        }
        public void CambiarValorEuro(double valor) 
        {
            if (valor < 0) euro = 1.253;
            else euro = valor;
        }
    }
}
