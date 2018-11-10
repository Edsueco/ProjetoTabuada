using System;
namespace sistematabuada
{
    public class Tabuada
    {
        //public string op { set; get; }

        public void montaTabuada(string op)
        {

            for (int i = 1; i <= 9; i++)
            {
                //Console.WriteLine("Tabuada de {0}", i);

                for (int j = 1; j <= 9; j++)
                {
                    if (op == "+")      { Console.Write("{0} + {1} = {2}\t", i, j, i + j); }
                    else if (op == "-") { Console.Write("{0} - {1} = {2}\t", i, j, i - j); }
                    else if (op == "*") { Console.Write("{0} * {1} = {2}\t", i, j, i * j); }
                    else if (op == "/") { Console.Write("{0} / {1} = {2}\t", i, j, i / j); }
                }
                Console.WriteLine("\n");
            }

        }

        public Tabuada()
        {
        }
    }
}
