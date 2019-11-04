using System;

namespace comparador_avancado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparador avançado de inteiros!");

            Console.WriteLine("Insira o primeiro inteiro:");
            Int32 n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o segundo inteiro:");
            Int32 n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o terceiro inteiro:");
            Int32 n3 = Convert.ToInt32(Console.ReadLine());

            int s, p, m = 0; 
            
            

            if (n1 == n2 && n2 == n3)
            {
                Console.WriteLine("Os numeros são iguais!");
            }
            else
            {
                s = n1 + n2 + n3;
                Console.WriteLine("A soma dos números é: "+ s);

                p = n1 * n2 * n3;
                Console.WriteLine("O produto dos números é: "+ p);

                m = s / 3;
                Console.WriteLine("A média dos números é: "+ m);

                if (n1 > n2 && n1 > n3)
                    Console.WriteLine("O maior numero é: "+ n1);
                if (n2 > n1 && n2 > n3)
                    Console.WriteLine("O maior numero é: "+ n2);
                if (n3 > n1 && n3 > n2)
                    Console.WriteLine("O maior número é: "+ n3);
                if (n1 < n2 && n1 < n3)
                    Console.WriteLine("O menor número é: "+ n1);
                if (n2 < n1 && n2 < n3)
                    Console.WriteLine("O menor número é: "+ n2);
                if (n3 < n1 && n3 < n2)
                    Console.WriteLine("O menor número é: "+ n3);
            }

                

        
        }
    }
}
