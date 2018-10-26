using System;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo triangulo = new Triangulo();
            //Triangulo t2 = new Triangulo();

            Console.WriteLine("Informe o lado A: ");
           
            triangulo.defineValorLadoA(Int32.Parse(Console.ReadLine()));


            Console.WriteLine("LadoA: " + triangulo.pegaValorLadoA() + "\n");



        }
    }
}
