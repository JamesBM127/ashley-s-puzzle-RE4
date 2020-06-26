using System;
using System.Collections.Generic;
using System.Text;

namespace game
{
    class Tabuleiro
    {
        public int tamHor;
        public int tamVer;

        public Tabuleiro() { }
        public Tabuleiro(int tamHorizontal, int tamVertical)
        {
            tamHor = tamHorizontal;
            tamVer = tamVertical;
        }

        public int[,] criarTabuleiro()
        {
            int[,] tabArray = new int[tamVer, tamHor];                
            int count = 1;
            for (int i = 0; i < tamVer; i++) {
                for (int j = 0; j < tamHor; j++) {
                    tabArray[i, j] = count;
                    count++;
                }
            }
            return tabArray;
        }
    }
}
