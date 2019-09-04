using System;

namespace Funcoes
{
    class Funcoes
    {
        // Função principal
        static void Main(string[] args)
        {
            // Funcao sem parametros
            void olaMundo(){
                Console.WriteLine("Ola Mundo");
            }

            // Uma funcão pode ser estruturada desta forma caso só possua um comando entre as chaves
            void olaMundoUmComando() => Console.WriteLine("Ola Mundo com apenas um comando");

            // Função que recebe parâmetros
            void calcularSoma(double a, double b){
                double resultado = a + b;
                Console.WriteLine(resultado);
            }

            // Função que retorna um valor do tipo int
            int returnMultiplicacao(int a, int b){
                int resultado = a * b;
                return resultado;
            }

            // Função que retorna um valor, mas em sua versão reduzida (possui apenas uma linha de comando)
            double calcularAreaCirculo(double raio) => 3.14 * raio * raio;

            // Passar funcões como parâmetros
            void calcular (Action<double, double> funcao, double a, double b){
                funcao(a , b);
            }
            
            // Executando as funções
            olaMundo();
            olaMundoUmComando();
            calcularSoma(5.5,15.5);
            Console.WriteLine(returnMultiplicacao(2, 10));
            Console.WriteLine(calcularAreaCirculo(8));
            calcular(calcularSoma, 2.5, 2.5);
        }
    }
}
