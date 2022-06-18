using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormattingNumbers
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));// 1 casa decimal
            Console.WriteLine(valor.ToString("C"));// Monetário
            Console.WriteLine(valor.ToString("P"));// percentual
            Console.WriteLine(valor.ToString("#.##"));// outra forma de 2 casas decimais

            CultureInfo culture = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C", culture)); // Monetário 

            int inteiro = 265;
            Console.WriteLine(inteiro.ToString("D10")); // adição de 0 a esquerda.
        }
    }
}
