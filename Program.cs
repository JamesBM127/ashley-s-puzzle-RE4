using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace game
{
    class Program
    {
        static void Main()
        {
            int tamLinhas = 5, tamColunas = 5;
            /*
            //NÃO APAGAR ISSO, LER ANTES DE TENTAR APAGAR;
            int tamLinhas, tamColunas;
            do {
                Console.WriteLine("TAMANHO DO TABULEIRO");
                Console.Write("LINHAS: ");
                tamLinhas = int.Parse(Console.ReadLine());
                Console.Write("COLUNAS: ");
                tamColunas = int.Parse(Console.ReadLine());
                if(tamLinhas * tamColunas >= 100) {
                    Console.WriteLine("Tamanho máximo ultrapassado");
                }
            } while (tamLinhas * tamColunas >= 100);
            */
            Movimentos movimentos = new Movimentos(tamLinhas, tamColunas);
            movimentos.criarTabuleiro();
            
            ConsoleKeyInfo escolhaMovimento;

            while (true) {
                Console.Clear();
                movimentos.mostrarTabuleiro();
                escolhaMovimento = Console.ReadKey();
                switch (escolhaMovimento.Key) {
                    case ConsoleKey.Spacebar:
                        movimentos.mudarPosicao();
                        break;
                    default:
                        movimentos.movimentacaoPlayer(escolhaMovimento.Key);
                        break;
                }
            }

            

        }
    }
}


/*
for (int i = 0; i < tamColunas; i++) {
    for (int j = 0; j < tamLinhas; j++) {
        if (tabuleiro[i, j].Length == 1) {
            Console.Write($"[0{tabuleiro[i,j]}]");
        }
        else {
            Console.Write($"[{tabuleiro[i,j]}]");
        }
    }
    Console.WriteLine();
}

*/