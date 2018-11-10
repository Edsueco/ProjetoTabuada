using System;

namespace sistematabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuada t1 = new Tabuada();
            int i = 0;
            while(i<4){
                Console.WriteLine("MONTE SUA TABUADA");
                Console.WriteLine("+ SOMAR");
                Console.WriteLine("- SUBTRAIR");
                Console.WriteLine("* MULTIPLICAR");
                Console.WriteLine("/ DIVIDIR");
                Console.Write("DIGITE A OPÇÃO DESEJADA: ");
                t1.montaTabuada(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();
                i++;
            }

        }
    }
}
