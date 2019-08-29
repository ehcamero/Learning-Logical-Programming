using System;
using System.Collections.Generic;

namespace Parte_Dois
{
    class Variaveis
    {
        static void Main(string[] args)
        {
            // Variavel que guarda uma lista de números inteiros
            List<int> inteiros = new List<int>();
            inteiros.Add(10);
            inteiros.Add(5);
            inteiros.Add(15);

            foreach(var inteiro in inteiros)
            {
                Console.WriteLine(inteiro);
            }

            // Variavel sem tipo definido, seu tipo é igual ao tipo do primeiro valor que recebe
            var semTipo = "Recebeu o tipo string";
            Console.WriteLine($"{semTipo}");

            // Constantes
            const double pi = 3.1416;
            Console.WriteLine($"O valor de PI é {pi}");

            // Variavel dinamica (Essa variavel fica alterando o seu tipo conforme o valor de entrada)
            dynamic x = 20;
            Console.WriteLine(x);
            x = "Recebendo um novo tipo [string]";
            Console.WriteLine(x);
        }
    }
}
