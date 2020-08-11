using System;
using System.Collections.Generic;
using System.Text;

namespace game
{
    class Movimentos : Tabuleiro
    {
        public Movimentos(int tamLinhas, int tamColunas) {
            construtorTabuleiro(tamLinhas, tamColunas);
        }

        public void movimentacaoPlayer()
        {
            bool movimentoValido = false;
            ConsoleKeyInfo escolhaMovimento = Console.ReadKey();
            switch (escolhaMovimento.Key) {

                case ConsoleKey.RightArrow:
                    movimentoValido = verificarMovimento(escolhaMovimento.Key);
                    if(movimentoValido == true) {
                        for (int i = 0; i < tamLinhas; i++){
                            for (int j = 0; j < tamColunas; j++) {
                                if(posicaoJogador[i, j] == true) {
                                    posicaoJogador[i, j] = false;
                                    posicaoJogador[i, j + 1] = true;
                                    i = tamLinhas;
                                    break;
                                }
                            }
                        }
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    movimentoValido = verificarMovimento(escolhaMovimento.Key);
                    if (movimentoValido == true) {
                        for (int i = 0; i < tamLinhas; i++) {
                            for (int j = 0; j < tamColunas; j++) {
                                if (posicaoJogador[i, j] == true) {
                                    posicaoJogador[i, j] = false;
                                    posicaoJogador[i, j - 1] = true;
                                    i = tamLinhas;
                                    break;
                                }
                            }
                        }
                    }
                    break;

                case ConsoleKey.UpArrow:
                    movimentoValido = verificarMovimento(escolhaMovimento.Key);
                    if (movimentoValido == true) {
                        for (int i = 0; i < tamLinhas; i++) {
                            for (int j = 0; j < tamColunas; j++) {
                                if (posicaoJogador[i, j] == true) {
                                    posicaoJogador[i, j] = false;
                                    posicaoJogador[i - 1, j] = true;
                                    i = tamLinhas;
                                    break;
                                }
                            }
                        }
                    }
                    break;

                case ConsoleKey.DownArrow:
                    movimentoValido = verificarMovimento(escolhaMovimento.Key);
                    if (movimentoValido == true) {
                        for (int i = 0; i < tamLinhas; i++) {
                            for (int j = 0; j < tamColunas; j++) {
                                if (posicaoJogador[i, j] == true) {
                                    posicaoJogador[i, j] = false;
                                    posicaoJogador[i + 1, j] = true;
                                    i = tamLinhas;
                                    break;
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private bool verificarMovimento(ConsoleKey escolhaMovimento)
        {
            for(int i = 0; i < tamLinhas; i++) {
                for(int j = 0; j < tamColunas; j++) {
                    if(i == 0 && escolhaMovimento == ConsoleKey.UpArrow && posicaoJogador[i,j] == true) {
                        return false;
                    }
                    else if(j == 0 && escolhaMovimento == ConsoleKey.LeftArrow && posicaoJogador[i,j] == true) {
                        return false;
                    }
                    else if(i == tamLinhas - 1 && escolhaMovimento == ConsoleKey.DownArrow && posicaoJogador[i,j] == true) {
                        return false;
                    }
                    else if(j == tamColunas-1 && escolhaMovimento == ConsoleKey.RightArrow && posicaoJogador[i,j] == true) {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}