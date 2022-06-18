using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotationDot
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace(" World", " Mundo");

            Console.WriteLine(saudacao);

            Console.WriteLine(saudacao.Length);

            string valor = null;

            // Console.WriteLine(valor.Length); ERROR
            Console.WriteLine(valor?.Length); // forma segura para não gerar erro em cima de valores possivelmente nulos.
        }
    }
}
