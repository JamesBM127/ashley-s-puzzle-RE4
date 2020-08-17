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
            int tamLinhas = 4, tamColunas = 4;
            /*
            //NÃO APAGAR ISSO, LER ANTES DE TENTAR APAGAR, esse comentário faz o jogador escolher o tamanho do tabuleiro;
            /*
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
            bool vitoria = false;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;

            while (!vitoria) {
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
                vitoria = movimentos.Win();
            }
            Console.Clear();
            movimentos.mostrarTabuleiro();
            Console.WriteLine("Parabens, você ganhou");
            Console.ReadKey();
        }
    }
}