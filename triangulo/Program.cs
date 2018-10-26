using System;
namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo triangulo1 = new Triangulo();
            Triangulo triangulo2 = new Triangulo();

            Console.WriteLine("Informe lado A do triangulo 1: ");
            //triangulo1.ladoA = Int32.Parse(Console.ReadLine());
            triangulo1.defineValorLadoA(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Informe lado B do triangulo 1: ");
            //triangulo1.ladoB = Int32.Parse(Console.ReadLine());
            triangulo1.defineValorLadoB(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Informe lado C do triangulo 1: ");
            //triangulo1.ladoC = Int32.Parse(Console.ReadLine());
            triangulo1.defineValorLadoC(Int32.Parse(Console.ReadLine()));


            /*Console.WriteLine("Informe lado A do triangulo 2: ");
            triangulo2.ladoA = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe lado B do triangulo 2: ");
            triangulo2.ladoB = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe lado C do triangulo 2: ");
            triangulo2.ladoC = Int32.Parse(Console.ReadLine());*/


            /*Console.WriteLine("\nLado A do triangulo 1: " + triangulo1.ladoA + 
                              "\nLado B do triangulo 1: " + triangulo1.ladoB +
                              "\nLado C do triangulo 1: " + triangulo1.ladoC);
            Console.WriteLine("\n\nLado A do triangulo 2: " + triangulo2.ladoA + 
                              "\nLado B do triangulo 2: " + triangulo2.ladoB +
                              "\nLado C do triangulo 2: " + triangulo2.ladoC);*/

            Console.WriteLine(triangulo1.pegaValorladoA());
            Console.WriteLine("Lado B: " + triangulo1.pegaValorladoB());
            Console.WriteLine("Lado C: " + triangulo1.pegaValorladoC());

        }
    }
}
