﻿using System;
using tabuleiro;

namespace xadrez_console {
    class program
    {
        static void Main(String[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
    
}