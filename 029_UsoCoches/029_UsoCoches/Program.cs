using System;

namespace _029_UsoCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();//Crear objeto o instancia de tipo Coche
            //Dar un estado inicial a nuestro Coche

            Coche coche2 = new Coche();


            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());

            Coche coche3 = new Coche(4500.25,1200.35);

            Console.WriteLine(coche3.getInfoCoche());

        }
    }
    class Coche 
    {
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;

        public Coche() 
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
        }
        public Coche(double largo_coche, double ancho_coche) 
        {
            ruedas = 4;
            largo = largo_coche;
            ancho = ancho_coche;
        }
        public String getInfoCoche() 
        {
            return "Información del coche: \nRuedas: " + ruedas + " Largo: " + largo + " Ancho: " + ancho;
        }
    }
}
