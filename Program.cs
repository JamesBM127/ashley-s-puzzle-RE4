using System;
using System.Linq;
using System.Collections.Generic;

namespace game
{
    class Program
    {
        static void Main()
        {
            int tamHorizontal, tamVertical;
            do {
                Console.WriteLine("TAMANHO DO TABULEIRO");
                Console.Write("Horizontalmente: ");
                tamHorizontal = int.Parse(Console.ReadLine());
                Console.Write("Verticalmente: ");
                tamVertical = int.Parse(Console.ReadLine());
                if(tamHorizontal * tamVertical >= 100) {
                    Console.WriteLine("Tamanho máximo ultrapassado");
                }
            } while (tamHorizontal * tamVertical >= 100);

            Tabuleiro tabObj = new Tabuleiro(tamHorizontal, tamVertical); //Criar o OBJ
            string[,] tabuleiro = tabObj.criarTabuleiro();

            
        }
    }
}


/*
for (int i = 0; i < tamVertical; i++) {
                for (int j = 0; j < tamHorizontal; j++) {
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