using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            Random random = new Random();
            int maxValue = tamHor * tamVer;
            for (int i = 0; i < tamVer; i++) {
                for (int j = 0; j < tamHor; j++) {
                    int aux = random.Next(1, maxValue + 1);
                    if (ecxist(aux, tabArray) == false) {
                        tabArray[i, j] = aux;
                    }
                    else {
                        j--;
                    }
                }
            }
            return tabArray;
        }

        private bool ecxist(int numero, int[,]tabArray)
        {
            for(int i = 0; i < tamVer; i++) {
                for(int j = 0; j < tamHor; j++) {
                    if(tabArray[i,j] == numero) {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
