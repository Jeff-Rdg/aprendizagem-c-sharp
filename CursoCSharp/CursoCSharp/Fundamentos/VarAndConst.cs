using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VarAndConst
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("A área é " + area);

            // tipos primitivos do C#
            bool estaChovendo = true;

            byte idade = 45;

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("O saldo de gols é: " + saldoDeGols);

            short salary = short.MaxValue;
            Console.WriteLine("Salario: " + salary);

            int menorValor = int.MinValue;
            Console.WriteLine("Menor int: " + menorValor);

            uint populacaoBrasileira = 207600000;

            long menorValorLong = long.MinValue;

            ulong populacao = long.MaxValue;

            float precoComputador = 1299.99f;


        }
    }
}
