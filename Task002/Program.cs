﻿// На вход некоторому исполнителю подаётся два числа (a, b). У исполнителя
// есть две команды
// - команда 1 (к1): увеличить в с раза, а умножается на c
// - команда 2 (к2): увеличить на d ( +2 ), к a прибавляется d
// написать программу, которая выдаёт количество возможных путей и пример набора команд, позволяющий число a
// превратить в число b или сообщить, что это невозможно
// Пример 1: а = 1, b = 7, c = 2, d = 1
// ответ: к1, к1, к1, к1, к1, к1 или к1, к2, к1, к1, к1 или к1, к1, к2, к1.
// Пример 2: а = 11, b = 7, c = 2, d = 1
// ответ: нет решения

namespace Task002;
    public class Program
    {
        public static void Main()
        {
            Controller.Run();
        }
    }





