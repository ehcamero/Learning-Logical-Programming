using System;
using System.Collections.Generic;

namespace Repeticoes
{
    class Repeticoes
    {
        static void Main(string[] args)
        {
            // Repeticioes do tipo FOR
            // FOR (INICIO; CONDICAO; INCREMENTO)
            for(int i = 0; i < 5; i++){
                Console.WriteLine($"FOR: {i}");
            }


            // Repeticao do tipo WHILE
            // INICIO; WHILE (CONDICAO) {CODIGO QUE DESEJA EXECUTAR, INCREMENTO}
            int j = 0; // INICIO
            while(j < 5){ // CONDICAO
                Console.WriteLine($"WHILE: {j}"); // CODIGO QUE DESEJA EXECUTAR
                j++; // INCREMENTO
            }


            // Repeticao do tipo DO/WHILE
            // INICIO; DO {CODIGO QUE DESEJA EXECUTAR, INCREMENTO} WHILE (CONDICAO)
            Int16 k = 0; // INICIO
            do{
                Console.WriteLine($"DO/WHILE: {k}"); // CONDIGO QUE DESEJA EXECUTAR
                k++; // INCREMENTO
            } while (k < 5); // CONDICAO


            // Repeticao do tipo FOREACH
            List<int> numeros = new List<int>(); // CONJUNTOS DE NUMEROS
            numeros.Add(0);
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4); 

            foreach(var num in numeros){ // PARA CADA ITEM (num) DA LISTA (numeros)
                Console.WriteLine($"FOREACH {num}"); // EXECUTE ESTE CODIGO - NO CASO MOSTRAR NA TELA O VALOR DE num.
            }
        }
    }
}
