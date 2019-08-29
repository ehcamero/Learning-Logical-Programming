using System;

namespace Condicionais
{
    class Condicionais
    {
        static void Main(string[] args)
        {
            // Variaveis que serao utilizadas como referencia para as comparacoes
            double reference = 3.3;
            String nome = "Matheus";

            // Condicional do tipo IF e ELSE
            if(reference < 5.0){
                Console.WriteLine("Reprovado!");
            } else{
                Console.WriteLine("Aprovado");
            }

            // Condicional do tipo IF Ternário = CONDIÇÃO ? RETORNO VERDADEIRO : RETORNO FALSO
            Console.WriteLine(reference < 5.0 ? "Reprovado" : "Aprovado");

            // Condicional do tipo SWITCH / CASE / DEFAUL
            switch(nome){
                case "Marcio":
                    Console.WriteLine("Olá Márcio");
                    break;
                case "Junior":
                    Console.WriteLine("Olá Junio");
                    break;
                case "Matheus":
                    Console.WriteLine("Olá Matheus");
                    break;
                default:
                    Console.WriteLine("Não tem ninguém para dar olá");
                    break;
            }
        }
    }
}
