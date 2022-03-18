using System;

namespace _036_UsoArrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] edades;
            //edades = new int[4];

            //edades[0] = 15;
            //edades[1] = 27;
            //edades[2] = 19;
            //edades[3] = 80;

            //Console.WriteLine(edades[2]);

            int[] edades = {15,27,19,80 };
            //for (int i = 0; i < edades.Length; i++)
            //{
            //    Console.WriteLine(edades[i]);
            //}
            //foreach (int edad in edades) 
            //{
            //    Console.WriteLine(edad);
            //}

            //array implicito
            //var datos = new[] {"Juan", "Castillo", 15};
            var valores = new[] {15,28,35,75.5,30.30};
            //array de objetos
            Empleados [] misempleados = new Empleados[2];
            misempleados[0] = new Empleados("Julio",29);
            misempleados[1] = new Empleados("Anna", 45);

            foreach (Empleados e in misempleados) 
            {
                Console.WriteLine(e.getInfoEmpleado());
            }
            //Array de tipo o clases anonimas
            var personas = new[] { new {Nombre = "Juan", Edad = 19}, new {Nombre = "Anna", Edad = 34}, new {Nombre = "Diana", Edad = 36} };
        }
    }
    class Empleados 
    {
        public Empleados(String nombre, int edad) 
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public String getInfoEmpleado() 
        {
            return $"Nombre: {nombre}, edad: {edad}";
        }
        private String nombre;
        private int edad;
    }
}
