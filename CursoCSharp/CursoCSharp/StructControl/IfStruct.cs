using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.StructControl
{
    internal class IfStruct
    {
        public static void Executar()
        {
            bool bomComport = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento? (S/N)");
            entrada = Console.ReadLine();

            bomComport = entrada.ToUpper() == "S";

            if(nota >= 9.0 && bomComport)
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
