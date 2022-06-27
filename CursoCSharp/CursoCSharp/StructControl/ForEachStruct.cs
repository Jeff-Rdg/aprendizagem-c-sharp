using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.StructControl
{
    internal class ForEachStruct
    {
        public static void Executar()
        {
            var palavra = "opa!";
            // foreach em string
            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "gui" };
            // foreach em array
            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
