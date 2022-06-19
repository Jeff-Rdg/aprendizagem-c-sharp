using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class LogicalOperator
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            // Operadores Binários
            var comprouTv50 = executouTrabalho1 && executouTrabalho2; // e
            Console.WriteLine("comprou a tv 50? {0}",comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; // ou
            Console.WriteLine("comprou sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // ou exclusivo
            Console.WriteLine("comprou a tv 32? {0}", comprouTv32);

            // Operadores Unários
            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
        }
    }
}
