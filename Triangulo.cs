using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_logica_programacao10
{
    public class Triangulo
    {
        public int A = 10;
        public int B = 10;
        public int C = 10;

        public string ValidarTriangulo()
        {
            string teste;
            if (A + B > C && A + C > B && B + C > A)
                teste = "É um triangulo";
            else
                teste = "Não é triangulo";

            return teste;
        }   

        public void ImprimirResultado()
        {
            Console.WriteLine($"Retorno: {ValidarTriangulo()}");
        }
    }
}
