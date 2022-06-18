using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class ReadingData
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua Idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é seu salario?");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // modificando dados da cultura do sistema operacional pra impressão correta

            Console.WriteLine($"O nome é {nome}, sua idade é {idade} e seu salario é {salario}");

        }
    }
}
