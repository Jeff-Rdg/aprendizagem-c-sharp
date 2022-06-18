using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversions
    {
        public static void Executar()
        {
            // implicita
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            // explicita
            double nota = 9.7;
            int notaInt = (int) nota;
            Console.WriteLine(notaInt);

            // Formas de transformar string em inteiro
            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeInteiro);
            Console.WriteLine("Resultado :{0}", idadeInteiro);

            Console.Write("Digite um número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero); // tenta passar a palavra dentro da variavel numero;
            Console.WriteLine(numero);

            // outra maneira mais otimizada
            Console.Write("Digite outro número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine(numero2);


        }
    }
}
