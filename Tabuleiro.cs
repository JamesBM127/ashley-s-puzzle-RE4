using System;
using System.Collections.Generic;
using System.Text;

namespace game
{
    class Tabuleiro
    {
        protected int tamColunas;
        protected int tamLinhas;
        private bool tabuleioJaExiste = false;
        public string[,] tabuleiroCompleto;
        public bool[,] posicaoJogador;

        public Tabuleiro() { }

        protected void construtorTabuleiro(int tamLinhas, int tamColunas)
        {
            this.tamLinhas = tamLinhas;
            this.tamColunas = tamColunas;
        }

        private string[,] criarNumerosTabuleiro()
        {
            string[,] tabArray = new string[tamLinhas, tamColunas];
            Random random = new Random();
            for (int i = 0; i < tamLinhas; i++) {
                for (int j = 0; j < tamColunas; j++) {
                    int aux = random.Next(1, (tamColunas * tamLinhas));
                    if (ecxist(aux, tabArray) == false) {
                        tabArray[i, j] = aux.ToString();
                        posicaoJogador[i, j] = false;
                    }
                    else if(i == tamLinhas-1 && j == tamColunas-1) {
                        tabArray[tamLinhas-1, tamColunas-1] = "  ";
                        posicaoJogador[tamLinhas - 1, tamColunas - 1] = true;
                    }
                    else {
                        j--;
                    }
                }
            }
            return tabArray;
        }

        //Isso verifica se o número já existe no tabuleiro;
        private bool ecxist(int numero, string[,]tabArray)
        {
            for(int i = 0; i < tamLinhas; i++) {
                for(int j = 0; j < tamColunas; j++) {
                    if(tabArray[i,j] == numero.ToString()) {
                        return true;//Se retorna True, então o numero ja existe no tabuleiro;
                    }
                }
            }
            return false;//Se retorna False, o número não existe e é adicionado ao tabuleiro;
        }

        public void criarTabuleiro()
        {
            string[,] tabArray = new string[tamLinhas, tamColunas];
            if (tabuleioJaExiste == false) {
                posicaoJogador = new bool[tamLinhas, tamColunas];
                tabArray = criarNumerosTabuleiro();
                tabuleioJaExiste = true;
            }
            tabuleiroCompleto = tabArray;
        }

        public void mostrarTabuleiro()
        {
            for (int i = 0; i < tamLinhas; i++) {
                for (int j = 0; j < tamColunas; j++) {
                    if (posicaoJogador[i, j] == false) {
                        if (tabuleiroCompleto[i, j].Length == 1) {
                            Console.Write($" 0{tabuleiroCompleto[i, j]} ");
                        }
                        else {
                            Console.Write($" {tabuleiroCompleto[i, j]} ");
                        }
                    }
                    else {
                        if (tabuleiroCompleto[i, j].Length == 1) {
                            Console.Write($"[0{tabuleiroCompleto[i, j]}]");
                        }
                        else {
                            Console.Write($"[{tabuleiroCompleto[i, j]}]");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public void mostrarTabuleiroBool()
        {
            for (int i = 0; i < tamLinhas; i++) {
                for (int j = 0; j < tamColunas; j++) {
                    Console.Write("{0} ", posicaoJogador[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
