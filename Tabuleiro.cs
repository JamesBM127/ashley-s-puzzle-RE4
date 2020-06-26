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

        public string[,] criarTabuleiro()
        {
            string[,] tabArray = new string[tamVer, tamHor];
            Random random = new Random();
            for (int i = 0; i < tamVer; i++) {
                for (int j = 0; j < tamHor; j++) {
                    int aux = random.Next(1, (tamHor * tamVer));
                    if (ecxist(aux, tabArray) == false) {
                        tabArray[i, j] = aux.ToString();
                    }
                    else if(i == tamVer-1 && j == tamHor-1) {
                        tabArray[tamVer-1, tamHor-1] = "  ";
                        j++;
                    }
                    else {
                        j--;
                    }
                }
            }
            return tabArray;
        }

        private bool ecxist(int numero, string[,]tabArray)
        {
            for(int i = 0; i < tamVer; i++) {
                for(int j = 0; j < tamHor; j++) {
                    if(tabArray[i,j] == numero.ToString()) {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
