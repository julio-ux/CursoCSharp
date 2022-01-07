using System;

namespace _019_UsoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("¿Deseas entrar en el buble While?");
            //string respuesta = Console.ReadLine();
            //while (respuesta != "no") 
            //{
            //    Console.WriteLine("Estás ejecutando el interior del bucle While");
            //    Console.WriteLine("Introduce tu nombre, por favor");
            //    string nombre = Console.ReadLine();
            //    Console.WriteLine($"Saldrás del bucle {nombre} cunado respondas 'no' a la pregunta");
            //    Console.WriteLine("¿Deseas repetir otra vez?");
            //    respuesta = Console.ReadLine();
            //}
            //Console.WriteLine("Haz salido del bucle");
            Random random = new Random();
            int numero_random = random.Next(0,100);
            int numero_dado = 0;
            int intentos = 0;
            do
            {
                intentos++;
                Console.WriteLine("De un numero, por favor: ");
                try
                {
                    numero_dado = Int32.Parse(Console.ReadLine());
                }
                //catch (FormatException e)
                //{
                //    Console.WriteLine("Solo numeros, por favor " + e.Message);
                //}
                //catch (OverflowException e) 
                //{
                //    Console.WriteLine("El valor es muy grande");
                //}
                catch (Exception e) 
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                                
                if (numero_dado > numero_random)
                {
                    Console.WriteLine("El numero debe ser menor");
                }
                if (numero_dado < numero_random)
                {
                    Console.WriteLine("El numero debe ser mayor");
                }
            } while (numero_random != numero_dado);
            Console.WriteLine($"Felicidades, lo logro en { intentos } intetntos");
            Console.WriteLine("A partir de aqui continuaria el programa");
        }
    }
}
