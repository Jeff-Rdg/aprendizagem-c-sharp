using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.StructControl
{
    internal class WhileStruct
    {
        public static void Executar()
        {
            int palpite = 0;
            Random rand = new Random();

            int numeroSecreto = rand.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativas = 5;
            int chances = 0;

            // enquanto as tentativas forem maior que 0 e o numero encontrado for false, continuará a execução
            while(tentativas > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Insira seu palpite:");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);
                // as chances serão incrementadas e as tentativas decrementadas.
                chances++;
                tentativas--;

                if(numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", chances);
                    Console.BackgroundColor = corAnterior;
                }else if(palpite > numeroSecreto)
                {
                    Console.WriteLine("O Valor é menor, tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativas);
                }
                else
                {
                    Console.WriteLine("O valor é maior, tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativas);
                }

            }



        }
    }
}
