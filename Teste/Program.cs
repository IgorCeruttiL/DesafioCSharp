using System;
using System.Text;

namespace DesafioCSharp
{
    internal class DesafioCSharp
    {
        static void Main(string[] args)
        {
            // Diz se o número pertence a sequência fibonacci ou não
            Fibonacci();
            
            //Inverte o texto
            Inverter();
        }

        public static void Fibonacci()
        {
            Console.WriteLine("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 1;

            while (c < n)
            {
                c = a + b;
                a = b;
                b = c;
            }

            if (c == n)
            {
                Console.WriteLine($"O numero {n} pertence a sequência fibonacci");
            }

            else
            {
                Console.WriteLine($"O numero {n} não pertence a sequência fibonacci");
            }
            
        }

        public static void Inverter()
        {
            string frase = "Teste C-Sharp estágio";
            StringBuilder sb = new StringBuilder();
            for (int i= frase.Length-1; i >= 0; i--)
            {
                sb.Append(frase[i]);
            }

            
            Console.WriteLine(sb);

        }
    }
}