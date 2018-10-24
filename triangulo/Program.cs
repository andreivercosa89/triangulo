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

            /*Console.WriteLine("Digite qualquer coisa...");
            texto = "Foi digitado isso aqui: " + Console.ReadLine();
            Console.WriteLine(texto);*/

            Console.WriteLine("Digite um valor para o lado A");
            ladoA = Int32.Parse(Console.ReadLine());
            texto = "\nLado A: " + ladoA;
            Console.WriteLine("Valor de texto: " + texto);

            Console.WriteLine("\nDigite um valor para o lado B");
            ladoB = Int32.Parse(Console.ReadLine());
            texto += "\nLado B: " + ladoB;//+= concatena
            Console.WriteLine("\nValor de texto: " + texto);

            Console.WriteLine("\nDigite um valor para o lado C");
            ladoC = Int32.Parse(Console.ReadLine());
            texto += "\nLado C: " + ladoC;
            Console.WriteLine("\nValor de texto: " + texto);
        }
    }
}
