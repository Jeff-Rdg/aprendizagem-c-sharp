using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Comments
    {
        // Comentários para criação de documentação utiliza "///".

        /// <summary>
        /// 
        /// </summary>
        public static void Executar()
        {
            //cuidado com os comentários desnecessários;
            Console.WriteLine("Codigo claro é sempre melhor!");
            /*
                Comentários de 
                multiplas linhas.             
            */
            Console.WriteLine("o C# tem o XML Comments");
        }
    }
}
