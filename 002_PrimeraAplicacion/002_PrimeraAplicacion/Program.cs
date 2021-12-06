using System;

namespace _002_PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bienvenidos al curso de C#");
            //Esto imprime un mensaje en consola


            //int edad;
            //edad = 28;
            //Console.WriteLine(edad);

            //Console.WriteLine(7 * 5 * 3);
            //Console.WriteLine(5 / 2.0);
            //Console.WriteLine(9 % 4);
            //int edad = 19;
            //edad += 8;
            //edad++;
            //Console.WriteLine("Tu edad es de " + ++edad + " años");
            //Console.WriteLine($"Tu edad es de {edad} años");

            //int edadPersona1;
            //int edadPersona2;
            //int edadPersona3;
            //int edadPersona4;

            //edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27; //Iniciar las 4 variables con el mismo valor

            //Console.WriteLine(edadPersona4);

            //int edadPersona1, edadPersona2, edadPersona3, edadPersona4 = 27;
            //edadPersona2 = 35;

            //var edadPersona = 27;//Declaración implicita de variables y se debe declarar e iniciar en la misma linea
            ////edadPersona = 27.5; //No se puede asignar un valor diferente
            //Console.WriteLine(edadPersona);


            ////Conversion explecita (Casting)
            //double temperatura = 34.9;
            //int temperaturaMadrid = (int)temperatura;
            //Console.WriteLine(temperaturaMadrid);

            ////Conversion implicita 
            //int habitantesCiudad = 10000000;
            //long habitantesCiudad2018 = habitantesCiudad;
            //Console.WriteLine(habitantesCiudad2018);

            //float pesoMaterial = 5.78F;
            //double pesoMaterialPrec = pesoMaterial;
            //Console.WriteLine(pesoMaterialPrec);

            //int temperatura2 = 34;
            //double temperaturaMadrid2 = temperatura2;
            //Console.WriteLine(temperaturaMadrid2);


            //Console.WriteLine("Introduce el primer numero");
            //double numero1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce el segundo numero");
            //double numero2 = double.Parse(Console.ReadLine());
            //double resultado = numero1 + numero2;
            //Console.WriteLine($"La suma de los dos numeros es: {resultado}");

            //const int VALOR1 = 5;
            //const int VALOR2 = 7;
            //Console.WriteLine("El valor de VALOR1 es: {0} y el valor de VALOR2 es: {1}",VALOR1,VALOR2);

            Console.WriteLine("¿Radio del circulo?");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine(radio);

            const double PI = 3.1416;

            double resultado = Math.Pow(radio,2) * PI;
            Console.WriteLine("El area de circulo es: {0}",resultado);
        }
    }
}
