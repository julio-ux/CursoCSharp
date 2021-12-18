using System;

namespace _014_CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool haceFrio;
            //haceFrio = true;
            //Console.WriteLine(!haceFrio);

            //int edad = 25;
            //Console.WriteLine("Vamos a evaluar si eres mayor de edad");
            //if (edad >= 18)
            //{
            //    Console.WriteLine("Adelante, puedes pasar porque eres mayor de edad");
            //    Console.WriteLine("Disfruta de tu instancia");
            //}

            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");
            //bool carnet = false;
            //if (carnet)
            //    Console.WriteLine("Puedes conducir vehiculos");
            //else
            //    Console.WriteLine("No puedes conducir vehiculos");

            //Console.WriteLine("Aquí termina el programa");

            Console.WriteLine("Introduce tu edad, por favor");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("¿Tienes carnet? si/no");
                string carnet = Console.ReadLine();
                if (carnet.ToLower() == "si")Console.WriteLine("Puedes conducir un vehiculo");
                else Console.WriteLine("No puedes conducir un vehiculo");
            }
            else Console.WriteLine("No puedes conducir un vehiculo");
        }
    }
}
