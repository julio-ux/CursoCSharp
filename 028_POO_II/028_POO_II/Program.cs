using System;

namespace _028_POO_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo = new Circulo();//Instanciar una clase 
            //Instanciacion, Ejemplarizacion, Crear de ejemplar de clase
                     
            Console.WriteLine("El area del circulo es: " + miCirculo.calculoArea(5));

            Circulo miCurculo2 = new Circulo();

            Console.WriteLine("El area del circulo es: " + miCirculo.calculoArea(9));
        }
    }
    class Circulo 
    {
        const double pi = 3.1416;//Propiedad de la clase Circulo. Campo de clase.
        public double calculoArea(int radio)//Metodo de clase. ¿Que pueden hacer los objetos de tipo circulo? 
        {
            return pi * radio * radio;
        }
    }
}
