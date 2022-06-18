using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolation
    {
        public static void Executar()
        {
            string nome = "Notebook";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("o " + nome + " da marca " + marca + " custa " + preco);

            // interpolação

            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

            // outra forma

            Console.WriteLine($"A marca {marca} é boa!");

        }
    }
}
