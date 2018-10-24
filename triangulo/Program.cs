using System;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int ladoA;
            int ladoB;
            int ladoC;

            string texto;
            //comentando

            Console.WriteLine("Digite um valor para o ladoA ");
            ladoA = Int32.Parse(Console.ReadLine()) ;
            texto = "ladoA: " + ladoA;

            Console.WriteLine("Digite um valor para o ladoB ");
            ladoB = Int32.Parse(Console.ReadLine());
            texto += "\nladoB: " + ladoB ;

            Console.WriteLine("Digite um valor para o ladoC ");
            ladoC = Int32.Parse(Console.ReadLine());
            texto += "\nladoC: " + ladoC;

            Console.WriteLine(texto);

        }
    }
}
