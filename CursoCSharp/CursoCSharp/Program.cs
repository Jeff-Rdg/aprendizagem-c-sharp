using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", FirstProgram.Executar},
                {"Comentarios - Fundamentos", Comments.Executar},
                {"Variaveis e Constantes - Fundamentos", VarAndConst.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}