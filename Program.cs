using System;

namespace exercicio_logica_programacao10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Descobrir se os lados informados formam ou não um triângulo

            //Dados 3 valores quaisquer informados pelo usuário(a, b e c) representando as medidas dos lados de um triângulo, 
            //faça um algoritmo para descobrir se formam ou não um triângulo.

            //Saiba que para formar um triângulo, o valor de cada lado deve ser menor que a soma dos outros 2 lados.

            //- ‘a’, ‘b’, e ‘c’ devem formam um triângulo, a função retorna e imprime "É um triângulo"
            //- se as medidas não formam um triângulo, a função retorna e imprime "NÃO é um triângulo"

            //Utilize programação orientada a objetos.

            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Informar lados A do triangulo:");
            triangulo.A = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Informar lado B do triangulo:");
            triangulo.B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informar lado C do triangulo:");
            triangulo.C = Convert.ToInt32(Console.ReadLine());

            triangulo.ValidarTriangulo();

            triangulo.ImprimirResultado();

        }

    }
}
