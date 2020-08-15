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
            //int tamLinhas = 2, tamColunas = 2;
            
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
            
            Movimentos movimentos = new Movimentos(tamLinhas, tamColunas);
            movimentos.criarTabuleiro();
            
            ConsoleKeyInfo escolhaMovimento;
            bool vitoria = false;

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

            Console.WriteLine("Parabens, você ganhou");
        }
    }
}