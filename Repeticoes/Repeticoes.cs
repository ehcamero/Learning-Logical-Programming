using System;

namespace Repeticoes
{
    class Repeticoes
    {
        static void Main(string[] args)
        {
            // Repeticioes do tipo FOR
            // FOR (INICIO; CONDICAO; INCREMENTO)
            for(int i = 0; i < 5; i++){
                Console.WriteLine(i);
            }


            // Repeticao do tipo WHILE
            // INICIO; WHILE (CONDICAO) {CODIGO QUE DESEJA EXECUTAR, INCREMENTO}
            int j = 0; // INICIO
            while(j < 0){ // CONDICAO
                Console.WriteLine(j); // CODIGO QUE DESEJA EXECUTAR
                j++; // INCREMENTO
            }


            // Repeticao do tipo DO/WHILE
            // INICIO; DO {CODIGO QUE DESEJA EXECUTAR, INCREMENTO} WHILE (CONDICAO)
            Int16 k = 0; // INICIO
            do{
                Console.WriteLine(k); // CONDIGO QUE DESEJA EXECUTAR
                k++; // INCREMENTO
            } while (k < 5); // CONDICAO


            // Repeticao do tipo FOREACH
            List numeros = [0, 1, 2, 3, 4]; // CONJUNTOS DE NUMEROS

            foreach(var num in numeros){ // PARA CADA ITEM (num) DA LISTA (numeros)
                Console.WriteLine(num); // EXECUTE ESTE CODIGO - NO CASO MOSTRAR NA TELA O VALOR DE num.
            }
        }
    }
}
