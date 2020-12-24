using System;

namespace URI_1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor =0;
            int maiorValor=0;
            int posição =0;

            for (int i = 1; i <=100; i ++){
                valor = int.Parse(Console.ReadLine());
                if (valor > maiorValor){    
                    maiorValor = valor;
                    posição = i;
                }            
            }
            Console.WriteLine(maiorValor);
            Console.WriteLine(posição);
        }
    }
}
