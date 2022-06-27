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

            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "gui" };

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
