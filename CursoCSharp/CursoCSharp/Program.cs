using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.StructControl;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", FirstProgram.Executar},
                {"Comentarios - Fundamentos", Comments.Executar},
                {"Variaveis e Constantes - Fundamentos", VarAndConst.Executar},
                {"Inferencia de tipos - Fundamentos", Inference.Executar},
                {"Interpolação de Strings - Fundamentos", Interpolation.Executar},
                {"Notação ponto - Fundamentos", NotationDot.Executar},
                {"Leitura de dados - Fundamentos", ReadingData.Executar},
                {"Formatando Números - Fundamentos", FormattingNumbers.Executar},
                {"Conversões - Fundamentos", Conversions.Executar},
                {"Operadores aritméticos - Fundamentos", ArithmeticOperator.Executar},
                {"Operadores Relacionais - Fundamentos", RelationalOperation.Executar},
                {"Operadores Lógicos - Fundamentos", LogicalOperator.Executar},
                {"Operadores de Atribuição - Fundamentos", AssignmentOperator.Executar},
                {"Operadores Unários - Fundamentos", UnaryOperators.Executar},
                {"Operador Ternário - Fundamentos", TernaryOperator.Executar},
                // Estrutura de controle
                {"If - Estrutura de controle", IfStruct.Executar},
                {"If/Else - Estrutura de controle", IfElseStruct.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}