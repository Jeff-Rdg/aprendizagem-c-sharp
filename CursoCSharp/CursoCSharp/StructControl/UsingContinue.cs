using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.StructControl
{
    internal class UsingContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("Os numeros pares entre 1 e {0}!", intervalo);

            for(int i = 0; i < intervalo; i++)
            {
                if(i % 2 == 1)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
        }

    }
}
