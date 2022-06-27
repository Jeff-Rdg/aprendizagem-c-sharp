using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.StructControl
{
    internal class UsingBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O numero que queremos é {0}", numero);

            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine("{0} é o numero que queremos? " , i);
                if(i == numero)
                {
                    Console.WriteLine("Sim!");
                    break; // utilizado em estruturas de repetição para sair do loop.
                }
                else
                {
                    Console.WriteLine("Não!");
                }
            }
        }
    }
}
